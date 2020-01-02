using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using Geomethod;
using Geomethod.Windows.Forms;

namespace Mosaic
{
//    [XmlRootAttribute]
    public class Palette
	{
		public string name = "";
		public string imageFilePath = "";
		public int Count { get { return colors.Count; } }
		public List<NamedColor> colors = new List<NamedColor>();
		public Palette() { }

		public NamedColor GetNearestColor(Color c)
		{
			NamedColor ncMin = null;
			int distMin = int.MaxValue;
			foreach (NamedColor nc in colors)
			{
//  DZ
        if ( !nc.active || nc.name == "‘ÓÌ" )
            continue;

				int dist = nc.GetColorDistance(c);
				if (dist < distMin)
				{
					distMin = dist;
					ncMin = nc;
				}
			}
			return ncMin;
		}

		public override string ToString()
		{
			return name;
    }
/*
        #region SavePalette
        public void Save()
        {

            string dir = PathUtils.BaseDirectory;
            XmlSerializer xs = new XmlSerializer( typeof( Palette ) );
            using( StreamWriter writer = new StreamWriter( dir + "Palettes" + @"\" + this.name ) )
            {
                xs.Serialize( writer, this );
            }
        }

        public static Palette Load( string name )
        {

            XmlSerializer xs = new XmlSerializer( typeof( Palette ) );
            using( StreamReader reader = new StreamReader( name ) )
            {
                Palette pl = (Palette)xs.Deserialize( reader );
                return pl;
            }
        }

        public static void Load( Config config )
        {

            string dir = PathUtils.BaseDirectory;

            if( !Directory.Exists( dir + "Palettes" ) )
                return;

            config.palettes.Clear();

            DirectoryInfo di = new DirectoryInfo( dir + "Palettes" );         
            FileInfo[] fi = di.GetFiles();

            foreach( FileInfo fiTemp in fi )
            {

                Palette pl = Palette.Load( dir + "Palettes" + @"\" + fiTemp.Name );
                config.palettes.Add( pl );
            }
        }
        #endregion
 * */
    }
}
