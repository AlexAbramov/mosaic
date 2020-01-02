using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using Geomethod.Windows.Forms;

namespace Mosaic
{
	public partial class ChangeImageForm : Form
	{
		Bitmap bmp;
		Bitmap changedbmp;
		Rectangle	rect;
		RectangleF rectF;

		bool changed = false;
		public bool Changed { get { return changed; } }
		public Rectangle SelectedRect { get { return rect; } }
		bool drag = false;

		int moveStep = 2;

		int frame = /*100*/ 30;

		bool MPressed = false;
		bool SPressed = false;
		bool rotated = false;

		BufferedGraphicsContext currentContext;
		BufferedGraphics myBuffer;
		Graphics bp;

		float	ratio;

		Rectangle bmpRect;

		Point pointDrag;

		private void ChangeImage_Load(object sender, EventArgs e)
		{
            if (!DesignMode)
            {
                GmApplication.Initialize(this);
                sbText.Text = "";
                sbCoords.Text = "";
            }
		}

		public ChangeImageForm( Bitmap original, Rectangle rect )
		{
			InitializeComponent( );

			bmp = original;

			int	scale = (int)Math.Min( bmp.Width / 800f, bmp.Height / 600f );
			this.ClientSize = new Size( bmp.Width/scale + 2*frame,
					bmp.Height/scale + 2*frame + statusBar.Height );
			this.ClientSize -= new Size(300, 300);

//			this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			this.Text = "Изменение размера изображения";

			this.Paint += new PaintEventHandler( ChangeImage_Paint );
			this.KeyDown += new KeyEventHandler( ChangeImage_KeyDown );
			this.KeyUp += new KeyEventHandler( ChangeImage_KeyUp );
			this.MouseDown +=new MouseEventHandler( ChangeImage_MouseDown );
			this.MouseUp +=new MouseEventHandler( ChangeImage_MouseUp );
			this.MouseMove +=new MouseEventHandler( ChangeImage_MouseMove );
			this.MouseWheel +=new MouseEventHandler( ChangeImage_MouseWheel );

			float s = (float)Math.Min( (float)bmp.Width / rect.Width, 
				(float)bmp.Height / rect.Height );

			ratio = ( (float)rect.Width )/rect.Height;

			this.rect = new Rectangle( 0, 0, (int)( s * rect.Width ), (int)( s * rect.Height ) );
			this.rectF = new RectangleF( 0, 0, s * rect.Width, s * rect.Height ); 

			currentContext = BufferedGraphicsManager.Current;
			myBuffer = currentContext.Allocate( CreateGraphics( ), DisplayRectangle );
			bp = myBuffer.Graphics;

			bmpRect = new Rectangle( 0, 0, bmp.Width, bmp.Height );
		}

		void ChangeImage_MouseWheel( object sender, MouseEventArgs e )
		{
			if( SPressed && e.Delta != 0 )
				ScaleFrame( e.Delta/ /*120*/ 30 );

		}

		void ChangeImage_MouseMove( object sender, MouseEventArgs e )
		{
			if( MPressed && e.Button == MouseButtons.Left )
			{
				if( pointDrag != e.Location )
					MoveFrame( e.X - pointDrag.X, e.Y - pointDrag.Y );

				pointDrag = e.Location;
				return;
			}
		}

		void ChangeImage_MouseUp( object sender, MouseEventArgs e )
		{
			drag = false;
			pointDrag = Point.Empty;
		}

		void ChangeImage_MouseDown( object sender, MouseEventArgs e )
		{
			if( e.Button == MouseButtons.Left && rect.Contains( e.Location ) )
			{
				drag = true;
				pointDrag = e.Location;
			}
		}

