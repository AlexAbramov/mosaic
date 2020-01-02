using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Geomethod;
using Geomethod.Windows.Forms;

namespace Mosaic
{
	enum SortMode { Custom, Name, Brightness}
	public partial class PaletteForm : Form
	{
		Palette palette = null;
		Bitmap bitmap = null;
		NamedColor editedColor = null;
		public PaletteForm(Palette palette)
		{
			InitializeComponent();
			this.palette = palette;

            textBoxRed.ForeColor = Color.Red;
            textBoxBlue.ForeColor = Color.Blue;
            textBoxGreen.ForeColor = Color.Green;



        }

		ListViewItem SelectedItem { get { return listView.SelectedItems.Count > 0 ? listView.SelectedItems[0] : null; } }
		NamedColor SelectedNamedColor { get { ListViewItem lvi=SelectedItem; return lvi!=null ? lvi.Tag as NamedColor : null; } }

		private void btnLoadImage_Click(object sender, EventArgs e)
		{
			try
			{
				if (dlgOpenFile.ShowDialog() == DialogResult.OK)
				{
					LoadImage(dlgOpenFile.FileName);
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void LoadImage(string filePath)
		{
			try
			{
				bitmap = new Bitmap(filePath);
				pictureBox.Image = bitmap;
				palette.imageFilePath = filePath;
				lblImagePath.Text = filePath;
				if (tbPaletteName.Text.Trim().Length == 0)
				{
					tbPaletteName.Text = Path.GetFileNameWithoutExtension(filePath);
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void pictureBox_Click(object sender, EventArgs e)
		{
		}

		private void pictureBox_MouseClick(object sender, MouseEventArgs e)
		{
			if(bitmap!=null)
			{
				int x=e.X;
				int y=e.Y;
				if (x >= 0 && y >= 0 && x < bitmap.Width && y < bitmap.Height)
				{
					Color c = bitmap.GetPixel(x, y);
					lblColor.BackColor = c;
					UpdateControls();
				}
			}
		}

		private void PaletteForm_Load(object sender, EventArgs e)
		{
            if (!DesignMode)
            {
                try
                {
                    GmApplication.Initialize(this);
                    MinimumSize = Size;
                    lblImagePath.Text = "";
                    lblColor.BackColor = Color.Empty;
                    tbPaletteName.Text = palette.name;
                    foreach (NamedColor nc in palette.colors) AddColor(nc);
                    if (File.Exists(palette.imageFilePath))
                    {
                        LoadImage(palette.imageFilePath);
                    }
                    UpdateControls();
                    SetSorting(SortMode.Custom);
                }
                catch (Exception ex)
                {
                    Log.Exception(ex);
                }
            }
		}

		bool CanAdd
		{
			get 
			{
				return lblColor.BackColor != Color.Empty && tbColorName.Text.Trim().Length > 0 && IsUniqueColorName(tbColorName.Text.Trim());
			}
		}

		bool CanSave
		{
			get
			{
				return tbPaletteName.Text.Trim().Length > 0 && IsUniquePaletteName(tbPaletteName.Text.Trim());
			}
		}

		private bool IsUniquePaletteName(string paletteName)
		{
			foreach(Palette p in App.Config.palettes)
			{
				if (p!=palette && string.Compare(p.name, paletteName, true) == 0) return false;
			}
			return true;
		}

		private bool IsUniqueColorName(string colorName)
		{
			foreach (NamedColor nc in palette.colors)
			{
				if (string.Compare(nc.name, colorName, true) == 0) return false;
			}
			return true;
		}

		void UpdateControls()
		{
			btnAdd.Enabled = CanAdd;
			btnOk.Enabled = CanSave;
			btnRemove.Enabled = listView.SelectedItems.Count>0;

			btnAdd.Text = editedColor == null ? "Add" : "Update";
			Color c = lblColor.BackColor;
			textBoxRed.Text = c.R.ToString();
			textBoxGreen.Text = c.G.ToString();
			textBoxBlue.Text = c.B.ToString();
			string colorName=tbColorName.Text.Trim();				
			if (editedColor != null)
			{
				btnAdd.Enabled = colorName.Length>0 && (lblColor.BackColor != editedColor.color || colorName != editedColor.name);
			}
			else 
			{
				bool enabled = colorName.Length>0;
				if (enabled)
				{
					foreach (NamedColor nc in palette.colors)
					{
						if (nc.color == lblColor.BackColor || nc.name == colorName)
						{
							enabled = false;
							break;
						}
					}
				}
				btnAdd.Enabled = enabled;
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (editedColor!=null)
			{
				editedColor.name = tbColorName.Text.Trim();
				editedColor.color = lblColor.BackColor;

				foreach (ListViewItem lvi in listView.Items)
				{
					if (lvi.Tag == editedColor)
					{
						lvi.SubItems[1].Text = editedColor.name;
						lvi.BackColor = editedColor.color;
						break;
					}
				}
			}
			else
			{
				NamedColor nc = new NamedColor( tbColorName.Text.Trim(),
									 lblColor.BackColor, true );
				palette.colors.Add(nc);
				AddColor(nc);
			}
			listView.Sort();
			UpdateControls();
		}

		private void AddColor(NamedColor nc)
		{
			string[] ss ={"", nc.name};
			ListViewItem lvi = new ListViewItem(ss);
			lvi.Checked = nc.active;
			lvi.UseItemStyleForSubItems = false;
			lvi.BackColor=nc.color;
			lvi.Tag = nc;
			listView.Items.Add(lvi);
		}

		private void tbColorName_TextChanged(object sender, EventArgs e)
		{
			UpdateControls();
		}

		private void tbPaletteName_TextChanged(object sender, EventArgs e)
		{
			UpdateControls();
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem lvi in listView.SelectedItems)
			{ 
				palette.colors.Remove(lvi.Tag as NamedColor);
				listView.Items.Remove(lvi);
			}
			UpdateControls();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			palette.name = tbPaletteName.Text;
//			App.Config.SetChanged();
		}

		private void btnUp_Click(object sender, EventArgs e)
		{
			NamedColor nc = SelectedNamedColor;
			if (nc != null)
			{
				int index=palette.colors.IndexOf(nc);
				if (index > 0)
				{
					NamedColor nc0=palette.colors[index - 1];
					palette.colors[index - 1] = nc;
					palette.colors[index] = nc0;
					SetSorting(SortMode.Custom);
				}
			}
		}
		private void btnDown_Click(object sender, EventArgs e)
		{
			NamedColor nc = SelectedNamedColor;
			if (nc != null)
			{
				int index = palette.colors.IndexOf(nc);
				if (index < palette.colors.Count-1)
				{
					NamedColor nc0 = palette.colors[index + 1];
					palette.colors[index + 1] = nc;
					palette.colors[index] = nc0;
					SetSorting(SortMode.Custom);
				}
			}
		}
		private void SetSorting(SortMode sortMode)
		{
			cbSort.SelectedIndex = (int)sortMode;
			this.listView.ListViewItemSorter = new ListViewItemComparer(sortMode,palette);
		}

		private void listView_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			// Set the ListViewItemSorter property to a new ListViewItemComparer 
			// object. Setting this property immediately sorts the 
			// ListView using the ListViewItemComparer object.
			switch (e.Column)
			{
				case 0: 
					SetSorting(SortMode.Brightness); 
					break;
				case 1: SetSorting(SortMode.Name); break;
			}
		}

		private void listView_SelectedIndexChanged(object sender, EventArgs e)
		{
			editedColor = SelectedNamedColor;
			if (editedColor != null)
			{
				lblColor.BackColor = editedColor.color;
				tbColorName.Text = editedColor.name;
			}
			UpdateControls();
		}


		private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
		{
			SortMode sortMode = (SortMode)cbSort.SelectedIndex;
			SetSorting(sortMode);
			bool customMode = sortMode == SortMode.Custom;
			btnUp.Enabled = customMode;
			btnDown.Enabled = customMode;
		}


    private void VisibleCheckBox_CheckedChanged( object sender, EventArgs e )
    {
        btnAdd.Enabled = true;
    }

    private void BackCheckBox_CheckedChanged( object sender, EventArgs e )
    {
        btnAdd.Enabled = true;
    }

		private void listView_ItemChecked(object sender, ItemCheckedEventArgs e)
		{
			NamedColor nc = (NamedColor)e.Item.Tag;
			nc.active = e.Item.Checked;
		}

		private void btnColor_Click(object sender, EventArgs e)
		{
			try
			{
				if (dlgColor.ShowDialog() == DialogResult.OK)
				{
					lblColor.BackColor = dlgColor.Color;
					UpdateControls();
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			listView.SelectedItems.Clear();
//			tbColorName.Text = "";
			editedColor = null;
			UpdateControls();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void btnCancel_Click(object sender, EventArgs e)
		{

		}


	}

	// Implements the manual sorting of items by columns.
	class ListViewItemComparer : System.Collections.IComparer
	{
		SortMode sortMode;
		Palette palette;
		public ListViewItemComparer(SortMode sortMode, Palette palette)
		{
			this.sortMode = sortMode;
			this.palette = palette;
		}
		public int Compare(object x, object y)
		{
			ListViewItem lvi1 = (ListViewItem)x;
			ListViewItem lvi2 = (ListViewItem)y;
			NamedColor nc1 = (NamedColor)lvi1.Tag;
			NamedColor nc2 = (NamedColor)lvi2.Tag;
			switch (sortMode)
			{
				case SortMode.Custom:
					int i1 = palette.colors.IndexOf(nc1);
					int i2 = palette.colors.IndexOf(nc2);
					return Math.Sign(i1 - i2);
				case SortMode.Brightness:
					return Math.Sign(nc2.color.GetBrightness()-nc1.color.GetBrightness());
				case SortMode.Name:
					return String.Compare(nc1.name, nc2.name);
			}
			return 0;
		}
	}
}