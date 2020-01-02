using System;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Collections;
using Geomethod;

namespace Mosaic.GeoLib
{
	public interface IColorIndexer
	{
		Color GetColor(string name);		
	}

	public interface IImageIndexer
	{
		Image GetImage(string name);		
	}

	public class StyleBuilder
	{
		PenStyleBuilder sbPen;
		PenStyleBuilder sbPen2;
		BrushStyleBuilder sbBrush;
		ImageStyleBuilder sbImage;
		TextStyleBuilder sbText;
		ExtStyleBuilder sbExt;
		IColorIndexer ci;
		IImageIndexer ii;
		string styleStr="";
		StringBuilder sbErrors=new StringBuilder();

		public IColorIndexer ColorIndexer{get{return ci;}}
		public IImageIndexer ImageIndexer{get{return ii;}}
		public string StyleStr{get{return styleStr;}}
		//		public bool HasError{get{return sb.Length>0;}}
		public bool CheckErrors()
		{
			if(sbErrors.Length==0) return false;
			string msg=sbErrors.ToString()+string.Format("\r\n({0})",styleStr);
//!!!			Log.Error(msg,"sberrors");
			return true;
		}
		internal void AddErrorMsg(string msg){if(sbErrors.Length>0) sbErrors.Append("\r\n"); sbErrors.Append(msg);}

		public StyleBuilder(IColorIndexer ci,IImageIndexer ii)
		{
			this.ci=ci;
			this.ii=ii;
			sbPen=new PenStyleBuilder(this,"p");
			sbPen2=new PenStyleBuilder(this,"sp");
			sbBrush=new BrushStyleBuilder(this,"b");
			sbImage=new ImageStyleBuilder(this,"i");
			sbText=new TextStyleBuilder(this);
			sbExt=new ExtStyleBuilder(this);
		}
		void Clear()
		{
			sbPen.Clear();
			sbPen2.Clear();
			sbBrush.Clear();
			sbImage.Clear();
			sbText.Clear();
			sbExt.Clear();
			sbErrors.Length=0;
		}
		void AddParams()
		{
			foreach(string p in styleStr.Split(','))
			{
				int i=p.IndexOf('=');
				if(i>=0)
				{
					AddParam(p.Substring(0,i).Trim(),p.Substring(i+1).Trim());
				}
				else
				{
					AddParam(p.Trim(),null);
				}
			}
		}
		void AddParam(string key,string val)
		{
			if(key.Length==0) return;
			char firstChar=key[0];
			switch(firstChar)
			{
				case 'p':
					sbPen.AddParam(key.Substring(1),val);
					break;
				case 's':
					if(key.StartsWith("sp")) sbPen2.AddParam(key.Substring(2),val);
					else goto default;
					break;
				case 'b':
					sbBrush.AddParam(key.Substring(1),val);
					break;
				case 'i':
					sbImage.AddParam(key.Substring(1),val);
					break;
				case 't':
				case 'f':
					sbText.AddParam(key,val);
					break;
				case 'e':
					sbExt.AddParam(key,val);
					break;
				default:
					string s=string.Format("{0}: {1}",Locale.Get("sbwrongparname"),key);
					AddErrorMsg(s);
					break;
			}
		}
		public Style Parse(string s)
		{
			if(s==null||s.Length==0) return null;
			styleStr=s.ToLower();
			Clear();
			try
			{
				AddParams();
				Style style=new Style();
				style.pen=sbPen.GetPen();
				style.pen2=sbPen2.GetPen();
				style.brush=sbBrush.GetBrush();
				style.imageStyle=sbImage.GetImageStyle();
				style.textStyle=sbText.GetTextStyle();
				style.extStyle=sbExt.GetExtStyle();
				return style.IsNull() ? null : style;
			}
			catch(Exception ex)
			{
//!!!				Log.Exception(ex);
			}
			return null;
		}
		public void OnError(string s)
		{
//!!!			Log.Warning(s,"sberror");
		}
	}
}
