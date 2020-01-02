using System;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Collections;
using Geomethod;

namespace Mosaic.GeoLib
{
	public class Style
	{
		public Pen pen;
		public Pen pen2;
		public Brush brush;
		public ImageStyle imageStyle;
		public TextStyle textStyle;
		public ExtStyle extStyle;

		public void Clear(){pen=null;pen2=null;brush=null;imageStyle=null;textStyle=null;extStyle=null;}
		public bool IsNull(){return pen==null && pen2==null && brush==null && imageStyle==null && textStyle==null && extStyle==null;}
		public Style(){Clear();}
	}
}