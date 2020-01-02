using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Xml.Serialization;
using System.Diagnostics;

namespace Mosaic
{
	[XmlRootAttribute]
	public class Config
	{
		#region Static
		public static readonly Version currentVersion = new Version(1, 0, 0);// should be incremented at each config schema change!

		public static Config Load()// log ignored
		{
			return Load(Config.ConfigFilePath);
		}

		public static Config Load(string filePath)// log ignored
		{
			if(!File.Exists(filePath)) return new Config();
			Config config;
			XmlSerializer xs = new XmlSerializer(typeof(Config));
			using (TextReader reader = new StreamReader(filePath))
			{
				config = (Config)xs.Deserialize(reader);
			}
//			config.changed = !config.IsChecksumOk;

//            Palette.Load( config );


			return config;
		}

		public static string BaseDirectory{get{return AppDomain.CurrentDomain.BaseDirectory;}}// log ignored
		public static string ConfigFilePath{get{return BaseDirectory+configFileName;}}// log ignored
		public static string PreviousConfigFilePath{get{return BaseDirectory+previousConfigFileName;}}// log ignored
		#endregion

		public const string configFileName = "Mosaic.xml";
		public const string previousConfigFileName = "MosaicPrev.xml";
//		bool changed = false;
		Version version=new Version(1,0,0);
		public DateTime lastchanged;
		public string checksum;
		public string Version{get{return version.ToString();}set{version=new Version(value);}}
//		public bool Changed { get { return changed; } }

//		public string connStr="";
//		public int debugMode = 0;
//		public int timerInterval = 5000;
		public int pannoWidth = 30000;
		public int pannoHeight = 20000;
		public int tileWidth = 200;
		public int tileHeight = 200;
		public int gap = 10;
		public Color gapColor = Color.LightGray;
		public int XmlGapColor { get { return gapColor.ToArgb(); } set { gapColor = Color.FromArgb(value); } }
		public Color gridColor = Color.Yellow;
		public int XmlGridColor { get { return gridColor.ToArgb( ); } set { gridColor = Color.FromArgb( value ); } }
		public int mx = 9;// matrix number of tiles along x
		public int my = 9;// matrix number of tiles along y
		public int GapPeriodX { get { return tileWidth + gap; } }
		public int GapPeriodY { get { return tileHeight + gap; } }
		public int GridPeriodX { get { return GapPeriodX*mx; } }
		public int GridPeriodY { get { return GapPeriodY*my; } }

		public List<Palette> palettes = new List<Palette>();

		#region Construction
		public Config()
		{
		}

		#endregion

		#region SavePalette
        public void SaveAs(string filePath)
		{
			version = currentVersion;
			lastchanged = DateTime.Now;
			checksum = CheckSum;
			XmlSerializer xs = new XmlSerializer(typeof(Config));
			using (TextWriter writer = new StreamWriter(filePath))
			{
				xs.Serialize(writer, this);
			}
		}

		public void Save()
		{
//			bool changed = !IsChecksumOk;
//			if (changed)
			{
				SaveAs(ConfigFilePath);
//				changed = false;
			}
		}
		#endregion

		#region Aux
		public bool IsChecksumOk// log ignored
		{
			get { return checksum == CheckSum; }
		}
/*	public bool IsChanged { get { return changed; } }
		public void SetChanged()
		{
			changed = true;
		}*/

		string CheckSum
		{
			get
			{
				string checksum0=checksum;
				checksum="";
				try
				{
					XmlSerializer xs = new XmlSerializer(typeof(Config));
					using(MemoryStream ms=new MemoryStream(1<<16))
					{
						using(TextWriter writer = new StreamWriter(ms))
						{
							xs.Serialize(writer, this);
							long count=ms.Length;
							long sum=0;
							ms.Position=0;
							for(long i=0;i<count;i++) sum+=ms.ReadByte()*i;
							return string.Format("{0:X}",sum);
						}
					}
				}
				finally
				{
					checksum=checksum0;
				}
			}
		}
		#endregion

		#region PriningMode
		public	int		MatrixRealSize = 200;				//		Размер матрицы при печати
		public	int		MatrixBevel = 10;					//		Зазор между матрицами
		public	bool	printTileColorMode = false;			//		Заливать плитку цветом
		//		public	Color	MatrixLineColor = Color.DarkGray;	//		Цвет разделительный линий

		public Color MatrixLineColor = Color.LightGray;		//		Цвет разделительный линий
		public int XmlMatrixLineColor 
			{	get { return MatrixLineColor.ToArgb(); } 
				set { MatrixLineColor = Color.FromArgb(value); } }

		#endregion


	}
}
