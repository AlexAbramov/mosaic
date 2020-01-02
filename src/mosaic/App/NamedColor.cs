using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Mosaic
{
	public class NamedColor
	{
		public string name;
		[XmlIgnore]
		public Color color;
		public int XmlColor { get { return color.ToArgb(); } set { color = Color.FromArgb(value); } }

//      DZ
    public bool active;
		[XmlIgnore]
    public Color old;
		[XmlIgnore]
		public int count=0;

		public NamedColor( string name, Color color, bool active )
        {
            this.name=name;
            this.color=color;
            this.active = active;

        }
		public NamedColor() 
        {
            this.active = true;
  
        }
		public int GetColorDistance(Color c)
		{
			int r=(int)color.R-c.R;
			int g=(int)color.G-c.G;
			int b=(int)color.B-c.B;
			return r*r+g*g+b*b;
		}
		public override string ToString()
		{
			return name;
		}
	}


  
}