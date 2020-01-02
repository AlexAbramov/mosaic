using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Geomethod;
using Geomethod.Windows.Forms;

using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;
using System.IO;

using Mosaic.GeoLib;

namespace Mosaic
{
	public partial class MosaicForm : Form
	{
		bool penMode = false;
		//		bool printTileColorMode = false;
		bool printTileColorMode = App.Config.printTileColorMode;
		
		Point downPoint = Point.Empty;

		IMainForm mainForm;
		Image image;
		public Bitmap bitmap;
		public Bitmap bitmap_selected;
		public Palette palette;

		public int w;
		public int h;

		private StatusBar statusBar;
		private StatusBarPanel sbText;
		private StatusBarPanel sbCoord;

		string filePath;
		string mosaicFileName;

		public NamedColor[,] indexTable;

		string[] cIndeces;

		Config c;

		public bool colorSelected = false;
		public bool colorChanged = false;

		public MosaicForm(IMainForm mainForm, Image image, Palette palette, string path)
		{
			InitializeComponent();

			FixLayout(this.toolStripContainer1.TopToolStripPanel);

			this.mainForm = mainForm;
			this.image = image;
			this.palette = palette;
			c = App.Config;
			w = c.pannoWidth / (c.tileWidth + c.gap);
			h = c.pannoHeight / (c.tileHeight + c.gap);

			bitmap = new Bitmap(image, w, h);
			indexTable = new NamedColor[w, h];

			AddStatusBar();
			PrintingInit();

			this.filePath = path;
			mosaicFileName = CreateMosaicaName(path);

			cIndeces = new string[]
              {   "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", 
                  "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

			#region GLIB
			GLib lib = new GLib();
			lib.Bounds = new Rect(0, 0, c.pannoWidth, c.pannoHeight);

			lib.BgImage.Image = bitmap;//image
			//      lib.BgImage.ScaleX = c.GapPeriodX;
			//      lib.BgImage.ScaleY = c.GapPeriodY;
			lib.BgImage.X = 0;//  c.pannoWidth / 2;
			lib.BgImage.Y = 0; // c.pannoHeight / 2;
			lib.BgImage.dx = c.GapPeriodX;//  c.pannoWidth / 2;
			lib.BgImage.dy = c.GapPeriodY; // c.pannoHeight / 2;

			lib.Grid.dx = c.GridPeriodX;
			lib.Grid.dy = c.GridPeriodY;
			//			lib.Grid.gap = c.gap;
			lib.Grid.color = c.gridColor;

			lib.Gap.dx = c.GapPeriodX;
			lib.Gap.dy = c.GapPeriodY;
			lib.Gap.gap = c.gap;
			lib.Gap.color = c.gapColor;

			foreach (int s in lib.Scales.Values)
			{
				this.cbScale.Items.Add(s);
			}

			ucMap.Init(lib);

			listView.CheckBoxes = false;
			#endregion

			SetTitle();

		}

		private void FixLayout(ToolStripPanel toolStripPanel)
		{
			toolStripPanel.SuspendLayout();
			//			List<ToolStrip> l = new List<ToolStrip>();
			foreach (Control c in toolStripPanel.Controls)
			{
				ToolStrip ts = c as ToolStrip;
				if (ts != null)
				{
					ts.Location = new Point(0, 0);
				}
			}
			toolStripPanel.ResumeLayout();
		}

		private void SetTitle()
		{
			//            if( ucMap.Map != null )
			//                this.Text = CreateWindowName( MosaicaFileName ) + " (" + /*scale* 100*/ucMap.Map.Scale + '%' + ")";
			this.Text = CreateWindowName(mosaicFileName)
					+ "(" + image.Width + ", " + image.Height + ")";
		}

		private void MosaicForm_Load(object sender, EventArgs e)
		{
            if (!DesignMode)
            {
                try
                {
                    GmApplication.Initialize(this);
                    CreateMosaic();
                    foreach (NamedColor nc in palette.colors) AddColor(nc);
                    UpdateListViewCount();
                    SetSorting(SortMode.Custom);
                    UpdateScaleCombo();
                    UpdateControls();
                }
                catch (Exception ex)
                {
                    Log.Exception(ex);
                }
            }
		}

		private void CreateMosaic()
		{
			foreach (NamedColor nc in palette.colors) nc.count = 0;

			for (int i = 0; i < bitmap.Width; i++)
				for (int j = 0; j < bitmap.Height; j++)
				{
					Color c = bitmap.GetPixel(i, j);
					NamedColor nc = palette.GetNearestColor(c);
					nc.count++;
					SetColor(i, j, nc);
				}
		}

		private void SetColor(int i, int j, NamedColor nc)
		{
			bitmap.SetPixel(i, j, nc.color);
			indexTable[i, j] = nc;
		}

		private void AddColor(NamedColor nc)
		{
			string[] ss ={ "", nc.name, "0" };
			ListViewItem lvi = new ListViewItem(ss);
			lvi.Checked = nc.active;
			lvi.UseItemStyleForSubItems = false;
			lvi.BackColor = nc.color;
			lvi.Tag = nc;
			listView.Items.Add(lvi);
		}

		void UpdateListViewCount()
		{
			foreach (ListViewItem lvi in listView.Items)
			{
				lvi.SubItems[2].Text = (lvi.Tag as NamedColor).count.ToString();
			}
		}

		private void SaveMosaicButton_Click(object sender, EventArgs e)
		{
		}

		private void SaveMosaic(string FileName)
		{
			if (bitmap != null)
			{
				string ext = Path.GetExtension(FileName);

				switch (ext)
				{
					case ".bmp":
						bitmap.Save(FileName, ImageFormat.Bmp);
						break;
					case ".gif":
						bitmap.Save(FileName, ImageFormat.Gif);
						break;
					case ".jpg":
						bitmap.Save(FileName, ImageFormat.Jpeg);
						break;
					case ".tiff":
						bitmap.Save(FileName, ImageFormat.Tiff);
						break;
					case ".png":
						bitmap.Save(FileName, ImageFormat.Png);
						break;
				}
			}
		}


		private string CreateMosaicaName(string FilePath)
		{
			return Path.GetFileNameWithoutExtension(FilePath) + " (Мозаика)";
		}

		private string CreateWindowName(string Path)
		{
			return Path + "  (" + w * /*size*/ 20 + " мм," +
					h * /*size*/ 20 + " мм)";
		}

		private int CountColor(NamedColor color)
		{
			int cnt = 0;
			for (int i = 0; i < w; i++)
				for (int j = 0; j < h; j++)
					if (indexTable[i, j] == color)
						cnt++;

			return cnt;
		}

		private void SaveMosaicReport(string FileName)
		{
			string ext = Path.GetExtension(FileName);
			try
			{
				using (StreamWriter sw = new StreamWriter(FileName))
				{
					foreach (NamedColor color in palette.colors)
						if (ext == ".csv")
							sw.WriteLine(color.name.ToString() + ";" + CountColor(color));
						else
							sw.WriteLine(color.name.ToString() + "\t" + CountColor(color));
				}
			}
			catch (Exception e)
			{
				Log.Exception(e);
			}
		}

		private string GetIndex(int x)
		{
			if (x < cIndeces.Length)
				return cIndeces[x];

			return "***";               //      Кончились буквы
		}

		public void AddStatusBar()
		{
			statusBar = new StatusBar();

			sbText = new StatusBarPanel();
			sbCoord = new StatusBarPanel();

			sbCoord.MinWidth = 300;
			sbCoord.BorderStyle = StatusBarPanelBorderStyle.Sunken;

			sbText.AutoSize = StatusBarPanelAutoSize.Spring;
			sbText.BorderStyle = StatusBarPanelBorderStyle.Sunken;

			statusBar.ShowPanels = true;
			statusBar.Panels.Add(sbCoord);
			statusBar.Panels.Add(sbText);

			this.Controls.Add(statusBar);
		}

		private void tsbScaleUp_Click(object sender, EventArgs e)
		{
			ScaleUp();
		}

		private void ScaleUp()
		{
			ucMap.ScaleUp();
			UpdateScaleCombo();
		}

		private void tsbScaleDown_Click(object sender, EventArgs e)
		{
			ScaleDown();
		}

		private void ScaleDown()
		{
			ucMap.ScaleDown();
			UpdateScaleCombo();
		}

		private void UpdateScaleCombo()
		{
			int sc = ucMap.Map.Scale;
			cbScale.Text = sc.ToString();
		}

		private void cbScale_Click(object sender, EventArgs e)
		{
		}

		private void ucMap_Load(object sender, EventArgs e)
		{

		}

		private void MosaicForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			mainForm.MosaicFormClosed(this);
		}

