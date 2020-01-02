namespace Mosaic
{
	partial class MosaicForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MosaicForm));
            this.SaveMosaicFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.PrintMosaicDialog = new System.Windows.Forms.PrintDialog();
            this.PrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.PreviewReportDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.PrintReportDialog = new System.Windows.Forms.PrintDialog();
            this.ReportSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tsNavigation = new System.Windows.Forms.ToolStrip();
            this.btnScaleDown = new System.Windows.Forms.ToolStripButton();
            this.btnScaleUp = new System.Windows.Forms.ToolStripButton();
            this.cbScale = new System.Windows.Forms.ToolStripComboBox();
            this.btnLeft = new System.Windows.Forms.ToolStripButton();
            this.btnTop = new System.Windows.Forms.ToolStripButton();
            this.btnBottom = new System.Windows.Forms.ToolStripButton();
            this.btnRight = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miSavePannoPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miPrintMatrixesPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.miPrintMatrixes = new System.Windows.Forms.ToolStripMenuItem();
            this.miPrintMatrixesMode = new System.Windows.Forms.ToolStripMenuItem();
            this.miEditGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.miPalette = new System.Windows.Forms.ToolStripMenuItem();
            this.miPenMode = new System.Windows.Forms.ToolStripMenuItem();
            this.miNavigation = new System.Windows.Forms.ToolStripMenuItem();
            this.miScaleUp = new System.Windows.Forms.ToolStripMenuItem();
            this.miScaleDown = new System.Windows.Forms.ToolStripMenuItem();
            this.miLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.miRight = new System.Windows.Forms.ToolStripMenuItem();
            this.miTop = new System.Windows.Forms.ToolStripMenuItem();
            this.miBottom = new System.Windows.Forms.ToolStripMenuItem();
            this.miReports = new System.Windows.Forms.ToolStripMenuItem();
            this.miPrintReport = new System.Windows.Forms.ToolStripMenuItem();
            this.miPrintReportPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsReport = new System.Windows.Forms.ToolStrip();
            this.btnPrintReport = new System.Windows.Forms.ToolStripButton();
            this.btnReportPreview = new System.Windows.Forms.ToolStripButton();
            this.btnSaveReport = new System.Windows.Forms.ToolStripButton();
            this.tsPanno = new System.Windows.Forms.ToolStrip();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnPrintPreview = new System.Windows.Forms.ToolStripButton();
            this.btnPrintMatrixesMode = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.chColor = new System.Windows.Forms.ColumnHeader();
            this.chName = new System.Windows.Forms.ColumnHeader();
            this.chCnt = new System.Windows.Forms.ColumnHeader();
            this.ucMap = new Mosaic.GeoLib.MapUserControl();
            this.tsEdit = new System.Windows.Forms.ToolStrip();
            this.btnPen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.miClose = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPalette = new System.Windows.Forms.ToolStripButton();
            this.tsNavigation.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tsReport.SuspendLayout();
            this.tsPanno.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tsEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrintMosaicDialog
            // 
            this.PrintMosaicDialog.UseEXDialog = true;
            // 
            // PrintPreviewDialog
            // 
            this.PrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewDialog.Enabled = true;
            this.PrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewDialog.Icon")));
            this.PrintPreviewDialog.Name = "PrintPreviewDialog";
            this.PrintPreviewDialog.Visible = false;
            this.PrintPreviewDialog.Load += new System.EventHandler(this.PrintPreviewDialog_Load);
            // 
            // PreviewReportDialog
            // 
            this.PreviewReportDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PreviewReportDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PreviewReportDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.PreviewReportDialog.Enabled = true;
            this.PreviewReportDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("PreviewReportDialog.Icon")));
            this.PreviewReportDialog.Name = "PreviewReportDialog";
            this.PreviewReportDialog.Visible = false;
            // 
            // PrintReportDialog
            // 
            this.PrintReportDialog.UseEXDialog = true;
            // 
            // tsNavigation
            // 
            this.tsNavigation.Dock = System.Windows.Forms.DockStyle.None;
            this.tsNavigation.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsNavigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnScaleDown,
            this.btnScaleUp,
            this.cbScale,
            this.btnLeft,
            this.btnTop,
            this.btnBottom,
            this.btnRight});
            this.tsNavigation.Location = new System.Drawing.Point(171, 0);
            this.tsNavigation.Name = "tsNavigation";
            this.tsNavigation.Size = new System.Drawing.Size(310, 27);
            this.tsNavigation.TabIndex = 30;
            this.tsNavigation.Text = "toolStrip1";
            // 
            // btnScaleDown
            // 
            this.btnScaleDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnScaleDown.Image = ((System.Drawing.Image)(resources.GetObject("btnScaleDown.Image")));
            this.btnScaleDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnScaleDown.Name = "btnScaleDown";
            this.btnScaleDown.Size = new System.Drawing.Size(24, 24);
            this.btnScaleDown.Text = "_scaleDown";
            this.btnScaleDown.ToolTipText = "_scaleDown";
            this.btnScaleDown.Click += new System.EventHandler(this.tsbScaleDown_Click);
            // 
            // btnScaleUp
            // 
            this.btnScaleUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnScaleUp.Image = ((System.Drawing.Image)(resources.GetObject("btnScaleUp.Image")));
            this.btnScaleUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnScaleUp.Name = "btnScaleUp";
            this.btnScaleUp.Size = new System.Drawing.Size(24, 24);
            this.btnScaleUp.Text = "_scaleUp";
            this.btnScaleUp.ToolTipText = "_scaleUp";
            this.btnScaleUp.Click += new System.EventHandler(this.tsbScaleUp_Click);
            // 
            // cbScale
            // 
            this.cbScale.Name = "cbScale";
            this.cbScale.Size = new System.Drawing.Size(121, 27);
            this.cbScale.SelectedIndexChanged += new System.EventHandler(this.cbScale_SelectedIndexChanged);
            this.cbScale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbScale_KeyDown);
            this.cbScale.Click += new System.EventHandler(this.cbScale_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft.Image")));
            this.btnLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(24, 24);
            this.btnLeft.Text = "_left";
            this.btnLeft.ToolTipText = "_left";
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnTop
            // 
            this.btnTop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTop.Image = ((System.Drawing.Image)(resources.GetObject("btnTop.Image")));
            this.btnTop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(24, 24);
            this.btnTop.Text = "_top";
            this.btnTop.ToolTipText = "_top";
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnBottom
            // 
            this.btnBottom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBottom.Image = ((System.Drawing.Image)(resources.GetObject("btnBottom.Image")));
            this.btnBottom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBottom.Name = "btnBottom";
            this.btnBottom.Size = new System.Drawing.Size(24, 24);
            this.btnBottom.Text = "_bottom";
            this.btnBottom.ToolTipText = "_bottom";
            this.btnBottom.Click += new System.EventHandler(this.btnBottom_Click);
            // 
            // btnRight
            // 
            this.btnRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRight.Image = ((System.Drawing.Image)(resources.GetObject("btnRight.Image")));
            this.btnRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(24, 24);
            this.btnRight.Text = "_right";
            this.btnRight.ToolTipText = "_right";
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miEditGroup,
            this.miNavigation,
            this.miReports});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSavePannoPicture,
            this.toolStripSeparator1,
            this.miPrintMatrixes,
            this.miPrintMatrixesPreview,
            this.miPrintMatrixesMode,
            this.toolStripSeparator2,
            this.miClose});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(40, 20);
            this.miFile.Text = "_file";
            // 
            // miSavePannoPicture
            // 
            this.miSavePannoPicture.Name = "miSavePannoPicture";
            this.miSavePannoPicture.Size = new System.Drawing.Size(179, 22);
            this.miSavePannoPicture.Text = "_saveMosaicImage";
            this.miSavePannoPicture.Click += new System.EventHandler(this.miSavePannoPicture_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(176, 6);
            // 
            // miPrintMatrixesPreview
            // 
            this.miPrintMatrixesPreview.Name = "miPrintMatrixesPreview";
            this.miPrintMatrixesPreview.Size = new System.Drawing.Size(179, 22);
            this.miPrintMatrixesPreview.Text = "_sheetsPrintPreview";
            this.miPrintMatrixesPreview.Click += new System.EventHandler(this.miPrintMatrixesPreview_Click);
            // 
            // miPrintMatrixes
            // 
            this.miPrintMatrixes.Name = "miPrintMatrixes";
            this.miPrintMatrixes.Size = new System.Drawing.Size(179, 22);
            this.miPrintMatrixes.Text = "_printSheets";
            this.miPrintMatrixes.Click += new System.EventHandler(this.miPrintMatrixes_Click);
            // 
            // miPrintMatrixesMode
            // 
            this.miPrintMatrixesMode.Name = "miPrintMatrixesMode";
            this.miPrintMatrixesMode.Size = new System.Drawing.Size(179, 22);
            this.miPrintMatrixesMode.Text = "_sheetsPrintOptions";
            this.miPrintMatrixesMode.Click += new System.EventHandler(this.miPrintMatrixesMode_Click);
            // 
            // miEditGroup
            // 
            this.miEditGroup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPalette,
            this.miPenMode});
            this.miEditGroup.Name = "miEditGroup";
            this.miEditGroup.Size = new System.Drawing.Size(44, 20);
            this.miEditGroup.Text = "_edit";
            // 
            // miPalette
            // 
            this.miPalette.Name = "miPalette";
            this.miPalette.Size = new System.Drawing.Size(178, 22);
            this.miPalette.Text = "_palette";
            this.miPalette.Click += new System.EventHandler(this.miPalette_Click);
            // 
            // miPenMode
            // 
            this.miPenMode.Name = "miPenMode";
            this.miPenMode.Size = new System.Drawing.Size(178, 22);
            this.miPenMode.Text = "_changeColorMode";
            this.miPenMode.Click += new System.EventHandler(this.miPenMode_Click);
            // 
            // miNavigation
            // 
            this.miNavigation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miScaleUp,
            this.miScaleDown,
            this.miLeft,
            this.miRight,
            this.miTop,
            this.miBottom});
            this.miNavigation.Name = "miNavigation";
            this.miNavigation.Size = new System.Drawing.Size(48, 20);
            this.miNavigation.Text = "_view";
            // 
            // miScaleUp
            // 
            this.miScaleUp.Name = "miScaleUp";
            this.miScaleUp.Size = new System.Drawing.Size(152, 22);
            this.miScaleUp.Text = "_scaleUp";
            this.miScaleUp.Click += new System.EventHandler(this.miScaleUp_Click);
            // 
            // miScaleDown
            // 
            this.miScaleDown.Name = "miScaleDown";
            this.miScaleDown.Size = new System.Drawing.Size(152, 22);
            this.miScaleDown.Text = "_scaleDown";
            this.miScaleDown.Click += new System.EventHandler(this.miScaleDown_Click);
            // 
            // miLeft
            // 
            this.miLeft.Name = "miLeft";
            this.miLeft.Size = new System.Drawing.Size(152, 22);
            this.miLeft.Text = "_left";
            this.miLeft.Click += new System.EventHandler(this.miLeft_Click);
            // 
            // miRight
            // 
            this.miRight.Name = "miRight";
            this.miRight.Size = new System.Drawing.Size(152, 22);
            this.miRight.Text = "_right";
            this.miRight.Click += new System.EventHandler(this.miRight_Click);
            // 
            // miTop
            // 
            this.miTop.Name = "miTop";
            this.miTop.Size = new System.Drawing.Size(152, 22);
            this.miTop.Text = "_top";
            this.miTop.Click += new System.EventHandler(this.miTop_Click);
            // 
            // miBottom
            // 
            this.miBottom.Name = "miBottom";
            this.miBottom.Size = new System.Drawing.Size(152, 22);
            this.miBottom.Text = "_bottom";
            this.miBottom.Click += new System.EventHandler(this.miBottom_Click);
            // 
            // miReports
            // 
            this.miReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPrintReport,
            this.miPrintReportPreview,
            this.miSaveReport});
            this.miReports.Name = "miReports";
            this.miReports.Size = new System.Drawing.Size(61, 20);
            this.miReports.Text = "_reports";
            // 
            // miPrintReport
            // 
            this.miPrintReport.Name = "miPrintReport";
            this.miPrintReport.Size = new System.Drawing.Size(204, 22);
            this.miPrintReport.Text = "_printTileCountReport";
            this.miPrintReport.Click += new System.EventHandler(this.miPrintReport_Click);
            // 
            // miPrintReportPreview
            // 
            this.miPrintReportPreview.Name = "miPrintReportPreview";
            this.miPrintReportPreview.Size = new System.Drawing.Size(204, 22);
            this.miPrintReportPreview.Text = "_tileCountReportPreview";
            this.miPrintReportPreview.Click += new System.EventHandler(this.miPrintReportPreview_Click);
            // 
            // miSaveReport
            // 
            this.miSaveReport.Name = "miSaveReport";
            this.miSaveReport.Size = new System.Drawing.Size(204, 22);
            this.miSaveReport.Text = "_saveTileCountReport";
            this.miSaveReport.Click += new System.EventHandler(this.miSaveReport_Click);
            // 
            // tsReport
            // 
            this.tsReport.Dock = System.Windows.Forms.DockStyle.None;
            this.tsReport.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsReport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPrintReport,
            this.btnReportPreview,
            this.btnSaveReport});
            this.tsReport.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsReport.Location = new System.Drawing.Point(589, 24);
            this.tsReport.Name = "tsReport";
            this.tsReport.Size = new System.Drawing.Size(84, 27);
            this.tsReport.TabIndex = 32;
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrintReport.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintReport.Image")));
            this.btnPrintReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(24, 24);
            this.btnPrintReport.Text = "_printTileCountReport";
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // btnReportPreview
            // 
            this.btnReportPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReportPreview.Image = ((System.Drawing.Image)(resources.GetObject("btnReportPreview.Image")));
            this.btnReportPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReportPreview.Name = "btnReportPreview";
            this.btnReportPreview.Size = new System.Drawing.Size(24, 24);
            this.btnReportPreview.Text = "_tileCountReportPreview";
            this.btnReportPreview.Click += new System.EventHandler(this.btnReportPreview_Click);
            // 
            // btnSaveReport
            // 
            this.btnSaveReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveReport.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveReport.Image")));
            this.btnSaveReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveReport.Name = "btnSaveReport";
            this.btnSaveReport.Size = new System.Drawing.Size(24, 24);
            this.btnSaveReport.Text = "_saveTileCountReport";
            this.btnSaveReport.Click += new System.EventHandler(this.btnSaveReport_Click);
            // 
            // tsPanno
            // 
            this.tsPanno.Dock = System.Windows.Forms.DockStyle.None;
            this.tsPanno.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsPanno.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPrint,
            this.btnPrintPreview,
            this.btnPrintMatrixesMode,
            this.btnSave});
            this.tsPanno.Location = new System.Drawing.Point(4, 0);
            this.tsPanno.Name = "tsPanno";
            this.tsPanno.Size = new System.Drawing.Size(107, 27);
            this.tsPanno.TabIndex = 31;
            // 
            // btnPrint
            // 
            this.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(24, 24);
            this.btnPrint.Text = "_printSheets";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrintPreview.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintPreview.Image")));
            this.btnPrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(24, 24);
            this.btnPrintPreview.Text = "_sheetsPrintPreview";
            this.btnPrintPreview.ToolTipText = "_sheetsPrintPreview";
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // btnPrintMatrixesMode
            // 
            this.btnPrintMatrixesMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrintMatrixesMode.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintMatrixesMode.Image")));
            this.btnPrintMatrixesMode.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPrintMatrixesMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrintMatrixesMode.Name = "btnPrintMatrixesMode";
            this.btnPrintMatrixesMode.Size = new System.Drawing.Size(23, 24);
            this.btnPrintMatrixesMode.Text = "_sheetsPrintOptions";
            this.btnPrintMatrixesMode.Click += new System.EventHandler(this.btnPrintMatrixesMode_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(24, 24);
            this.btnSave.Text = "Сохранить панно";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(658, 377);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(822, 429);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(822, 456);
            this.toolStripContainer1.TabIndex = 34;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.tsNavigation);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.tsEdit);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.tsPanno);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnUpdate);
            this.splitContainer1.Panel1.Controls.Add(this.cbSort);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.listView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ucMap);
            this.splitContainer1.Size = new System.Drawing.Size(822, 429);
            this.splitContainer1.SplitterDistance = 226;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.Location = new System.Drawing.Point(3, 403);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "_update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbSort
            // 
            this.cbSort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "Пользовательская",
            "Имя",
            "Цвет"});
            this.cbSort.Location = new System.Drawing.Point(79, 7);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(145, 21);
            this.cbSort.TabIndex = 32;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "_sorting:";
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.CheckBoxes = true;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chColor,
            this.chName,
            this.chCnt});
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.LabelWrap = false;
            this.listView.Location = new System.Drawing.Point(3, 34);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.ShowGroups = false;
            this.listView.Size = new System.Drawing.Size(220, 363);
            this.listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView.TabIndex = 30;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
            this.listView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView_ItemChecked);
            this.listView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            // 
            // chColor
            // 
            this.chColor.Text = "_color";
            // 
            // chName
            // 
            this.chName.Text = "_name";
            this.chName.Width = 70;
            // 
            // chCnt
            // 
            this.chCnt.Text = "_count";
            this.chCnt.Width = 71;
            // 
            // ucMap
            // 
            this.ucMap.BackColor = System.Drawing.Color.White;
            this.ucMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMap.Location = new System.Drawing.Point(0, 0);
            this.ucMap.Name = "ucMap";
            this.ucMap.Size = new System.Drawing.Size(592, 429);
            this.ucMap.TabIndex = 3;
            this.ucMap.Load += new System.EventHandler(this.ucMap_Load);
            this.ucMap.MouseLeave += new System.EventHandler(this.ucMap_MouseLeave);
            this.ucMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ucMap_MouseMove);
            this.ucMap.OnScaleChanged += new System.EventHandler(this.ucMap_OnScaleChanged);
            this.ucMap.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ucMap_MouseDoubleClick);
            this.ucMap.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ucMap_KeyUp);
            this.ucMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ucMap_MouseClick);
            this.ucMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ucMap_MouseDown);
            this.ucMap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ucMap_KeyDown);
            // 
            // tsEdit
            // 
            this.tsEdit.Dock = System.Windows.Forms.DockStyle.None;
            this.tsEdit.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPalette,
            this.btnPen});
            this.tsEdit.Location = new System.Drawing.Point(111, 0);
            this.tsEdit.Name = "tsEdit";
            this.tsEdit.Size = new System.Drawing.Size(60, 27);
            this.tsEdit.TabIndex = 33;
            // 
            // btnPen
            // 
            this.btnPen.CheckOnClick = true;
            this.btnPen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPen.Image = ((System.Drawing.Image)(resources.GetObject("btnPen.Image")));
            this.btnPen.ImageTransparentColor = System.Drawing.Color.White;
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(24, 24);
            this.btnPen.Text = "_changeColorMode";
            this.btnPen.Click += new System.EventHandler(this.btnPen_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(176, 6);
            // 
            // miClose
            // 
            this.miClose.Name = "miClose";
            this.miClose.Size = new System.Drawing.Size(179, 22);
            this.miClose.Text = "_close";
            this.miClose.Click += new System.EventHandler(this.miClose_Click);
            // 
            // btnPalette
            // 
            this.btnPalette.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPalette.Image = ((System.Drawing.Image)(resources.GetObject("btnPalette.Image")));
            this.btnPalette.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPalette.Name = "btnPalette";
            this.btnPalette.Size = new System.Drawing.Size(24, 24);
            this.btnPalette.Text = "_palette";
            this.btnPalette.Click += new System.EventHandler(this.btnPalette_Click);
            // 
            // MosaicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 480);
            this.Controls.Add(this.tsReport);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MosaicForm";
            this.Text = "_mosaicTiles";
            this.Load += new System.EventHandler(this.MosaicForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MosaicForm_FormClosed);
            this.tsNavigation.ResumeLayout(false);
            this.tsNavigation.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tsReport.ResumeLayout(false);
            this.tsReport.PerformLayout();
            this.tsPanno.ResumeLayout(false);
            this.tsPanno.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tsEdit.ResumeLayout(false);
            this.tsEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.SaveFileDialog SaveMosaicFileDialog;
        private System.Windows.Forms.PrintDialog PrintMosaicDialog;
		private System.Windows.Forms.PrintPreviewDialog PrintPreviewDialog;
        private System.Windows.Forms.PrintPreviewDialog PreviewReportDialog;
        private System.Windows.Forms.PrintDialog PrintReportDialog;
		private System.Windows.Forms.SaveFileDialog ReportSaveFileDialog;
		private System.Windows.Forms.ToolStrip tsNavigation;
		private System.Windows.Forms.ToolStripButton btnScaleDown;
		private System.Windows.Forms.ToolStripButton btnScaleUp;
		private System.Windows.Forms.ToolStripComboBox cbScale;
		private System.Windows.Forms.ToolStrip tsPanno;
		private System.Windows.Forms.ToolStripButton btnSave;
		private System.Windows.Forms.ToolStripButton btnPrint;
		private System.Windows.Forms.ToolStripButton btnPrintPreview;
		private System.Windows.Forms.ToolStrip tsReport;
		private System.Windows.Forms.ToolStripButton btnReportPreview;
		private System.Windows.Forms.ToolStripButton btnPrintReport;
		private System.Windows.Forms.ToolStripButton btnSaveReport;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem miNavigation;
		private System.Windows.Forms.ToolStripButton btnLeft;
		private System.Windows.Forms.ToolStripButton btnTop;
		private System.Windows.Forms.ToolStripButton btnBottom;
        private System.Windows.Forms.ToolStripButton btnRight;
		private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
		private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
		private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
		private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
		private System.Windows.Forms.ToolStripContentPanel ContentPanel;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		internal Mosaic.GeoLib.MapUserControl ucMap;
		private System.Windows.Forms.ComboBox cbSort;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListView listView;
		private System.Windows.Forms.ColumnHeader chColor;
		private System.Windows.Forms.ColumnHeader chName;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.ColumnHeader chCnt;
		private System.Windows.Forms.ToolStrip tsEdit;
		private System.Windows.Forms.ToolStripButton btnPen;
		private System.Windows.Forms.ToolStripMenuItem miScaleUp;
		private System.Windows.Forms.ToolStripMenuItem miScaleDown;
		private System.Windows.Forms.ToolStripMenuItem miLeft;
		private System.Windows.Forms.ToolStripMenuItem miRight;
		private System.Windows.Forms.ToolStripMenuItem miTop;
		private System.Windows.Forms.ToolStripMenuItem miBottom;
		private System.Windows.Forms.ToolStripMenuItem miEditGroup;
		private System.Windows.Forms.ToolStripMenuItem miPalette;
		private System.Windows.Forms.ToolStripMenuItem miFile;
		private System.Windows.Forms.ToolStripMenuItem miSavePannoPicture;
		private System.Windows.Forms.ToolStripMenuItem miPenMode;
		private System.Windows.Forms.ToolStripMenuItem miPrintMatrixesPreview;
		private System.Windows.Forms.ToolStripMenuItem miPrintMatrixes;
		private System.Windows.Forms.ToolStripMenuItem miReports;
		private System.Windows.Forms.ToolStripMenuItem miPrintReport;
		private System.Windows.Forms.ToolStripMenuItem miPrintReportPreview;
		private System.Windows.Forms.ToolStripMenuItem miSaveReport;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem miPrintMatrixesMode;
		private System.Windows.Forms.ToolStripButton btnPrintMatrixesMode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem miClose;
        private System.Windows.Forms.ToolStripButton btnPalette;


	}
}