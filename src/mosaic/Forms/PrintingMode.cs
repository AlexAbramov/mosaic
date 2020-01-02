using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Geomethod.Windows.Forms;

namespace Mosaic
{
	public partial class PrintingMode : Form
	{
		public PrintingMode( )
		{
			InitializeComponent( );
		}

		private void PrintingMode_Load( object sender, EventArgs e )
		{
            if (!DesignMode)
            {
                GmApplication.Initialize(this);

                Config c = App.Config;

                this.textBoxMB.Text = c.MatrixBevel.ToString();
                this.textBoxMRS.Text = c.MatrixRealSize.ToString();
                this.checkBoxLP.Checked = c.printTileColorMode;
                this.buttonColor.BackColor = c.MatrixLineColor;
            }
		}

		private void buttonOK_Click( object sender, EventArgs e )
		{
			int	MRS;
			int	MB;
			if ( Int32.TryParse( textBoxMRS.Text, out MRS )
				&& Int32.TryParse( textBoxMB.Text, out MB ) )
			{
				App.Config.MatrixRealSize = MRS;
				App.Config.MatrixBevel = MB;
				App.Config.printTileColorMode = checkBoxLP.Checked;
				App.Config.MatrixLineColor = this.buttonColor.BackColor;
				Close( );
			}
		}

		private void buttonCancel_Click( object sender, EventArgs e )
		{
			Close( );
		}

		private void buttonColor_Click( object sender, EventArgs e )
		{
			ColorDialog cd = new ColorDialog ();
			cd.FullOpen = true;
			cd.ShowDialog();
			this.buttonColor.BackColor = cd.Color;           
		}
	}
}