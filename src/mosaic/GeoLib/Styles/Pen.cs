using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using Geomethod;

namespace Mosaic.GeoLib
{
	public class PenStyleBuilder: BaseStyleBuilder
	{
		BrushStyleBuilder sbBrush;
		public PenStyleBuilder(StyleBuilder sb,string prefix):base(sb,prefix){sbBrush=new BrushStyleBuilder(sb,prefix+"b");}
		public new void Clear(){sbBrush.Clear();base.Clear();}
		public new void AddParam(string key,string val)
		{
			if(key.Length==0) return;
			char firstChar=key[0];
			if(firstChar=='b')
			{
				sbBrush.AddParam(key.Substring(1),val);
			}
			else base.AddParam(key,val);
		}
		public Pen GetPen()
		{
			Pen pen=null;
			if(sbBrush.Count>0)
			{
				Brush br=sbBrush.GetBrush();
				if(br!=null) pen=new Pen(br);
			}
			if(pen==null)
			{
				string cStr=GetValue("c");
				if(cStr!=null)
				{
					Color c=GetColor(cStr,"c");
					if(c.ToArgb()!=0) pen=new Pen(c);
				}
			}
			if(pen!=null)
			{
				for(int i=0;i<Count;i++)
				{
					string key=GetKey(i);
					switch(key)
					{
						case "w":
							string wStr=GetValue(i);
							if(wStr!=null)
							{
								float w=base.GetFloat(wStr,key);
								if(!float.IsNaN(w))	pen.Width=w;
							}
							break;
						case "ds":
							string dsStr=GetValue(i);
							if(dsStr!=null)
							{
								object dsObj=base.GetEnum(typeof(DashStyle),dsStr,key);
								if(dsObj!=null) pen.DashStyle=(DashStyle)dsObj;
							}
							break;
					}
				}
			}
			return pen;
		}
	}
}
