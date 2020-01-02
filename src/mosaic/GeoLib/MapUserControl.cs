using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Geomethod.Windows.Forms;
using Geomethod;

namespace Mosaic.GeoLib
{
	/// <summary>
	/// Summary description for MapUserControl.
	/// </summary>
	public class MapUserControl : System.Windows.Forms.UserControl
	{
		public event EventHandler OnScaleChanged;
//		enum TrackingMode{HotTracking,Selecting}
		GLib lib;
//		IMosaicForm mosaicForm;
		Map map=null;
//		PointSearchVisitor ps=new PointSearchVisitor();
		public Map Map{get{return map;}}
		Graphics graphics=null;

		// tracking
		static readonly Point nullPoint=new Point(-1,-1);
		Point mouseDownPoint=nullPoint;

		// drawing
		bool repaintMap=false;
		Rectangle clipRect=Rectangle.Empty;
		Rectangle selectionRect=Rectangle.Empty;
		Rectangle prevSelectionRect=Rectangle.Empty;
		Pen selectionPen=new Pen(Color.DarkBlue);
		private System.Windows.Forms.ContextMenu cmMap;
		private System.Windows.Forms.MenuItem miSaveAs;
		private System.Windows.Forms.SaveFileDialog dlgSaveFile;
		private System.Windows.Forms.MenuItem miEndEditing;

		// state
		bool postponeStatusUpdate=false;
		private System.Windows.Forms.MenuItem miEditSelectedObject;
		private System.Windows.Forms.MenuItem miAddPointsMode;
		private MenuItem menuItem1;
		

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Rectangle SelectionRect{set{selectionRect=value;}}

		public MapUserControl()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call

		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cmMap = new System.Windows.Forms.ContextMenu();
			this.miSaveAs = new System.Windows.Forms.MenuItem();
			this.miEditSelectedObject = new System.Windows.Forms.MenuItem();
			this.miAddPointsMode = new System.Windows.Forms.MenuItem();
			this.miEndEditing = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// cmMap
			// 
			this.cmMap.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miSaveAs,
            this.miEditSelectedObject,
            this.miAddPointsMode,
            this.miEndEditing,
            this.menuItem1});
			this.cmMap.Popup += new System.EventHandler(this.cmMap_Popup);
			// 
			// miSaveAs
			// 
			this.miSaveAs.Index = 0;
			this.miSaveAs.Text = "_saveas";
			this.miSaveAs.Click += new System.EventHandler(this.miSaveAs_Click);
			// 
			// miEditSelectedObject
			// 
			this.miEditSelectedObject.Index = 1;
			this.miEditSelectedObject.Text = "_editselectedobject";
			this.miEditSelectedObject.Click += new System.EventHandler(this.miEditSelectedObject_Click);
			// 
			// miAddPointsMode
			// 
			this.miAddPointsMode.Checked = true;
			this.miAddPointsMode.Index = 2;
			this.miAddPointsMode.Text = "_addpointsmode";
			this.miAddPointsMode.Click += new System.EventHandler(this.miAddPointsMode_Click);
			// 
			// miEndEditing
			// 
			this.miEndEditing.Index = 3;
			this.miEndEditing.Text = "_endediting";
			this.miEndEditing.Click += new System.EventHandler(this.miEndEditing_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 4;
			this.menuItem1.Text = "Изменить цвет плитки";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// MapUserControl
			// 
			this.BackColor = System.Drawing.Color.White;
//			this.ContextMenu = this.cmMap;
			this.Name = "MapUserControl";
			this.Size = new System.Drawing.Size(376, 376);
			this.Load += new System.EventHandler(this.MapUserControl_Load);
			this.MouseLeave += new System.EventHandler(this.MapUserControl_MouseLeave);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.MapUserControl_Paint);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MapUserControl_MouseMove);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MapUserControl_MouseDown);
			this.Resize += new System.EventHandler(this.MapUserControl_Resize);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MapUserControl_MouseUp);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MapUserControl_KeyDown);
			this.ResumeLayout(false);

		}
		#endregion

		public void Init(GLib lib)
		{
			this.lib=lib;
		}

		private void MapUserControl_Load(object sender, System.EventArgs e)
		{
			if(!base.DesignMode)
			{
//				LocaleUtils.Localize(this);		
				selectionPen.DashStyle=DashStyle.Dash;
				map=new Map(lib,ClientRectangle.Size);
			}
		}

		public void Repaint()
		{
			repaintMap=true;
		}

		void UpdateMapRect(Point p)
		{
			Rectangle r=GetSelectionRect(p);
			selectionRect=Rectangle.Empty;
			if(mouseDownPoint==nullPoint || r.Width<10 || r.Height<10) return;
			Rect bounds=map.GToW(r);
			//						MapForm mapForm=new MapForm(app,bounds);
			//						mapForm.ShowDialog(app.MainForm);
			map.SetBounds(bounds);
			Repaint();
			if (OnScaleChanged!=null) OnScaleChanged(this, null);
//			app.DataChanged(map);
		}

		void UpdateSelection(Point p)
		{
			selectionRect=GetSelectionRect(p);
		}

		Rectangle GetSelectionRect(Point p)
		{
			if(mouseDownPoint==nullPoint) return Rectangle.Empty;
			Rectangle r=Rectangle.FromLTRB(mouseDownPoint.X,mouseDownPoint.Y,p.X,p.Y);
			GeomUtils.Normalize(ref r);
			return r;
		}

