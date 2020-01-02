using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Mosaic.GeoLib
{
	public class DefaultStyle
	{
		internal Style style = null;
		public DefaultStyle() { }
		public Pen Pen { get { return style != null && style.pen != null ? style.pen : Parameters.DefaultPen; } }
		public Brush Brush { get { return style != null && style.brush != null ? style.brush : Parameters.DefaultBrush; } }
		public TextStyle TextStyle { get { return style != null && style.textStyle != null ? style.textStyle : Parameters.DefaultTextStyle; } }
	}

	public class GLib
	{
		bool mirror = true;
		Rect bounds = new Rect(0,0,300,200);
		UnitMeasure unitMeasure = UnitMeasure.mkm100;
		int smin = 1;
		int smax = 100;
		Scales scales;
		DefaultStyle defaultStyle = new DefaultStyle();
		Style style = new Style();
		BgImage bgImage=null;
		GGrid grid = null;
		GGap gap = null;

		public Rect Bounds { get { return bounds; } set { bounds = value; } }
		public bool Mirror { get { return mirror; } set { mirror = value; } }
		public UnitMeasure UnitMeasure { get { return unitMeasure; } }
		public int SMin { get { return smin; } set { smin = value;  } }
		public int SMax { get { return smax; } set { smax = value; } }
		public DefaultStyle DefaultStyle { get { return defaultStyle; } }
		public Scales Scales { get { return scales; } }
		public BgImage BgImage { get { return bgImage; } }
		public GGrid Grid { get { return grid; } }
		public GGap Gap { get { return gap; } }


		public GLib()
		{
			scales = new Scales(this);
			scales.InitScales();
			style.pen = Pens.Blue;
			bgImage = new BgImage(this);
			grid = new GGrid(this);
			gap = new GGap(this);
		}

		public void Draw(Map map)
		{
			bgImage.Draw(map);
			gap.Draw(map);
			grid.Draw(map);
//			map.DrawRect(style, bounds);
		}
	}

	public class GGrid
	{
		public int dx=0;
		public int dy = 0;
//		public int gap = 0;
		Style style = new Style();
		public Color color = Color.Yellow;
		public bool visible = true;
		GLib lib;
		public GGrid(GLib lib)
		{ 
			this.lib = lib; 
			style.pen = new Pen(color);
		}
		public void Draw(Map map)
		{
			if (visible)
			{
				if (dx > 0 && dy > 0)
				{
					style.pen.Color = color;
					Point p1, p2;
					p1 = lib.Bounds.LeftTop;
					p2 = lib.Bounds.RightBottom;
					for (int x = lib.Bounds.left; x < lib.Bounds.right; x += dx)
					{
						p1.X = x;
						p2.X = x;
						map.DrawLine(style, p1, p2);
					}
					p1 = lib.Bounds.LeftTop;
					p2 = lib.Bounds.RightBottom;
					for (int y = lib.Bounds.bottom; y < lib.Bounds.top; y += dy)
					{
						p1.Y = y;
						p2.Y = y;
						map.DrawLine(style, p1, p2);
					}
				}
			}
		}
	}

	public class GGap
	{
		public int dx = 0;
		public int dy = 0;
		public int gap = 0;
		Style style = new Style();
		public Color color = Color.LightGray;
		public bool visible = true;
		GLib lib;
		public GGap(GLib lib)
		{
			this.lib = lib;
			style.pen = new Pen(color);
//			style.brush = new SolidBrush(color);
		}
		public void Draw(Map map)
		{
			if(map.PixelScale > gap) return;
			if (visible)
			{
				if (dx > 0 && dy > 0 && gap > 0)
				{
					style.pen.Color = color;
//					(style.brush as SolidBrush).Color = color;
					Point p1, p2;
					p1 = lib.Bounds.LeftTop;
					p2 = lib.Bounds.RightBottom;
//					int hgap = gap / 2;
//					Rect r = new Rect(p1.X, p1.Y, p2.X, p2.Y);
					for (int x = lib.Bounds.left; x < lib.Bounds.right; x += dx)
					{
/*						r.left = x;
						r.right = x + gap;
						map.DrawRect(style, r);*/
						p1.X = x;
						p2.X = x;
						map.DrawLine(style, p1, p2);
					}
					p1 = lib.Bounds.LeftTop;
					p2 = lib.Bounds.RightBottom;
//					r = new Rect(p1.X, p1.Y, p2.X, p2.Y);
					for (int y = lib.Bounds.bottom; y < lib.Bounds.top; y += dy)
					{
/*						r.bottom = y;
						r.top = y + gap;
						map.DrawRect(style, r);*/
						p1.Y = y;
						p2.Y = y;
						map.DrawLine(style, p1, p2);
					}
				}
			}
		}
	}
}
