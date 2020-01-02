using System;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Collections;
using Geomethod;

namespace Mosaic.GeoLib
{
	public class BaseStyleBuilder
	{
		StyleBuilder sb;
		string prefix;
		ArrayList keys=new ArrayList();
		ArrayList values=new ArrayList();
		public int Count{get{return keys.Count;}}
		public BaseStyleBuilder(StyleBuilder sb,string prefix)
		{
			this.sb=sb;
			this.prefix=prefix;
		}
		public void Clear(){keys.Clear();values.Clear();}
		protected void AddErrorMsg(string s){sb.AddErrorMsg(s);}
		public void AddParam(string key,string val){keys.Add(key);values.Add(val);}
		public Color GetColor(string colorName,string parName)
		{
			Color c=Color.Empty;
			try
			{
				c=sb.ColorIndexer==null ? Color.FromName(colorName) : sb.ColorIndexer.GetColor(colorName);
			}
			catch
			{
			}
			if(c.ToArgb()==0)
			{
				string msg=string.Format("{0}: {1}{2}={3}",Locale.Get("sbwrongcolorformat"),prefix,parName,colorName);
				AddErrorMsg(msg);
			}
			return c;
		}
		public Image GetImage(string imageName,string parName)
		{
			Image image=null;
			try
			{
				image=sb.ImageIndexer==null ? null : sb.ImageIndexer.GetImage(imageName);
			}
			catch
			{
			}
			if(image==null)
			{
				string msg=string.Format("{0}: {1}{2}={3}",Locale.Get("sbimagenotfound"),prefix,parName,imageName);
				AddErrorMsg(msg);
			}
			return image;
		}
		public float GetFloat(string valStr,string parName)
		{
			try
			{
				return float.Parse(valStr);
			}
			catch
			{
				string msg=string.Format("{0}: {1}{2}={3}",Locale.Get("sbwrongfloatformat"),prefix,parName,valStr);
				AddErrorMsg(msg);
				return float.NaN;
			}
		}
		public object GetEnum(Type enumType,string valStr,string parName)
		{
			try
			{
				return Enum.Parse(enumType,valStr,true);
			}
			catch
			{
				string msg=string.Format("{0}: {1}{2}={3}",Locale.Get("sbwrongenumval"),prefix,parName,valStr);
				AddErrorMsg(msg);
				return null;
			}
		}
		public bool HasKey(string paramName){return keys.Contains(paramName);}
		public string GetKey(int i){return keys[i] as string;}
		public string GetValue(int i){return values[i] as string;}
		public string GetValue(string paramName)
		{
			for(int i=0;i<keys.Count;i++)
			{
				if(paramName == keys[i] as string) return values[i] as string;
			}
			return null;
		}
	}

}
