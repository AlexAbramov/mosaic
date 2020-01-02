using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using Geomethod;

namespace Mosaic.GeoLib
{

	// glib constants
	public enum UnitMeasure { Millimeter, Centimeter, Inch, Meter, mkm100 };
	public enum GeomType { Point, Polyline, Polygon, Caption };


	public class Constants
	{
		static Constants()
		{
			StyleBuilder sb = new StyleBuilder(null, null);
			selStyle = sb.Parse("pc=yellow, pw=2, spc=red, spds=dash");
			sb.CheckErrors();
			editLineStyle = sb.Parse("pc=yellow, pw=3, spc=red");
			sb.CheckErrors();
			editPointStyle = sb.Parse("pc=red");
			sb.CheckErrors();
			stringFormat = new StringFormat();
			stringFormat.Alignment = stringAlignment; stringFormat.LineAlignment = stringAlignment;
			textStyle = new TextStyle(font, textBrush, stringFormat);
		}
		public const int imagesHashtableSize = 1024;
		public const int currentLib = 1;
		public const int priorityInc = 100;
		public const int byteBufferSize = 1 << 16;
		public static readonly byte[] marker = new byte[] { 1, 2, 3, 4 };
		public const int maxScale = 1000000;
		public const int minScale = 1;
		public const float cmPerInch = 2.54f;
		public const int pointRadius = 2;
		public const int selRadius = 5;
		public const int minSizeVisible = 5;
		public const int searchRadius = 10;
		public const float searchSmRadius = 0.25f;
		public const int maxSearchCount = 100;
		public const int updateAttrCreated = 0;
		public const int minRecordId = 0;
		public const int maxRecordId = 2000000000;
		public const int poolSize = 10;

		#region Styles
		public static readonly Pen pen = Pens.DarkGray;
		public static readonly Brush brush = Brushes.WhiteSmoke;
		public static readonly Brush textBrush = Brushes.Black;
		public static readonly Font font = new Font("Times", 10);
		public static readonly Style selStyle;
		public static readonly Style editLineStyle;
		public static readonly Style editPointStyle;
		public static readonly StringAlignment stringAlignment = StringAlignment.Center;
		public static readonly StringFormat stringFormat;
		public static readonly TextStyle textStyle;
		#endregion

		#region Names
		public const string nullFileName = "null";
		static string defaultLayerName = null;
		static string defaultTypeName = null;
		static string defaultViewName = null;
		public static string DefaultLayerName
		{
			get
			{
				if (defaultLayerName != null) return defaultLayerName;
				defaultLayerName = Locale.Get("defaultlayername");
				return defaultLayerName;
			}
		}
		public static string DefaultTypeName
		{
			get
			{
				if (defaultTypeName != null) return defaultTypeName;
				defaultTypeName = Locale.Get("defaulttypename");
				return defaultTypeName;
			}
		}
		public static string DefaultViewName
		{
			get
			{
				if (defaultViewName != null) return defaultViewName;
				defaultViewName = Locale.Get("defaultviewname");
				return defaultViewName;
			}
		}
		#endregion
	}

	public class Parameters
	{
		static Parameters()
		{
		}
		static int selRadius = 0;
		static int pointRadius = 0;
		public static int PointRadius { get { return pointRadius > 0 ? pointRadius : Constants.pointRadius; } set { pointRadius = value; } }
		public static int SelRadius { get { return selRadius > 0 ? selRadius : Constants.selRadius; } set { selRadius = value; } }

		#region Styles
		static Style defaultStyle = null;
		public static Pen DefaultPen { get { return defaultStyle != null && defaultStyle.pen != null ? defaultStyle.pen : Constants.pen; } }
		public static Brush DefaultBrush { get { return defaultStyle != null && defaultStyle.brush != null ? defaultStyle.brush : Constants.brush; } }
		public static TextStyle DefaultTextStyle { get { return defaultStyle != null && defaultStyle.textStyle != null ? defaultStyle.textStyle : Constants.textStyle; } }
		#endregion

		#region Selection
		internal static Style selStyle = null;
		internal static Style editLineStyle = null;
		internal static Style editPointStyle = null;
		public static Style SelStyle { get { return selStyle != null ? selStyle : Constants.selStyle; } }
		public static Style EditLineStyle { get { return editLineStyle != null ? editLineStyle : Constants.editLineStyle; } }
		public static Style EditPointStyle { get { return editPointStyle != null ? editPointStyle : Constants.editPointStyle; } }
		#endregion

		#region Misc
		public static int maxFormWidth = 1024;
		#endregion
	}
}