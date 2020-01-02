using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using Geomethod;

namespace Mosaic.GeoLib
{
	public class BrushStyleBuilder: BaseStyleBuilder
	{
		ImageStyleBuilder sbImage;
		public BrushStyleBuilder(StyleBuilder sb,string prefix):base(sb,prefix){sbImage=new ImageStyleBuilder(sb,prefix+"i");}
		public new void Clear(){sbImage.Clear();base.Clear();}
		public new void AddParam(string key,string val)
		{
			if(key.Length==0) return;
			if(key.StartsWith("i"))
			{
				sbImage.AddParam(key.Substring(1),val);
			}
			else base.AddParam(key,val);
		}		
		public Brush GetBrush()
		{
			if(sbImage.Count>0)
			{
				ImageStyle imageStyle=sbImage.GetImageStyle();
				if(imageStyle!=null) return GetTextureBrush(imageStyle);
			}
			if(Count==0) return null;
			if(HasKey("hs")) return GetHatchBrush();
			return GetSolidBrush();
		}
		SolidBrush GetSolidBrush()
		{
			string cStr=GetValue("c");
			if(cStr==null) return null;
			Color c=GetColor(cStr,"c");
			if(c.ToArgb()==0) return null;
			SolidBrush sb=new SolidBrush(c);
			return sb;
		}
		HatchBrush GetHatchBrush()
		{
			string hsStr=GetValue("hs");
			string cStr=GetValue("c");
			string c2Str=GetValue("c2");
			if(hsStr==null||cStr==null) return null;
			object hsObj=base.GetEnum(typeof(HatchStyle),hsStr,"hs");
			if(hsObj==null) return null;
			HatchStyle hs=(HatchStyle)hsObj;
			Color c=GetColor(cStr,"c");
			if(c.ToArgb()==0) return null;
			HatchBrush hb=null;
			if(c2Str!=null)
			{
				Color c2=GetColor(c2Str,"c2");
				if(c2.ToArgb()!=0) hb=new HatchBrush(hs,c,c2);
			}
			if(hb==null) hb=new HatchBrush(hs,c);
			return hb;
		}
		TextureBrush GetTextureBrush(ImageStyle imageStyle)
		{
			TextureBrush tb=null;
			if(imageStyle.attr==null) tb=new TextureBrush(imageStyle.image);
			else
			{
				Rectangle r=new Rectangle(0,0,imageStyle.image.Width,imageStyle.image.Height);
				tb=new TextureBrush(imageStyle.image,r,imageStyle.attr);
			}
			return tb;
		}
	}
}