/*		void UpdateStatus(Point p)
		{
			Point wp=map.GToW(p);
			string s=string.Format("{0} ",wp);
			ps.Search(lib,wp,map.Scale,map);
			GObject obj=ps.LastObject;
			if(obj!=null)
			{
				s+=obj.Path;
			}
			mosaicForm.Status=s;
		}*/

		void SearchClick(Point p)
		{
/*			Point wp=map.GToW(p);
			ps.Search(lib,wp,map.Scale,map);
			switch(ps.Count)
			{
				case 0:
					if(!lib.Selection.IsEmpty)
					{
						Rect bounds=lib.Selection.Bounds;
						lib.Selection.Clear();
//!!!						app.CheckRepaint(bounds);
					}
//!!!					app.Status=Locale.Get("_objectsnotfound");
//!!!					app.ShowProperties(null);
					postponeStatusUpdate=true;
//					MessageBox.Show(Locale.Get("_objectsnotfound"));
					break;
				default:
					lib.Selection.Set(ps.LastObject);
//!!!					app.CheckRepaint(ps.LastObject);
//!!!					app.ShowProperties(ps.LastObject);
					break;
			}*/
		}

		private void Scene2dControl_MouseWheel(object sender, MouseEventArgs e)
		{
			int delta=e.Delta;
			if(delta==0) return;
			//!!!		Zoom(delta>0);
		}

		private void MapUserControl_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Point p=GetPoint(e);
			mouseDownPoint=p;
		}

		private void MapUserControl_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
//			if(app.EditObject!=null) return;
			Point p=GetPoint(e);
			bool samePoint=p==mouseDownPoint;
			switch(e.Button)
			{
				case MouseButtons.None:
					break;
				case MouseButtons.Left:
/*					if(app.DraggedType!=null)
					{
						app.StartEditing(app.DraggedType);
					}
					else*/
					{
						if(samePoint) SearchClick(p);
						else UpdateMapRect(p);
					}
					break;
				case MouseButtons.Right:
					if(samePoint)
					{
					}
					break;
			}
			mouseDownPoint=nullPoint;
		}

		private void MapUserControl_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Point p=GetPoint(e);