		private void ucMap_MouseMove(object sender, MouseEventArgs e)
		{
			ShowTileColor(e.Location);
		}

		private void ShowTileColor(Point p)
		{

			Point lpoint;
			NamedColor col = GetTile(p, out lpoint);


			if (col == null)
				sbCoord.Text = "";
			else
			{
				string page = "";
				Point wp = ucMap.Map.GToW(p);
				int i = wp.X / (c.GapPeriodX * c.mx);
				int j = wp.Y / (c.GapPeriodY * c.my);
				if (i >= 0 && i < w && j >= 0 && j < h && j < cIndeces.Length)
					page = " ( " + cIndeces[j] + ", " + (i + 1) + " )";

				sbCoord.Text =
					"Позиция: " + lpoint.X + "," + lpoint.Y +
					"    Матрица: " + page +
					"    Цвет: " + col.name.ToString();
			}

		}

		private NamedColor GetTile(Point p, out Point lpoint)
		{
			lpoint = Point.Empty;
			Point wp = ucMap.Map.GToW(p);

			int i = wp.X / c.GapPeriodX;
			int j = wp.Y / c.GapPeriodY;
			if (i >= 0 && i < w && j >= 0 && j < h)
			{
				lpoint = new Point(i, j);
				return indexTable[i, j];
			}
			return null;
		}

