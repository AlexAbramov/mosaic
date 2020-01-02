using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data;
using System.Collections;
using Geomethod;

namespace Mosaic.GeoLib
{
	public class BgImage 
	{
		GLib lib;
		//code
		int x = 0;
		int y = 0;
		public int dx = 0;
		public int dy = 0;
/*		float scaleX = 0;
		float scaleY = 0;
		float angle = 0;*/
		ImageAttributes ia = new ImageAttributes();
		ColorMatrix cm = new ColorMatrix();
		Image image = null;
		/*		public int Opacity
				{
					get{return opacity;}
					set
					{
						if(opacity==value)return; opacity=value; 
						cm.Matrix33=opacity*0.01f;
						ia.SetColorMatrix(cm);
						UpdateAttr(BgImageField.Opacity);
					}
				}*/
		public Image Image { get { return image; } set { image = value; } }
		public int X { get { return x; } set {  x = value; } }
		public int Y { get { return y; } set {  y = value;  } }
//		public float ScaleX { get { return scaleX; } set { scaleX = value; } }
//		public float ScaleY { get { return scaleY; } set { scaleY = value; } }
//		public float Angle { get { return angle; } set { angle = value; } }

		#region Construction
/*		public BgImage(Map map)
		{
			this.lib = map.Lib;
			X = map.Pos.X;
			Y = map.Pos.Y;
			Scale = (float)map.PixelScale;
		}*/

		internal BgImage(GLib lib)
		{
			this.lib = lib;
		}

		#endregion

		public void Draw(Map map)
		{
			if (image != null)
			{
				SolidBrush br=new SolidBrush(Color.White);
				Style st=new Style();
				st.brush=br;
//				map.DrawImageNonRotated(image, ia, new Point(x, y), scaleX, scaleY);
				Bitmap b=image as Bitmap;
				for(int i=0;i<image.Width;i++)
					for (int j = 0; j < image.Height; j++)
					{ 
						Color c=b.GetPixel(i,j);
						br.Color=c;
						int x=i*dx;
						int y=j*dy;
						Rect r=new Rect(x,y,x+dx,y+dy);
						map.DrawRect(st, r);
					}
			}
		}
	}
}
