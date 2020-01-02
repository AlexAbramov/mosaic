using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Geomethod;
using Geomethod.Windows.Forms;

using System.IO;

namespace Mosaic
{
	public interface IMainForm
	{
		void MosaicFormClosed(MosaicForm form);
	}

	public partial class MainForm : Form, IMainForm
	{
		List<MosaicForm> mosaicForms = new List<MosaicForm>();
		Image origImage = null;

		Rectangle rect;

		public MainForm()
		{
			InitializeComponent();
		}

		Palette SelectedPalette { get { return lbPalettes.SelectedItem as Palette; } }

		private void MainForm_Load(object sender, EventArgs e)
		{
            if (!DesignMode)
            {
                GmApplication.Initialize(this);
                MinimumSize = Size;
                App.MainForm = this;
                dlgOpenFile.InitialDirectory = PathUtils.BaseDirectory;
                nudPannoWidth.Value = App.Config.pannoWidth / 10;
                nudPannoHeight.Value = App.Config.pannoHeight / 10;
                nudTileWidth.Value = App.Config.tileWidth / 10;
                nudTileHeight.Value = App.Config.tileHeight / 10;
                nudGap.Value = (decimal)0.1 * App.Config.gap;
                chkSquare.Checked = App.Config.tileWidth == App.Config.tileHeight;
                lblGapColor.BackColor = App.Config.gapColor;
                lblGridColor.BackColor = App.Config.gridColor;
                nudMX.Value = App.Config.mx;
                nudMY.Value = App.Config.my;
                UpdatePalettesListBox();
            }
    }

    private void UpdatePalettesListBox()
		{
			lbPalettes.DataSource = null;
			lbPalettes.DataSource = App.Config.palettes;
		}

		private void miOpen_Click(object sender, EventArgs e)
		{
			Open();
		}

