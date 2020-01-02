using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Collections;
using Geomethod;

namespace Mosaic.GeoLib
{
	public class ImageStyle
	{
		public Image image;
		public ImageAttributes attr;
		public ImageStyle(){image=null;attr=null;}
		public ImageStyle(Image image,ImageAttributes attr){this.image=image;attr=this.attr;}
	}

	public class ImageStyleBuilder: BaseStyleBuilder
	{
		public ImageStyleBuilder(StyleBuilder sb,string prefix):base(sb,prefix){}
		public ImageStyle GetImageStyle()
		{
			string imageName=base.GetValue("");
			if(imageName==null) return null;
			Image image=base.GetImage(imageName,"");
			if(image==null) return null;
			return new ImageStyle(image,null);
		}
	}
}
