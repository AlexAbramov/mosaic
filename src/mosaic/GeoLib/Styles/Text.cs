using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using Geomethod;

namespace Mosaic.GeoLib
{
	public class TextStyle
	{
	  public Font font;
		public Brush brush;
		public StringFormat stringFormat;

		public TextStyle(){Clear();}
		public TextStyle(Font font,Brush brush,StringFormat stringFormat){this.font=font;this.brush=brush;this.stringFormat=stringFormat;}
		public void Clear(){font=null;brush=null;stringFormat=null;}
	}

	public class TextStyleBuilder: BaseStyleBuilder
	{
		BrushStyleBuilder sbBrush;
		public TextStyleBuilder(StyleBuilder sb):base(sb,""){sbBrush=new BrushStyleBuilder(sb,"tb");}
		public new void Clear(){sbBrush.Clear();base.Clear();}
		public new void AddParam(string key,string val)
		{
			if(key.StartsWith("tb")) sbBrush.AddParam(key.Substring(2),val);
			else base.AddParam(key,val);
		}
		public TextStyle GetTextStyle()
		{
/*			Font font=null;
			string fn=null;
			float fs=10.0f;
			if(ht.ContainsKey("fn")) fn=(string)ht["fn"];
			if(ht.ContainsKey("fs")) fs=float.Parse((string)ht["fs"]);
			if(fn!=null) font=new Font(fn,fs);
			if(font==null) return null;//!!!
			TextStyle ts=new TextStyle(font,lib.DefaultTextStyle.brush,lib.DefaultTextStyle.stringFormat);
			return ts;*/
			return null;
		}
	}
}
