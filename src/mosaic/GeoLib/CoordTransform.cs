using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Mosaic.GeoLib
{
	public class CoordTransform
	{
		Point pos;
		double pixelScale;
		float angle;//grad
		double m1,m2,m3,m4;
		Rect rect;
		Point rectCenter;
		Rect bounds=Rect.Null;
		bool mirror;

		public bool IsVisible(long wsize)
		{
			if(wsize<0) wsize=-wsize;
			return wsize>pixelScale*Constants.minSizeVisible;
		}

		protected CoordTransform(Rect bounds,Rect rect,bool mirror)
		{
		  this.rect=rect;
			rectCenter=rect.Center;
			angle=0;
			this.mirror=mirror;
			SetBounds(bounds);
		}
		public bool Mirror{get{return mirror;}set{mirror=value;}}

		protected void SetBounds(Rect bounds)
		{
			bool hor=bounds.Width*rect.Height>bounds.Height*rect.Width;
			pos=bounds.Center;
			pixelScale=hor ? (double)bounds.Width/rect.Width : (double)bounds.Height/rect.Height;
			UpdateMatrixAndBounds();
		}

		protected Rect Rect
		{
			get{return rect;}
			set{rect=value;rectCenter=rect.Center;UpdateBounds();}
		}

		public double PixelScale{get{return pixelScale;}set{pixelScale=value;UpdateMatrixAndBounds();}}
		public Point Pos{get{return pos;}set{pos=value;UpdateBounds();}}
		public float Angle{get{return angle;}set{angle=value;UpdateMatrixAndBounds();}}
		public void WToG(Point[] points){for(int i=0;i<points.Length;i++) WToG(ref points[i]);}
		public void GToW(Point[] points){for(int i=0;i<points.Length;i++) GToW(ref points[i]);}
		public Rect Bounds{get{return bounds;}}
		public bool Intersects(Rect rect){return bounds.Intersects(rect);}
		public bool Intersects(Point point){return bounds.Contains(point);}
		public void WToG(ref Point p)
		{
			double x=p.X-pos.X;
			double y=p.Y-pos.Y;
			p.X=rectCenter.X+(int)(m1*x-m2*y);
			p.Y=(int)(m2*x+m1*y);
			if(!mirror) p.Y=-p.Y;
			p.Y+=rectCenter.Y;
		}
		public Point WToG(Point p)
		{
			int y=(int)(m2*p.X+m1*p.Y);
			if(!mirror) y=-y;
			return new Point(rectCenter.X+(int)(m1*p.X-m2*p.Y),rectCenter.Y+y);
		}
		public void GToW(ref Point p)
		{
			double x=p.X-rectCenter.X;
			double y=p.Y-rectCenter.Y;
			if(!mirror) y=-y;
			p.X=pos.X+(int)(m3*x+m4*y);
			p.Y=pos.Y+(int)(-m4*x+m3*y);
		}
		public Point GToW(Point p)
		{
			p.X-=rectCenter.X;
			p.Y-=rectCenter.Y;
			if(!mirror) p.Y=-p.Y;
			return new Point(pos.X+(int)(m3*p.X+m4*p.Y),pos.Y+(int)(-m4*p.X+m3*p.Y));
		}
		public void GToW(ref Size s)
		{
			double x=s.Width;
			double y=s.Height;
			if(!mirror) y=-y;
			s.Width=(int)(m3*x+m4*y);
			s.Height=(int)(-m4*x+m3*y);
		}

		void UpdateMatrixAndBounds()
		{
			UpdateMatrix();
			UpdateBounds();
		}
		void UpdateMatrix()
		{
			double angleRad=angle*Math.PI/180;
			double cosa=(double)Math.Cos(angleRad);
			double sina=(double)Math.Sin(angleRad);
			m1=cosa/pixelScale;
			m2=sina/pixelScale;			
			m3=cosa*pixelScale;
			m4=sina*pixelScale;
		}
		public Rect GToW(Rect r)
		{
			Point[] points=r.Points;
			GToW(points);
			r.Init(points);
			return r;
		}
		void UpdateBounds()
		{
			bounds=GToW(rect);
		}
		public void Rotate(float angle)
		{
			if(!mirror) angle=-angle;
			this.angle+=angle;
			UpdateMatrixAndBounds();
		}
		public void Move(Direction dir)
		{
			Size size=GetVector(dir);
			Rectangle r=Rect;
			size.Width*=r.Width/3;
			size.Height*=r.Height/3;
			GToW(ref size);
			pos+=size;
			UpdateBounds();
		}
		public static Size GetVector(Direction dir)
		{
			switch(dir)
			{
				case Direction.Left: return new Size(-1,0);
				case Direction.Top: return new Size(0,-1);
				case Direction.Right: return new Size(1,0);
				case Direction.Bottom: return new Size(0,1);
				case Direction.LeftTop: return new Size(-1,-1);
				case Direction.RightTop: return new Size(1,-1);
				case Direction.LeftBottom: return new Size(-1,1);
				case Direction.RightBottom: return new Size(1,1);
			}
			return new Size(0,0);
		}
	}
}
