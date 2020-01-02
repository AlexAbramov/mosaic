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
    public enum ChangeTileForm
    {
        ChangeTile,
        ShowAllTile
    }

	public partial class TileForm: Form
	{

        public MosaicForm mosaicForm;
        public ChangeTileForm type;
        public NamedColor ncolor;

        public TileForm( Point p, ChangeTileForm type, NamedColor ncolor, MosaicForm mosaicForm )
		{
			InitializeComponent();

            this.mosaicForm = mosaicForm;
            this.type = type;
            this.ncolor = ncolor;

/*            if ( type == ChangeTileForm.ChangeTile )
            {
                this.Text = "Заменить цвет";
                this.buttonChange.Text = "Заменить";
            }
            else
            {
                this.Text = "Используемые цвета";
                this.buttonChange.Text = "Выделить";
            }
*/
            if ( mosaicForm.colorSelected )
                btnChange.FlatStyle = FlatStyle.Flat;


            foreach ( NamedColor nc in mosaicForm.palette.colors )
                AddColor( nc, type, ncolor, mosaicForm.indexTable, mosaicForm.w, mosaicForm.h );
		}

		private void AddColor( NamedColor nc, ChangeTileForm type, NamedColor ncolor, NamedColor[ , ] indexTable, int w, int h )
		{
      int cnt = 0;
      for ( int i = 0; i < w; i++ )
          for ( int j = 0; j < h; j++ )
              if ( indexTable[ i, j ].color == nc.color )
                  cnt++;

			string[] ss ={ "", nc.name, cnt.ToString() };
			ListViewItem lvi = new ListViewItem( ss );
			lvi.UseItemStyleForSubItems = false;
			lvi.BackColor = nc.color;
			lvi.Tag = nc;

            if( type == ChangeTileForm.ChangeTile ) 
                if( nc.color == ncolor.color )
                    lvi.Selected = true;

			listView.Items.Add( lvi );

		}
		private void buttonChange_Click( object sender, EventArgs e )
		{

            if ( type == ChangeTileForm.ShowAllTile )
            {
                if ( !mosaicForm.colorSelected )
                {
                    ShowTiles( );
                    btnChange.FlatStyle = FlatStyle.Flat;
                }
                else
                {
                    mosaicForm.DeselectAllTiles( );
                    btnChange.FlatStyle = FlatStyle.Standard;
                }
            }

            if ( type == ChangeTileForm.ChangeTile )
                ChangeTile( );

            listView.Focus( );
            return;
        }

        private void ChangeTile( )
        {
            if ( !mosaicForm.colorChanged )
            {
                if ( listView.SelectedItems.Count > 0 )
                {
                    ListViewItem lvi = listView.SelectedItems[ 0 ];
                    NamedColor nc = ( lvi.Tag as NamedColor );

                    mosaicForm.bitmap_selected = new Bitmap( mosaicForm.bitmap );

                    for ( int i = 0; i < mosaicForm.w; i++ )
                        for ( int j = 0; j < mosaicForm.h; j++ )
                            if ( mosaicForm.bitmap.GetPixel( i, j ) == ncolor.color )
                                mosaicForm.bitmap.SetPixel( i, j, nc.color );

                    mosaicForm.colorChanged = true; ;
                    mosaicForm.ucMap.Repaint( );
                    btnChange.FlatStyle = FlatStyle.Flat;
                    listView.Focus( );
                }
            }
            else
            {
                if ( mosaicForm.bitmap_selected != null )
                    for ( int i = 0; i < mosaicForm.w; i++ )
                        for ( int j = 0; j < mosaicForm.h; j++ )
                            mosaicForm.bitmap.SetPixel( i, j,
                                mosaicForm.bitmap_selected.GetPixel( i, j ) );

                mosaicForm.colorChanged = false;
                btnChange.FlatStyle = FlatStyle.Standard;
                mosaicForm.ucMap.Repaint( );
            }
        }

        private void ShowTiles( )
        {
            if ( listView.SelectedItems.Count > 0 )
            {
                ListViewItem lvi = listView.SelectedItems[ 0 ];
                NamedColor nc = ( lvi.Tag as NamedColor );
                mosaicForm.SelectAllTiles( nc );
            }
            listView.Focus( );
        }

		private void buttonNo_Click( object sender, EventArgs e )
		{
			Close();
		}

		private void ChangeTile_Shown( object sender, EventArgs e )
		{
            listView.Focus( );
		}

        private void ChangeTile_KeyDown( object sender, KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Escape )
                Close( );

            listView.Focus( );
        }

        private void ChangeTile_KeyUp( object sender, KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Escape )
                Close( );

            listView.Focus( );
        }

        private void listView_KeyDown( object sender, KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Escape )
                Close( );
        }

        private void listView_MouseDoubleClick( object sender, MouseEventArgs e )
        {

            if ( type == ChangeTileForm.ShowAllTile )
            {
                if ( !mosaicForm.colorSelected )
                {
                    ShowTiles( );
                    btnChange.FlatStyle = FlatStyle.Flat;
                }
                else
                {
                    mosaicForm.DeselectAllTiles( );
                    btnChange.FlatStyle = FlatStyle.Standard;
                }
            }

            if ( type == ChangeTileForm.ChangeTile )
                ChangeTile( );

            listView.Focus( );
            return;
        }

		private void TileForm_Load(object sender, EventArgs e)
		{
            if (!DesignMode)
            {
                GmApplication.Initialize(this);
            }
		}
	}
}