		private void ucMap_MouseLeave(object sender, EventArgs e)
		{
			sbCoord.Text = "";
		}

		private void ucMap_MouseClick(object sender, MouseEventArgs e)
		{
			if (penMode && e.Button == MouseButtons.Left && downPoint == e.Location && e.Clicks==1)
			{
				ChangeColor(e.Location);
				ucMap.Repaint();
			}
			ShowTileColor(e.Location);
		}

		private void btnLeft_Click(object sender, EventArgs e)
		{
			MoveLeft();
		}

		private void MoveLeft()
		{
			ucMap.Move(Direction.Left);
		}

		private void btnTop_Click(object sender, EventArgs e)
		{
			MoveTop();
		}

		private void MoveTop()
		{
			ucMap.Move(Direction.Top);
		}

		private void btnBottom_Click(object sender, EventArgs e)
		{
			MoveBottom();
		}

		private void MoveBottom()
		{
			ucMap.Move(Direction.Bottom);
		}

		private void btnRight_Click(object sender, EventArgs e)
		{
			MoveRight();
		}

		private void MoveRight()
		{
			ucMap.Move(Direction.Right);
		}


		private void btnPrint_Click(object sender, EventArgs e)
		{
			PrintMatrixes();
		}

		private void PrintMatrixes()
		{
			try
			{
				//      печать постраничной мозаики
				gi = 0;
				gj = 0;

				if (PrintMosaicDialog.ShowDialog() == DialogResult.OK)
					document.Print();
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			SavePannoPicture();
		}

		private void SavePannoPicture()
		{
			//      сохранение картинки с мозаикой
			try
			{
				SaveMosaicFileDialog.InitialDirectory = PathUtils.BaseDirectory;
				SaveMosaicFileDialog.Filter =
								"Графические файлы (*.bmp; *.jpg; *.png; *.tiff; *.gif)|*.bmp; *.jpg; ; *.png; *.tiff; *.gif |Все файлы|*.*";

				SaveMosaicFileDialog.FileName = mosaicFileName;

				if (SaveMosaicFileDialog.ShowDialog() == DialogResult.OK)
					SaveMosaic(SaveMosaicFileDialog.FileName);
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void btnPrintPreview_Click(object sender, EventArgs e)
		{
			PrintMatrixesPreview();
		}

		private void btnReportPreview_Click(object sender, EventArgs e)
		{
			//            Здесь просмотр отчета по используемым мозаикам
			PrintReportPreview();

		}

		private void ucMap_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (colorSelected)
			{
				DeselectAllTiles();
			}
			else
			{
				Point p = e.Location;
				Point lpoint;
				NamedColor col = GetTile(p, out lpoint);
				if (col != null)
				{
					SelectAllTiles(col);
				}
			}
		}

		public void SelectAllTiles(NamedColor col)
		{
			if (colorSelected)
				return;

			if (col != null)
			{
				bitmap_selected = new Bitmap(bitmap);

				Color color = Color.Gray;
				for (int i = 0; i < w; i++)
					for (int j = 0; j < h; j++)
						if (bitmap.GetPixel(i, j) != col.color)
							bitmap.SetPixel(i, j, color);

				colorSelected = true;
				ucMap.Repaint();
			}

		}

		private void ucMap_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && colorSelected)
			{
				DeselectAllTiles();
			}
		}