/*			if(app.EditObject!=null)
			{
				Point wp=map.GToW(p);
				app.EditObject.HighlightPoint(wp,this.map);
			}*/

			switch(e.Button)
			{
				case MouseButtons.None:
					if(postponeStatusUpdate) postponeStatusUpdate=false;
//					else UpdateStatus(p);
					break;
				case MouseButtons.Left:
	/*				GType type = app.DraggedType;// app.MainForm.TypesUserControl.DraggedType;
					if(type!=null)
					{
						Cursor=Cursors.Hand;
					}
					else*/ UpdateSelection(p);
					break;
			}
		}

		private void MapUserControl_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			if(map==null) return;
			clipRect=e.ClipRectangle;
			CheckDrawing();
		}

		private void MapUserControl_MouseLeave(object sender, System.EventArgs e)
		{
//!!!			app.Status="";
		}

		private void MapUserControl_Resize(object sender, System.EventArgs e)
		{
			mouseDownPoint=nullPoint;
			if(map==null) return;
//			repaintMap = true;
		}

		void CheckDrawing()
		{
//			lock (this)
			{
				if (this.Size != map.Image.Size)
				{
					map.Resize(ClientRectangle.Size);
//					repaintMap = true;
					if (graphics != null)
					{
//						graphics.Clear(this.BackColor);
						graphics.Dispose();
						graphics = null;
					}
				}

				if (graphics == null)
				{
					graphics = this.CreateGraphics();
					graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
					repaintMap = true;
					return;
					/*				graphics.CompositingQuality = CompositingQuality.AssumeLinear;
									graphics.SmoothingMode = SmoothingMode.None;
									graphics.CompositingMode = CompositingMode.SourceOver;*/
				}

				if (repaintMap)
				{
					map.Draw();
					graphics.DrawImageUnscaled(map.Image, 0, 0);
					repaintMap = false;
					clipRect = Rectangle.Empty;
					selectionRect = Rectangle.Empty;
					prevSelectionRect = Rectangle.Empty;
				}
				else if (!clipRect.IsEmpty && clipRect.Width > 0 && clipRect.Height > 0)
				{
					graphics.DrawImage(map.Image, clipRect.X, clipRect.Y, clipRect, GraphicsUnit.Pixel);
					clipRect = Rectangle.Empty;
				}

				if (selectionRect != prevSelectionRect)
				{
					if (!prevSelectionRect.IsEmpty)
					{
						Rectangle r = prevSelectionRect;
						r.Width += 1;
						r.Height += 1;
						graphics.DrawImage(map.Image, r.X, r.Y, r, GraphicsUnit.Pixel);
					}
					if (!selectionRect.IsEmpty)
					{
						graphics.DrawRectangle(selectionPen, selectionRect);
					}
					prevSelectionRect = selectionRect;
				}
			}
		}

		Point GetPoint(MouseEventArgs e)
		{
			return new Point(e.X,e.Y);
		}

		public void OnTimer()
		{
			CheckDrawing();
		}

		public void EnsureVisible(Rect rect)
		{
			map.EnsureVisible(rect);
			Repaint();
		}

		public void Close()
		{
			if(graphics!=null)
			{
				graphics.Dispose();
				graphics=null;
			}
		}

		public new void Move(Direction dir)
		{
			Map.Move(dir);
			Repaint();
		}

		public void ScaleUp()
		{
			Map.ScaleUp();
//!!!			app.UpdateScaleCombo();
			Repaint();
		}

		public void ScaleDown()
		{
			Map.ScaleDown();
//!!!			app.UpdateScaleCombo();
			Repaint();
		}

		public void RotateCW()
		{
			Map.RotateCW();
			Repaint();
		}

		public void RotateCCW()
		{
			Map.RotateCCW();
			Repaint();
		}

		private void MapUserControl_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{

			switch(e.KeyCode)
			{
				case Keys.Left:	Move(Direction.Left);	break;
				case Keys.Right: Move(Direction.Right);	break;
				case Keys.Up: Move(Direction.Top); break;
				case Keys.Down:	Move(Direction.Bottom);	break;
				case Keys.Home:	Move(Direction.LeftTop); break;
				case Keys.PageUp:	Move(Direction.RightTop);	break;
				case Keys.End: Move(Direction.LeftBottom); break;
				case Keys.PageDown:	Move(Direction.RightBottom); break;
				case Keys.Add: ScaleUp();	break;
				case Keys.Subtract:	ScaleDown(); break;
				case Keys.Escape:	EndEditing(); break;
			}
		}

		protected override bool IsInputKey(Keys key)		
		{ 
			switch(key)
			{ 
				case Keys.Up: 
				case Keys.Down: 
				case Keys.Right: 
				case Keys.Left: 
					return true; 
			} 
			switch((int)key)
			{
				case 65573:
				case 65574:
				case 65575:
				case 65576:
					return true;
			}
			return base.IsInputKey(key); 
		}

		private void miSaveAs_Click(object sender, System.EventArgs e)
		{
		  SaveAs();
		}

		void SaveAs()
		{
/*			try
			{
				dlgSaveFile.FileName="";
				dlgSaveFile.InitialDirectory=PathUtils.BaseDirectory+"Export";
				string[] ss={FileFilter.htm,FileFilter.ImagesCollection};
				dlgSaveFile.Filter=FileFilter.GetString(ss);
				if(dlgSaveFile.ShowDialog()==DialogResult.OK)
				{
					string filePath=dlgSaveFile.FileName;
					string ext=PathUtils.GetExtension(filePath);
					switch(ext)
					{
						case "bmp":
							map.Image.Save(filePath,ImageFormat.Bmp);
							break;
						case "gif":
							map.Image.Save(filePath,ImageFormat.Gif);
							break;
						case "jpg":
							map.Image.Save(filePath,ImageFormat.Jpeg);
							break;
						case "tif":
							map.Image.Save(filePath,ImageFormat.Tiff);
							break;
						case "png":
							map.Image.Save(filePath,ImageFormat.Png);
							break;
						case "htm":
							HtmlGenerator gen=new HtmlGenerator();
							gen.Generate(map,filePath);
							break;
					}
				}
			}
			catch(Exception ex)
			{
				Log.Exception(ex);
			}*/
		}

		private void miEndEditing_Click(object sender, System.EventArgs e)
		{
//			EndEditing();
		}		

		void EndEditing()
		{
//			app.EndEditing();
		}

		private void cmMap_Popup(object sender, System.EventArgs e)
		{
/*			bool editMode=app.EditObject!=null;
			this.miSaveAs.Visible=!editMode;
			miEditSelectedObject.Visible=!editMode && app.Lib.Selection.Object is GObject;
			this.miAddPointsMode.Visible=editMode;
			this.miAddPointsMode.Checked=editMode && app.EditObject.addPointsMode;
			miEndEditing.Visible=editMode;*/
		}

		private void miEditSelectedObject_Click(object sender, System.EventArgs e)
		{
			EditSelectedObject();
		}

		void EditSelectedObject()
		{
/*			try
			{
				if(lib.Selection.Object is GObject)
				{
					app.StartEditing((GObject)app.Lib.Selection.Object);
				}
			}
			catch(Exception ex)
			{
				Log.Exception(ex);
			}*/
		}

		private void miAddPointsMode_Click(object sender, System.EventArgs e)
		{
/*			if(app.EditObject!=null)
			{
				miAddPointsMode.Checked=!miAddPointsMode.Checked;
				app.EditObject.addPointsMode=miAddPointsMode.Checked;
			}*/
		}

		private void menuItem1_Click( object sender, EventArgs e )
		{
 
		}
	}
}
