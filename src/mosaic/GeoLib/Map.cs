using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Mosaic.GeoLib
{
	public class Map: CoordTransform //, IFilter
	{
		#region Fields
		GLib lib;
		Image image=null;
		Graphics graphics=null;
		int scale;
		double dpi;

//		Selection selection=new Selection();
		#endregion

		#region Properties
		public double PixelPerUnitMeasure{get{return dpi*GeomUtils.GetInches(lib.UnitMeasure);}}
		public GLib Lib{get{return lib;}}
		public double Dpi{get{return dpi;}set{dpi=value;PixelScale=scale/PixelPerUnitMeasure;}}
		public Image Image{get{return image;}}
//		public Selection Selection{get{return selection;}}
		public bool CanScaleUp{get{return lib.SMin<scale && 1<scale;}}
		public bool CanScaleDown{get{return lib.SMax==0 || scale<lib.SMax;}}
		#endregion 

		#region Construction
		public Map(GLib lib, Size size): base(lib.Bounds, new Rect(size), lib.Mirror)
		{
			this.lib=lib;
			Resize(size);
			UpdateScale();
			ScaleDown();
		}
		#endregion

		#region Drawing
		Pen GetPen(Style style) { return style != null && style.pen != null ? style.pen : lib.DefaultStyle.Pen; }
		Brush GetBrush(Style style) { return style != null && style.brush != null ? style.brush : lib.DefaultStyle.Brush; }
		TextStyle GetTextStyle(Style style) { return style != null && style.textStyle != null ? style.textStyle : lib.DefaultStyle.TextStyle; }
		public void Draw()
		{
			graphics.ResetTransform();
			graphics.Clear(Color.White);
			lib.Draw(this);
/*!!!			using (context = lib.GetContext())
			{
			}
			lib.Selection.Draw(this);
			selection.Draw(this);*/
		}
		public void DrawLine(Style style, Point p1, Point p2)
		{
			WToG(ref p1);
			WToG(ref p2);
			Pen pen = GetPen(style);
			graphics.DrawLine(pen, p1, p2);
			if (style != null && style.pen2 != null) graphics.DrawLine(style.pen2, p1, p2);
		}
		public void DrawPolyline(Style style, Point[] points)
		{
			if (points.Length < 2) return;
			Point[] pts = (Point[])points.Clone();
			WToG(pts);
			Pen pen = GetPen(style);
			graphics.DrawLines(pen, pts);
			if (style != null && style.pen2 != null) graphics.DrawLines(style.pen2, pts);
		}
		public void DrawPolygon(Style style, Point[] points)
		{
			if (points.Length < 3) return;
			Point[] pts = (Point[])points.Clone();
			WToG(pts);
			Brush brush = style == null || (style.pen == null && style.pen2 == null) ? GetBrush(style) : style.brush;
			if (brush != null) graphics.FillPolygon(brush, pts);
			if (style != null)
			{
				if (style.pen != null) graphics.DrawPolygon(style.pen, pts);
				if (style.pen2 != null) graphics.DrawPolygon(style.pen2, pts);
			}
		}
		public void DrawRect(Style style, Rect rect) { DrawPolygon(style, rect.Points); }
		public void DrawPoint(Style style, Point p)
		{
			WToG(ref p);
			if (style != null && style.imageStyle != null)
			{
				Image image = style.imageStyle.image;
				if (image != null)
				{
					p.X -= image.Size.Width / 2;
					p.Y -= image.Size.Height / 2;
					graphics.DrawImageUnscaled(image, p);
					return;
				}
				//				ImageAttributes ia;
			}
			Pen pen = GetPen(style);
			int r = Parameters.PointRadius;
			graphics.DrawEllipse(pen, p.X - r, p.Y - r, r + r, r + r);
		}
		public void DrawImage(Image image, ImageAttributes ia, Point pos, float scale, float angle)
		{
			WToG(ref pos);
			graphics.TranslateTransform(pos.X, pos.Y);
			scale /= this.scale;
			graphics.ScaleTransform(scale, scale);
			graphics.RotateTransform(angle - this.Angle);
			Rectangle r = new Rectangle(-image.Width / 2, -image.Height / 2, image.Width, image.Height);
//			graphics.DrawImage(image, r, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, ia);
			graphics.DrawImage(image, 0, -image.Height);
			graphics.ResetTransform();
		}
		public void DrawImageNonRotated(Image image, ImageAttributes ia, Point pos, float scaleX, float scaleY)
		{
			WToG(ref pos);
			graphics.TranslateTransform(pos.X, pos.Y);
			scaleX /= (float)PixelScale;
			scaleY /= (float)PixelScale;
			graphics.ScaleTransform(scaleX, scaleY);
			graphics.TranslateTransform(-0.5f,-0.5f);
			//			Rectangle r = new Rectangle(0, 0, image.Width, image.Height);
//			graphics.DrawImage(image, r, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, ia);
			graphics.DrawImageUnscaled(image, -1, -image.Height+1);
			graphics.ResetTransform();
		}
		public void DrawImageNonRotated(Image image)
		{
			Point[] pp = Lib.Bounds.Points;
			WToG(pp);
			Rect r = new Rect(pp);
			graphics.DrawPolygon(Pens.AliceBlue, pp);//!!!
			RectangleF rf = new RectangleF(r.left, r.top, r.Width, r.Height);
//			graphics.DrawImage(image, r, Rectangle.FromLTRB(0,image.Height,image.Width,0),GraphicsUnit.Pixel);
			graphics.DrawImage(image, r.left,r.top,r.Width,r.Height);
		}
		public void DrawCircle(Style style, Point p, int rad)
		{
			WToG(ref p);
			Pen pen = GetPen(style);
			graphics.DrawEllipse(pen, p.X - rad, p.Y - rad, rad * 2, rad * 2);
			if (style.pen2 != null) graphics.DrawEllipse(style.pen2, p.X - rad, p.Y - rad, rad * 2, rad * 2);
		}
		public void DrawText(Style style, Point p, string text)
		{
			TextStyle ts = GetTextStyle(style);
			WToG(ref p);
			graphics.DrawString(text, ts.font, ts.brush, p, ts.stringFormat);
		}
		public void DrawText(Style style, Point p, string text, float angle)
		{
			TextStyle ts = GetTextStyle(style);
			WToG(ref p);
			graphics.TranslateTransform(p.X, p.Y);
			angle += Angle;
			if (!Mirror) angle = -angle;
			GeomUtils.NormalizeAngle(ref angle);
			graphics.RotateTransform(angle);
			graphics.DrawString(text, ts.font, ts.brush, 0, 0, ts.stringFormat);
			graphics.ResetTransform();
		}
		#endregion


		#region Navigation
		public void ScaleUp()
		{
			Scale=Lib.Scales.Prev(Scale);
		}
		public void ScaleDown()
		{
			Scale=Lib.Scales.Next(Scale);
		}
		public void RotateCW()
		{
			Rotate(10);
		}
		public void RotateCCW()
		{
			Rotate(-10);
		}
		public new void SetBounds(Rect bounds)
		{
			base.SetBounds(bounds);
			UpdateScale();
			int newScale=Scale;
			int prevScale=lib.Scales.Prev(newScale);
			int nextScale=lib.Scales.Next(newScale);
			if(newScale<prevScale) newScale=prevScale;
			else if(newScale>nextScale) newScale=nextScale;			 
			Scale=newScale;
		}
		void UpdateScale(){scale=(int)(PixelScale*PixelPerUnitMeasure);}
		public bool EnsureVisible(Rect bounds)
		{
			if(base.Bounds.Contains(bounds)) return false;
			Point wp=bounds.Center;
			bool samePos=base.Pos==wp;
		  if(!samePos) Pos=wp;
			if(bounds.Width==0 && bounds.Height==0)	return !samePos;
			int scale0=Scale;
			while(!Bounds.Contains(bounds))
			{
			  int prevScale=Scale;
				ScaleUp();
				if(prevScale==Scale) break;
			}
			return scale0!=Scale;
		}
/*		public void SetView(View view)
		{
			if(view.IsDefault)
			{
				SetDefaultView();
			}
			else
			{
				Pos=view.Pos;
				Scale=view.Scale;
				Angle=view.Angle;
			}
		}*/
		public void SetDefaultView()
		{
			Angle=0;
			SetBounds(lib.Bounds);
			UpdateScale();
			ScaleDown();
		}
		#endregion

		#region Utils
		public void Resize(Size size)
		{
			if(size.Width<=0||size.Height<=0) return;
			if(image!=null) image.Dispose();
			if(graphics!=null) graphics.Dispose();
			image=new Bitmap(size.Width,size.Height);
			graphics=Graphics.FromImage(image);
			graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
			dpi=graphics.DpiX;
			Rect=new Rect(size);
		}
		#endregion

		#region IFilter Members

		public int Scale
		{
			get { return scale; }
			set
			{
				scale = value;
				if (lib.SMin > 0 && scale < lib.SMin) scale = lib.SMin;
				if (lib.SMax > 0 && scale > lib.SMax) scale = lib.SMax;
				if (scale < 1) scale = 1;
				PixelScale = scale / PixelPerUnitMeasure;
			}
		}

		#endregion
	}
}