		void ChangeImage_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
				if (MessageBox.Show("Выйти без сохранения изображения?", "",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					Close();
					changed = false;
					return;
				}

			if (e.KeyCode == Keys.Enter)
			{
				if (MessageBox.Show("Сохранить изменение размера изображения?", "",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					Save();
					Close();
					return;
				}
			}

			if (e.KeyCode == Keys.R)
			{
				RotateFrame();
				return;
			}

			if (MPressed && e.KeyCode == Keys.M)
				MPressed = false;

			if (!MPressed)
			{
				this.Cursor = Cursors.Default;
				sbText.Text = "";
			}

			if (SPressed && e.KeyCode == Keys.S)
				SPressed = false;

			if (!SPressed)
			{
				this.Cursor = Cursors.Default;
				sbText.Text = "";
			}
		}


		private void Save()
		{
			changedbmp = ImageCopy( bmp, rect );
			changed = true;
		} 
		
		void ChangeImage_KeyDown( object sender, KeyEventArgs e )
		{

			if ( !MPressed && e.KeyCode == Keys.M )
				MPressed = true;

			if ( MPressed )
			{
				this.Cursor = Cursors.SizeAll;
				sbText.Text = "Перемещение рамки";
			}

			if( MPressed && e.KeyCode == Keys.Down )
			{
				MoveFrame( 0, moveStep );
				return;
			}
			if( MPressed && e.KeyCode == Keys.Up )
			{
				MoveFrame( 0, -moveStep );
				return; 
			}

			if ( MPressed && e.KeyCode == Keys.Left )
			{
				MoveFrame( -moveStep, 0 );
				return; 
			}

			if ( MPressed && e.KeyCode == Keys.Right )
			{	
				MoveFrame( moveStep, 0 );
				return; 
			}
		
			if ( !SPressed && e.KeyCode == Keys.S )
				SPressed = true;

			if ( SPressed && e.KeyCode == Keys.Down )
			{
				ScaleFrame( -moveStep );
				return; 
			}

			if ( SPressed && e.KeyCode == Keys.Up )
			{
				ScaleFrame( moveStep );
				return; 
			}

			if ( SPressed )
			{
				this.Cursor = Cursors.SizeNESW;
				sbText.Text = "Изменение размеров рамки";
			}
		}

		private void RotateFrame()
		{
			Matrix m = new Matrix();
			m.RotateAt( (float)(Math.PI/2.0), 
					new PointF( rectF.Left + rectF.Width/2f,
								rectF.Top + rectF.Height/2f ) );

			PointF[] pnts = new PointF[] { new PointF( rectF.Left, rectF.Top ) } ;
			m.TransformPoints( pnts );
			RectangleF rf = new RectangleF( pnts[0].X, pnts[0].Y, rectF.Height, rectF.Width );
			Rectangle ri = new Rectangle( (int)( rf.Left + 0.5f ),
					(int)( rf.Top + 0.5f ),
					(int)( rf.Width + 0.5f ),
					(int)( rf.Height + 0.5f ) );

			if( bmpRect.Contains( ri ) )
			{
				rectF = rf;
				rect = ri;
				Draw();
				rotated = !rotated;
//				sbText.Text = rect.ToString() + "  " + ( (float)rectF.Width )/rectF.Height;
			}					
		}

		private void ScaleFrame( int delta )
		{
			RectangleF rf = new RectangleF( rectF.Left - delta*ratio,
						rectF.Top - delta,
						rectF.Width + 2*delta*ratio,
						rectF.Height + 2*delta );
			Rectangle ri = new Rectangle( (int)( rf.Left + 0.5f ),
						(int)( rf.Top + 0.5f ),
						(int)( rf.Width + 0.5f ),
						(int)( rf.Height + 0.5f ) );

			if( bmpRect.Contains( ri ) && rectF.Width > 0 && rectF.Height > 0 )
			{
				rectF = rf;
				rect = ri;
				Draw();
//				sbText.Text = rect.ToString() + "  " + ( (float)rectF.Width )/rectF.Height;
			}
		}
		
		private void MoveFrame( int dx, int dy )
		{
			Rectangle r = new Rectangle( rect.Left + dx, rect.Top + dy, rect.Width, rect.Height );
			if( bmpRect.Contains( r ) )
			{
				rect = r;
				rectF = new RectangleF( rectF.Left + dx, rectF.Top + dy, rectF.Width, rectF.Height );
				Draw();
//				sbText.Text = rect.ToString();
				return;
			}
		}

		void ChangeImage_Paint( object sender, PaintEventArgs e )
		{
			Draw();
		}

		private void Draw()
		{
			Draw( bp );
			myBuffer.Render();
		}

		private void Draw( Graphics g )
		{

			bp.Clear( Color.GhostWhite /*Color.FromArgb( 255, 255, 200 )*/ );

			float scale = (float)Math.Min(
				(float)( ClientSize.Width - 2 * frame ) / (float)bmp.Size.Width,
				(float)( ClientSize.Height - 2 * frame - statusBar.Height ) / (float)bmp.Size.Height );

			g.Transform = new Matrix( scale, 0, 0, scale, frame, frame );
			g.DrawImage( bmp, bmpRect, bmpRect, GraphicsUnit.Pixel );

			Rectangle rb = new Rectangle( bmpRect.Left - 2, bmpRect.Top - 2, bmpRect.Width + 3, bmpRect.Height + 3 );
			g.DrawRectangle( new Pen( Color.Indigo ), rb );

			g.SetClip( rect, CombineMode.Exclude );
			g.FillRectangle( new SolidBrush( Color.FromArgb( 100 /*70*/, Color.WhiteSmoke ) ),
				bmpRect );

			g.ResetClip( );
			g.DrawRectangle( new Pen( Color.Red ), rect );
			g.ResetTransform( );
		}

		private Bitmap ImageCopy( Bitmap original, Rectangle rect )
		{
			Bitmap bmp1 = new Bitmap( bmp );
			return	bmp1.Clone( rect, bmp1.PixelFormat );

/*			Bitmap bmp = new Bitmap( rect.Width, rect.Height, original.PixelFormat );
			for ( int i = 0; i < original.Width; i++ )
				for ( int j = 0; j < original.Height; j++ )
					if ( i >= rect.Left && i < rect.Right )
						if ( j >= rect.Top && j < rect.Bottom )
							bmp.SetPixel( i - rect.Left, j - rect.Top,
								original.GetPixel( i, j ) );

			return bmp;
 */ 
		}

		public Bitmap Run( )
		{
			base.ShowDialog( );
			if( changed )
				return changedbmp;
			else
				return bmp;	
		}

		private void btnScaleDown_Click(object sender, EventArgs e)
		{
			ScaleFrame(-moveStep);
		}

		private void btnScaleUp_Click(object sender, EventArgs e)
		{
			ScaleFrame(moveStep);
		}

		private void btnLeft_Click(object sender, EventArgs e)
		{
			MoveFrame(-moveStep, 0);
		}

		private void btnTop_Click(object sender, EventArgs e)
		{
			MoveFrame(0, -moveStep);
		}

		private void btnBottom_Click(object sender, EventArgs e)
		{
			MoveFrame(0, moveStep);
		}

		private void btnRight_Click(object sender, EventArgs e)
		{
			MoveFrame(moveStep, 0);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Save();
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}