		public void DeselectAllTiles()
		{
			if (!colorSelected)
				return;

			if (bitmap_selected != null)
				for (int i = 0; i < w; i++)
					for (int j = 0; j < h; j++)
						bitmap.SetPixel(i, j, bitmap_selected.GetPixel(i, j));

			colorSelected = false;

			sbText.Text = "";
			ucMap.Repaint();
		}

		private void ChangeColor(Point p)
		{
			Point lpoint;
			NamedColor col = GetTile(p, out lpoint);
			if (col != null)
			{
				NamedColor col2 = SelectedColor;
				if (col2 != null)
				{
					SetColor(lpoint.X, lpoint.Y, col2);
				}
			}
		}

		private void ucMap_KeyUp(object sender, KeyEventArgs e)
		{
		}

		private void toolStripButtonC_Click(object sender, EventArgs e)
		{
			//	  splitContainer1.Panel1.Hide( );

		}

		private void ShowPalette()
		{
			try
			{
				NamedColor nc = SelectedColor;
				if (nc != null)
				{
					new TileForm(Point.Empty, ChangeTileForm.ChangeTile, nc, this).ShowDialog();
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
		{
			SortMode sortMode = (SortMode)cbSort.SelectedIndex;
			SetSorting(sortMode);
			bool customMode = sortMode == SortMode.Custom;
		}

		private void SetSorting(SortMode sortMode)
		{
			cbSort.SelectedIndex = (int)sortMode;
			this.listView.ListViewItemSorter = new ListViewItemComparer(sortMode, palette);
		}

		private void listView_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			switch (e.Column)
			{
				case 0:
					SetSorting(SortMode.Brightness);
					break;
				case 1: SetSorting(SortMode.Name); break;
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			CreateMosaic();
			UpdateListViewCount();
			ucMap.Repaint();
		}

		private void listView_ItemChecked(object sender, ItemCheckedEventArgs e)
		{
			NamedColor nc = (NamedColor)e.Item.Tag;
			nc.active = e.Item.Checked;
		}

		NamedColor SelectedColor
		{
			get 
			{
				if (listView.SelectedItems.Count > 0)
				{
					ListViewItem lvi = listView.SelectedItems[0];
					NamedColor nc = (lvi.Tag as NamedColor);
					return nc;
				}
				return null;
			}
		}

		private void SelectAllTiles()
		{
			NamedColor nc = SelectedColor;
			if (nc!=null)
			{
				SelectAllTiles(nc);
			}
			listView.Focus();
		}

		private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			ToggleSelection();
			listView.Focus();
		}

		private void ToggleSelection()
		{
			if (colorSelected)
			{
				DeselectAllTiles();
			}
			else
			{
				SelectAllTiles();
			}
		}

/*		private void buttonChange_Click(object sender, EventArgs e)
		{
			//			if ( type == ChangeTileForm.ShowAllTile )
			{
				if (!colorSelected)
				{
					SelectAllTiles();
					//					buttonChange.FlatStyle = FlatStyle.Flat;
				}
				else
				{
					DeselectAllTiles();
					//					buttonChange.FlatStyle = FlatStyle.Standard;
				}
			}

			//			if ( type == ChangeTileForm.ChangeTile )
			//				ChangeTile( );

			listView.Focus();
		}*/

		private void cbScale_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				object obj = cbScale.SelectedItem;
				if (obj != null)
				{
					int s = (int)obj;
					ucMap.Map.Scale = s;
					ucMap.Repaint();
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void ucMap_OnScaleChanged(object sender, EventArgs e)
		{
			UpdateScaleCombo();
		}

		private void cbScale_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				int sc;
				if (int.TryParse(cbScale.Text, out sc))
				{
					ucMap.Map.Scale = sc;
					if (ucMap.Map.Scale != sc) cbScale.Text = ucMap.Map.Scale.ToString();
					ucMap.Repaint();
				}
			}
		}

		private void btnPen_Click(object sender, EventArgs e)
		{
			TogglePenMode();
		}

		private void TogglePenMode()
		{
			penMode = !penMode;
			UpdateControls();

		}

		private void UpdateControls()
		{
			ucMap.Cursor = btnPen.Checked ? Cursors.Cross : Cursors.Default;
			btnPen.Checked = penMode;
			miPenMode.Checked = penMode;
//		20.09.08
//			miPrintTileColorMode.Checked = printTileColorMode;
		}

		private void ucMap_MouseDown(object sender, MouseEventArgs e)
		{
			downPoint = e.Location;
		}

		private void miScaleUp_Click(object sender, EventArgs e)
		{
			ScaleUp();
		}

		private void miScaleDown_Click(object sender, EventArgs e)
		{
			ScaleDown();
		}

		private void miLeft_Click(object sender, EventArgs e)
		{
			MoveLeft();
		}

		private void miRight_Click(object sender, EventArgs e)
		{
			MoveRight();
		}

		private void miTop_Click(object sender, EventArgs e)
		{
			MoveTop();
		}

		private void miBottom_Click(object sender, EventArgs e)
		{
			MoveBottom();
		}

		private void miPrint_Click(object sender, EventArgs e)
		{
			PrintMatrixes();
		}

		private void miPrintMatrixesPreview_Click(object sender, EventArgs e)
		{
			PrintMatrixesPreview();
		}

		private void PrintMatrixesPreview()
		{
			gi = 0;
			gj = 0;

			if (PrintPreviewDialog.ShowDialog() == DialogResult.OK)
				document.Print();
		}

		private void miSavePannoPicture_Click(object sender, EventArgs e)
		{
			SavePannoPicture();
		}

		private void miPalette_Click(object sender, EventArgs e)
		{
			ShowPalette();
		}

		private void miPenMode_Click(object sender, EventArgs e)
		{
			TogglePenMode();
		}

		private void btnPrintReport_Click(object sender, EventArgs e)
		{
			PrintReport();
		}

		private void PrintReport()
		{
			try
			{
				reportPageCnt = 0;
				ncolumns = 0;

				if (PrintReportDialog.ShowDialog() == DialogResult.OK)
					report.Print();
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void miPrintReport_Click(object sender, EventArgs e)
		{
			PrintReport();
		}

		private void miPrintReportPreview_Click(object sender, EventArgs e)
		{
			PrintReportPreview();
		}

		private void PrintReportPreview()
		{
			try
			{
				reportPageCnt = 0;
				ncolumns = 0;

				if (PreviewReportDialog.ShowDialog() == DialogResult.OK)
					report.Print();
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void btnSaveReport_Click(object sender, EventArgs e)
		{
			SaveReport();
		}

		private void SaveReport()
		{
			try
			{
				ReportSaveFileDialog.InitialDirectory = PathUtils.BaseDirectory;
				ReportSaveFileDialog.Filter =
								"Текстовые файлы (*.txt)|*.txt;|MS Excel CSV-файл (*.csv)|*.csv;|Все файлы|*.*";

				ReportSaveFileDialog.FileName = mosaicFileName;

				if (ReportSaveFileDialog.ShowDialog() == DialogResult.OK)
					SaveMosaicReport(ReportSaveFileDialog.FileName);
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		private void miSaveReport_Click(object sender, EventArgs e)
		{
			SaveReport();
		}

		void PrintMatrixesMode()
		{
			try
			{
				if (new PrintingMode().ShowDialog() == DialogResult.OK)
				{
					printTileColorMode = App.Config.printTileColorMode;
					UpdateControls();
				}
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		#region Printing

		private PrintDocument document;

		//        const int PageStartX = 5;
		/*const */
		int PageStartX = 10;
		/*const */
		int PageStartY = 10;
		//		const int PageStartYD = 10;
		const int TitleY = /*10*/ 5;

		int gi;                     //  индекс колонки
		int gj;                     //  индекс строки

		private PrintDocument report;

		int reportPageCnt;          //  количество страниц отчета

		int ncolumns;               //  Количество напечатаных колонок отчета 

		#endregion

		private void PrintingInit()
		{
			document = new PrintDocument();
			document.PrintPage += new PrintPageEventHandler(document_PrintPage);

			PrintPreviewDialog.Document = document;
			PrintPreviewDialog.Width = 500;
			PrintPreviewDialog.Height = 600;

			PrintMosaicDialog.Document = document;
			PrintMosaicDialog.AllowSomePages = true;
			PrintMosaicDialog.ShowHelp = true;

			report = new PrintDocument();
			report.PrintPage += new PrintPageEventHandler(report_PrintPage);

			PreviewReportDialog.Document = report;
			PreviewReportDialog.Width = 500;
			PreviewReportDialog.Height = 600;

			PrintReportDialog.Document = report;
			PrintReportDialog.AllowSomePages = true;
			PrintReportDialog.ShowHelp = true;
		}


		void report_PrintPage(object sender, PrintPageEventArgs e)
		{

			Graphics g = e.Graphics;
			g.PageUnit = GraphicsUnit.Millimeter;
			e.HasMorePages = WriteReportPage(g, ref ncolumns);
			return;
		}

		private bool WriteReportPage(Graphics g, ref int ncolumns)
		{

			DrawReportPageCaption(g);

			Font font = new Font("Arial", 14, FontStyle.Bold);
			SolidBrush brush = new SolidBrush( Color.Black /*App.Config.MatrixLineColor*/);

			DrawReportPageTable(g);
			DrawReportPageTitle(g, font, brush);

			const int yshift = /*6*/ 7;
			const int rowperpage = /*37*/ 30 /*10*/;

			DrawReportPageColumn(g, ncolumns, font, brush, yshift, rowperpage, 30, 75);
			ncolumns++;

			DrawReportPageColumn(g, ncolumns, font, brush, yshift, rowperpage, 120, 165);
			ncolumns++;

			return palette.colors.Count / (rowperpage * ncolumns) > 0;

		}

		private void DrawReportPageColumn(Graphics g, int ncolumns, Font font, SolidBrush brush, int yshift, int rowperpage, int x1, int x2)
		{

			int start = rowperpage * ncolumns;
			int end = Math.Min(palette.colors.Count, start + rowperpage);

			int reportY = 55;
			for (int i = start; i < end; i++)
				DrawReportPageRow(g, font, brush,
						palette.colors[i], x1, x2, yshift, ref reportY);

		}

		private void DrawReportPageCaption(Graphics g)
		{
			string title = "Отчет по мозаике: " + mosaicFileName
					+ "  (стр. № " + (++reportPageCnt).ToString() + " )";

			Font printFont = new Font("Arial", 18, FontStyle.Underline | FontStyle.Bold);
			g.DrawString(title, printFont, new SolidBrush(Color.Blue),
					new Point(20, 15), StringFormat.GenericDefault);
		}

		private void DrawReportPageRow(Graphics g, Font font, SolidBrush brush,
						NamedColor color, int x1, int x2, int yshift, ref int reportY)
		{
			g.DrawString(color.name, font, brush, new Point(x1, reportY));

			int cnt = CountColor(color);
			g.DrawString(cnt.ToString(), font, brush, new Point(x2, reportY));

			reportY += yshift;
		}

		private static void DrawReportPageTitle(Graphics g, Font font, SolidBrush brush)
		{
			g.DrawString("Индекс", font, brush,
							new Point(25, 35), StringFormat.GenericDefault);
			g.DrawString("Количество", font, brush,
							new Point(65, 35), StringFormat.GenericDefault);
			g.DrawString("Индекс", font, brush,
							new Point(115, 35), StringFormat.GenericDefault);
			g.DrawString("Количество", font, brush,
							new Point(155, 35), StringFormat.GenericDefault);
		}

		private static void DrawReportPageTable(Graphics g)
		{
			Pen pen = new Pen(Color.Black, 0.5f);

			int leftX = 15;
			int midX = 100;
			int midX1 = (midX + leftX) / 2;
			int rightX = 195;
			int midX2 = (midX + rightX) / 2;

			int topY = 30;
			int midY = 50;
			int bottomY = 280;

			g.DrawLine(pen, new Point(leftX, topY), new Point(rightX, topY));
			g.DrawLine(pen, new Point(leftX, midY), new Point(rightX, midY));
			g.DrawLine(pen, new Point(leftX, midY - 1), new Point(rightX, midY - 1));
			g.DrawLine(pen, new Point(leftX, bottomY), new Point(rightX, bottomY));

			g.DrawLine(pen, new Point(leftX, topY), new Point(leftX, bottomY));
			g.DrawLine(pen, new Point(midX, topY), new Point(midX, bottomY));
			g.DrawLine(pen, new Point(midX + 1, topY), new Point(midX + 1, bottomY));
			g.DrawLine(pen, new Point(midX1, topY), new Point(midX1, bottomY));
			g.DrawLine(pen, new Point(midX2, topY), new Point(midX2, bottomY));
			g.DrawLine(pen, new Point(rightX, topY), new Point(rightX, bottomY));
		}

		void document_PrintPage(object sender, PrintPageEventArgs e)
		{
			Graphics g = e.Graphics;
			g.PageUnit = GraphicsUnit.Millimeter;

//		попробуем подсчитать количество матриц на страницу
			int xlen = App.Config.MatrixRealSize;			//		ширина листа по x
			int ylen = App.Config.MatrixRealSize;			//		ширина листа по y
			int mpsX = (int)(document.PrinterSettings.DefaultPageSettings.PaperSize.Width*0.25f)  /
							( /*App.Config.MatrixRealSize*/ (xlen / c.mx * c.mx )+ App.Config.MatrixBevel );
			int mpsY = (int)(document.PrinterSettings.DefaultPageSettings.PaperSize.Height*0.25f) /
							( /*App.Config.MatrixRealSize*/ ( ylen / c.my * c.my ) + App.Config.MatrixBevel );

			float factor = App.Config.MatrixRealSize / 200.0f;
			if (gi * c.mx < bitmap.Width)
			{
				DrawOnePage(e.Graphics, gi, gj, factor, mpsX, mpsY );
				gi+= mpsX;
			}
			else
			{
				gi = 0;
				gj += mpsY;
			}
			e.HasMorePages = (c.my * gj < bitmap.Height);
		}

		private void DrawOnePage(Graphics g, int gi, int gj, float factor, int mpsX, int mpsY )
		{
			PageStartY = 10;
			for ( int pj = 0; pj < mpsY; pj++ )				
			{
				PageStartX = 10;
				for ( int pi = 0; pi < mpsX; pi++ )	
					DrawOneMatrix( g, gi, gj, factor, pi, pj, mpsX, mpsY );
			}
		}

		private void DrawOneMatrix( Graphics g, int gi, int gj, float factor, int pi, int pj, int mpsX, int mpsY )
		{

			int xlen = App.Config.MatrixRealSize;			//		размер матрицы по x
			int ylen = App.Config.MatrixRealSize;			//		размер матрицы по y
			int bevel = App.Config.MatrixBevel;

			int cx = xlen / c.mx;							//		длина клетки по x
			int cy = ylen / c.my;							//		длина клетки по y

			int rxlen = cx * c.mx;							//		реальный размер матрицы по X
			int rylen = cy * c.my;							//		реальный размер матрицы по X

			int tpx = ( gi + pi ) * c.mx;					//		уже напечатано плиток по X
			int tpy = ( gj + pj ) * c.my;					//		уже напечатано плиток по Y

			int StartX = PageStartX + pi * ( rxlen + bevel );
			int StartY = PageStartY + pj * ( rylen + bevel + TitleY );

			string title = mosaicFileName + "  Индекс листа № " + GetIndex( gj + pj ) + ( gi + pi + 1 );
			Font printFont = new Font( "Arial", 16 * factor, FontStyle.Underline | FontStyle.Bold );
			g.DrawString( title, printFont, new SolidBrush( Color.Blue ), 
				new Point( StartX, StartY - TitleY ), StringFormat.GenericDefault );

			int	finishX = StartX + Math.Min( bitmap.Width - tpx, c.mx ) * cx;
			int	finishY = StartY + Math.Min( bitmap.Height - tpy, c.my ) * cy;

			StringFormat format = new StringFormat();
			format.Alignment = StringAlignment.Center;
			format.LineAlignment = StringAlignment.Center;

			Font font = new Font( "Arial", 8 * factor, FontStyle.Regular );
			SolidBrush brush = new SolidBrush( Color.Black );
			SolidBrush brush2 = new SolidBrush( Color.Gray );

			for ( int xi = 0; xi < Math.Min( bitmap.Width - tpx, c.mx ); xi++ )
				for ( int yi = 0; yi < Math.Min( bitmap.Height - tpy, c.my ); yi++ )
				{
					int X = tpx + xi;
					int Y = tpy + yi;
					NamedColor nc = indexTable[ X, Y ];
					RectangleF r = new RectangleF( StartX + xi * cx, StartY + yi * cy, cx, cy );
					//					RectangleF r = new RectangleF( (float)x + 0.5f, (float)y + 0.5f, cx - 1.0f, cy - 1.0f );
					string text = nc.name;
					Brush br = brush;
					if ( printTileColorMode )
					{
						g.FillRectangle( new SolidBrush( nc.color ), r );
						//	                    string text = gi + ", " + gj;
						const int minColorLevel = 16;
						if ( nc.color.R < minColorLevel && nc.color.G < minColorLevel && nc.color.B < minColorLevel )// a dark color
							br = brush2;
					}

					RectangleF r1 = new RectangleF( StartX + xi * cx - cx / 2, StartY + yi * cy - cy / 2, 2*cx, 2*cy );
					g.DrawString( text, Font, br, r1, format );

				}

			Pen pen = new Pen( App.Config.MatrixLineColor, 0.5f );
			for ( int xi = 0; xi <= Math.Min( bitmap.Width - tpx, c.mx ); xi++ )
				g.DrawLine( pen, new Point( StartX + xi * cx, StartY ), new Point( StartX + xi * cx, finishY ) );

			for ( int yi = 0; yi <= Math.Min( bitmap.Height - tpy, c.my ); yi++ )
				g.DrawLine( pen, new Point( StartX, StartY + yi * cy ), new Point( finishX, StartY + yi * cy ) );


			//			g.CompositingMode = CompositingMode.SourceOver;			
			//g.FillRectangle( new SolidBrush( /*App.Config.MatrixLineColor*/
			//				Color.FromArgb( 150, App.Config.MatrixLineColor ) ), new Rectangle( 0, 0, 100, 100 ) );

/*
			Pen penl = new Pen( Color.FromArgb( 255, App.Config.MatrixLineColor ), 0.5f );
			for ( int x = PageStartX; x <= finishX; x += cx )
				g.DrawLine( penl, new Point( x, PageStartY + PageStartYD ), new Point( x, finishY ) );

			for ( int y = PageStartY + PageStartY; y <= finishY; y += cy )
				g.DrawLine( penl, new Point( PageStartX, y ), new Point( finishX, y ) );
*/
			//			g.CompositingMode = CompositingMode.SourceCopy;
		}

		private void miPrintMatrixes_Click(object sender, EventArgs e)
		{
			PrintMatrixes();
		}

		private void miPrintMatrixesMode_Click(object sender, EventArgs e)
		{
			PrintMatrixesMode();
		}

		private void btnPrintMatrixesMode_Click(object sender, EventArgs e)
		{
			PrintMatrixesMode();
		}

		private void PrintPreviewDialog_Load(object sender, EventArgs e)
		{

		}

        private void miClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPalette_Click(object sender, EventArgs e)
        {
            ShowPalette();
        }
	}

}