		private void miExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void miAbout_Click(object sender, EventArgs e)
		{
			try
			{
				AboutForm form = new AboutForm();
				form.ShowDialog();
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
            {
                
/*                #region SavePalette

                string dir = PathUtils.BaseDirectory;

                if( !Directory.Exists( dir +   "Palettes" ) )
                    Directory.CreateDirectory( dir +  "Palettes" );
                foreach( Palette pl in App.Config.palettes )
                    pl.Save();

                App.Config.palettes.Clear();

                #endregion*/

				App.Config.Save();

            }
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void nudPannoWidth_ValueChanged(object sender, EventArgs e)
		{
			App.Config.pannoWidth = (int)nudPannoWidth.Value*10;
			UpdateControls();
		}

		private void nudPannoHeight_ValueChanged(object sender, EventArgs e)
		{
    	App.Config.pannoHeight = (int)nudPannoHeight.Value*10;
			UpdateControls();
		}

		private void nudTileWidth_ValueChanged(object sender, EventArgs e)
		{
			App.Config.tileWidth = (int)nudTileWidth.Value*10;
			if(chkSquare.Checked) nudTileHeight.Value = nudTileWidth.Value;
			UpdateControls();
		}

		private void nudTileHeight_ValueChanged(object sender, EventArgs e)
		{
			App.Config.tileHeight = (int)nudTileHeight.Value*10;
			if (chkSquare.Checked) nudTileWidth.Value = nudTileHeight.Value;
			UpdateControls();
		}

		private void btnImage_Click(object sender, EventArgs e)
		{
			Open();

      if( pictureBox.Image != null )
				lblFilePath.Text = dlgOpenFile.FileName +
              "  (" + pictureBox.Image.Width + "*" + pictureBox.Image.Height + ")";
		}

		void Open()
		{
			try
			{
				if (dlgOpenFile.ShowDialog() == DialogResult.OK)
				{
					pictureBox.ImageLocation = dlgOpenFile.FileName;
					origImage = pictureBox.Image;
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
      UpdateControls();
		}

		void UpdateControls()
		{
			btnCreate.Enabled = CanCreatePanno;
			Palette palette = SelectedPalette;
			btnEdit.Enabled = palette != null;
			btnRemove.Enabled = palette != null;
			buttonChange.Enabled = pictureBox.Image != null;
		}

		bool CanCreatePanno
		{
			get 
			{ 
				Config c=App.Config;
				Palette p=SelectedPalette;
				return c.pannoWidth >= c.tileWidth && c.pannoHeight >= c.tileHeight
					&& c.tileWidth > 0 && c.tileHeight > 0
					&& pictureBox.Image != null && lbPalettes.SelectedItems.Count>0 && p!=null && p.Count>1;
			}
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			try
			{
				Palette palette=SelectedPalette;
				MosaicForm form =
                    new MosaicForm(this, pictureBox.Image, palette, dlgOpenFile.FileName );
        form.Show();
				mosaicForms.Add(form);
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				Palette palette = new Palette();
				PaletteForm form = new PaletteForm(palette);
				if (form.ShowDialog() == DialogResult.OK)
				{
					App.Config.palettes.Add(palette);

//          palette.Save();

					UpdatePalettesListBox();
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			EditPalette();
		}

		private void EditPalette()
		{
			try
			{
				Palette palette = SelectedPalette;
				if (palette != null)
				{
					PaletteForm form = new PaletteForm(palette);
					if (form.ShowDialog() == DialogResult.OK)
					{
						UpdatePalettesListBox();
					}
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			try
			{
				Palette palette = SelectedPalette;
				if (palette != null)
				{
					if (MessageBox.Show("Удалить палитру: '" + palette.name+"'?",base.Text,MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
					{
            string dir = PathUtils.BaseDirectory;
            File.Delete( dir + @"\" + "Palettes" + @"\" + palette.name );

						App.Config.palettes.Remove(palette);
						UpdatePalettesListBox();
					}
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void lbPalettes_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateControls();
		}

        private void pictureBox_MouseDoubleClick( object sender, MouseEventArgs e )
        {
/*            if ( pictureBox.Image == null )
                return;

            if ( e.Button == MouseButtons.Left )
            {

                Bitmap newBitmap = (Bitmap)pictureBox.Image;
                newBitmap.SetResolution( newBitmap.VerticalResolution * 2, newBitmap.HorizontalResolution * 2 );

                pictureBox.Image = newBitmap;
                Invalidate( );
            }
            if ( e.Button == MouseButtons.Right )
            {
                Bitmap newBitmap = (Bitmap)pictureBox.Image;
                newBitmap.SetResolution( newBitmap.VerticalResolution /2, newBitmap.Height / 2 );

                pictureBox.Image = newBitmap;

                Invalidate( );

            }
*/
        }

		private void timer1_Tick(object sender, EventArgs e)
		{
			foreach (MosaicForm form in mosaicForms)
			{
				form.ucMap.OnTimer();
			}
		}

		#region IMainForm Members

		public void MosaicFormClosed(MosaicForm form)
		{
			mosaicForms.Remove(form);
		}

		#endregion

		private void chkSquare_CheckedChanged(object sender, EventArgs e)
		{
			if (chkSquare.Checked) nudTileHeight.Value = nudTileWidth.Value;
		}

		private void nudGap_ValueChanged(object sender, EventArgs e)
		{
			App.Config.gap = (int)(nudGap.Value*10);
		}

		private void btnGapColor_Click(object sender, EventArgs e)
		{
			try
			{
				dlgColor.Color = App.Config.gapColor;
				if (dlgColor.ShowDialog() == DialogResult.OK)
				{
					App.Config.gapColor = dlgColor.Color;
					lblGapColor.BackColor = App.Config.gapColor;
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void nudMX_ValueChanged(object sender, EventArgs e)
		{
			App.Config.mx = (int)nudMX.Value;
		}

		private void nudMY_ValueChanged(object sender, EventArgs e)
		{
			App.Config.my = (int)nudMY.Value;
		}

		private void lbPalettes_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			EditPalette();
		}

		private void btnGridColor_Click(object sender, EventArgs e)
		{
			try
			{
				dlgColor.Color = App.Config.gridColor;
				if (dlgColor.ShowDialog() == DialogResult.OK)
				{
					App.Config.gridColor = dlgColor.Color;
					lblGridColor.BackColor = App.Config.gridColor;
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void btnAbout_Click(object sender, EventArgs e)
		{
			AboutForm form = new AboutForm();
			form.Show();
		}

		private void buttonChange_Click( object sender, EventArgs e )
		{
			ChangeImageSize();
		}

		private void ChangeImageSize()
		{
			try
			{
				rect = new Rectangle(0, 0, App.Config.pannoWidth, App.Config.pannoHeight);
				Bitmap newbmp = (Bitmap)origImage.Clone();
				ChangeImageForm form = new ChangeImageForm(newbmp, rect);
				Bitmap bmp = form.Run();
				if (form.Changed)
				{
					pictureBox.Image = bmp;
					//				Invalidate( );
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void pictureBox_DoubleClick(object sender, EventArgs e)
		{
			ChangeImageSize();
		}

		private void pictureBox_MouseDoubleClick_1(object sender, MouseEventArgs e)
		{
			ChangeImageSize();
		}
	}
}
