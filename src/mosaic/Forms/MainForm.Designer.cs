namespace Mosaic
{
	partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.buttonChange = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnGridColor = new System.Windows.Forms.Button();
            this.lblGridColor = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nudMX = new System.Windows.Forms.NumericUpDown();
            this.nudMY = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGapColor = new System.Windows.Forms.Button();
            this.lblGapColor = new System.Windows.Forms.Label();
            this.nudGap = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbPalettes = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkSquare = new System.Windows.Forms.CheckBox();
            this.nudTileWidth = new System.Windows.Forms.NumericUpDown();
            this.nudTileHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudPannoWidth = new System.Windows.Forms.NumericUpDown();
            this.nudPannoHeight = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.mainMenu.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMY)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGap)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTileWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTileHeight)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPannoWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPannoHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.Filter = "Image files (*.bmp; *.gif; *.jpg; *.png)|*.bmp; *.gif; *.jpg; *.png; |All files |" +
    "*.*";
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(665, 24);
            this.mainMenu.TabIndex = 26;
            this.mainMenu.Text = "menuStrip1";
            this.mainMenu.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fileToolStripMenuItem.Text = "&Файл";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.newToolStripMenuItem.Text = "&Новый проект";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.openToolStripMenuItem.Text = "&Открыть...";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(174, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.saveToolStripMenuItem.Text = "&Сохранить";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.saveAsToolStripMenuItem.Text = "Сохранить &Как...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.printToolStripMenuItem.Text = "&Печать";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.printPreviewToolStripMenuItem.Text = "_printPreview";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(174, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.exitToolStripMenuItem.Text = "_exit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.buttonChange);
            this.toolStripContainer.ContentPanel.Controls.Add(this.btnAbout);
            this.toolStripContainer.ContentPanel.Controls.Add(this.lblFilePath);
            this.toolStripContainer.ContentPanel.Controls.Add(this.groupBox5);
            this.toolStripContainer.ContentPanel.Controls.Add(this.groupBox4);
            this.toolStripContainer.ContentPanel.Controls.Add(this.groupBox3);
            this.toolStripContainer.ContentPanel.Controls.Add(this.btnCreate);
            this.toolStripContainer.ContentPanel.Controls.Add(this.btnImage);
            this.toolStripContainer.ContentPanel.Controls.Add(this.groupBox2);
            this.toolStripContainer.ContentPanel.Controls.Add(this.groupBox1);
            this.toolStripContainer.ContentPanel.Controls.Add(this.pictureBox);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(665, 560);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(665, 560);
            this.toolStripContainer.TabIndex = 27;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.tsMain);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(277, 12);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(117, 23);
            this.buttonChange.TabIndex = 39;
            this.buttonChange.Text = "_changeSize";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Location = new System.Drawing.Point(569, 12);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(84, 23);
            this.btnAbout.TabIndex = 38;
            this.btnAbout.Text = "_about";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilePath.Location = new System.Drawing.Point(149, 38);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(504, 17);
            this.lblFilePath.TabIndex = 37;
            this.lblFilePath.Text = "   ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnGridColor);
            this.groupBox5.Controls.Add(this.lblGridColor);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.nudMX);
            this.groupBox5.Controls.Add(this.nudMY);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(3, 260);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(140, 73);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "_tileSheet";
            // 
            // btnGridColor
            // 
            this.btnGridColor.AutoSize = true;
            this.btnGridColor.Location = new System.Drawing.Point(112, 42);
            this.btnGridColor.Name = "btnGridColor";
            this.btnGridColor.Size = new System.Drawing.Size(26, 23);
            this.btnGridColor.TabIndex = 18;
            this.btnGridColor.Text = "...";
            this.btnGridColor.UseVisualStyleBackColor = true;
            this.btnGridColor.Click += new System.EventHandler(this.btnGridColor_Click);
            // 
            // lblGridColor
            // 
            this.lblGridColor.BackColor = System.Drawing.Color.LightGray;
            this.lblGridColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGridColor.Location = new System.Drawing.Point(81, 42);
            this.lblGridColor.Name = "lblGridColor";
            this.lblGridColor.Size = new System.Drawing.Size(31, 23);
            this.lblGridColor.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "_gridColor:";
            // 
            // nudMX
            // 
            this.nudMX.Location = new System.Drawing.Point(6, 19);
            this.nudMX.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMX.Name = "nudMX";
            this.nudMX.Size = new System.Drawing.Size(51, 20);
            this.nudMX.TabIndex = 13;
            this.nudMX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMX.ValueChanged += new System.EventHandler(this.nudMX_ValueChanged);
            // 
            // nudMY
            // 
            this.nudMY.Location = new System.Drawing.Point(81, 19);
            this.nudMY.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMY.Name = "nudMY";
            this.nudMY.Size = new System.Drawing.Size(51, 20);
            this.nudMY.TabIndex = 14;
            this.nudMY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMY.ValueChanged += new System.EventHandler(this.nudMY_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "x";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGapColor);
            this.groupBox4.Controls.Add(this.lblGapColor);
            this.groupBox4.Controls.Add(this.nudGap);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(3, 181);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(140, 73);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "_tileGap";
            // 
            // btnGapColor
            // 
            this.btnGapColor.AutoSize = true;
            this.btnGapColor.Location = new System.Drawing.Point(112, 42);
            this.btnGapColor.Name = "btnGapColor";
            this.btnGapColor.Size = new System.Drawing.Size(26, 23);
            this.btnGapColor.TabIndex = 15;
            this.btnGapColor.Text = "...";
            this.btnGapColor.UseVisualStyleBackColor = true;
            this.btnGapColor.Click += new System.EventHandler(this.btnGapColor_Click);
            // 
            // lblGapColor
            // 
            this.lblGapColor.BackColor = System.Drawing.Color.LightGray;
            this.lblGapColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGapColor.Location = new System.Drawing.Point(61, 42);
            this.lblGapColor.Name = "lblGapColor";
            this.lblGapColor.Size = new System.Drawing.Size(51, 23);
            this.lblGapColor.TabIndex = 14;
            // 
            // nudGap
            // 
            this.nudGap.DecimalPlaces = 1;
            this.nudGap.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudGap.Location = new System.Drawing.Point(61, 19);
            this.nudGap.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudGap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudGap.Name = "nudGap";
            this.nudGap.Size = new System.Drawing.Size(51, 20);
            this.nudGap.TabIndex = 13;
            this.nudGap.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudGap.ValueChanged += new System.EventHandler(this.nudGap_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "_width:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "_color:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.lbPalettes);
            this.groupBox3.Controls.Add(this.btnRemove);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Location = new System.Drawing.Point(3, 339);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(140, 214);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "_palette";
            // 
            // lbPalettes
            // 
            this.lbPalettes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPalettes.FormattingEnabled = true;
            this.lbPalettes.IntegralHeight = false;
            this.lbPalettes.Location = new System.Drawing.Point(6, 18);
            this.lbPalettes.Name = "lbPalettes";
            this.lbPalettes.Size = new System.Drawing.Size(128, 103);
            this.lbPalettes.TabIndex = 1;
            this.lbPalettes.SelectedIndexChanged += new System.EventHandler(this.lbPalettes_SelectedIndexChanged);
            this.lbPalettes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbPalettes_MouseDoubleClick);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(6, 185);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(128, 23);
            this.btnRemove.TabIndex = 23;
            this.btnRemove.Text = "_remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(6, 156);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 23);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "_add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(6, 127);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(128, 23);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "_edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.AutoSize = true;
            this.btnCreate.Location = new System.Drawing.Point(400, 12);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(122, 23);
            this.btnCreate.TabIndex = 32;
            this.btnCreate.Text = "_createMosaic";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnImage
            // 
            this.btnImage.AutoSize = true;
            this.btnImage.Location = new System.Drawing.Point(149, 12);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(122, 23);
            this.btnImage.TabIndex = 31;
            this.btnImage.Text = "_image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkSquare);
            this.groupBox2.Controls.Add(this.nudTileWidth);
            this.groupBox2.Controls.Add(this.nudTileHeight);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(3, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 93);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "_tileSize";
            // 
            // chkSquare
            // 
            this.chkSquare.AutoSize = true;
            this.chkSquare.Location = new System.Drawing.Point(9, 71);
            this.chkSquare.Name = "chkSquare";
            this.chkSquare.Size = new System.Drawing.Size(81, 17);
            this.chkSquare.TabIndex = 15;
            this.chkSquare.Text = "_squareTile";
            this.chkSquare.UseVisualStyleBackColor = true;
            this.chkSquare.CheckedChanged += new System.EventHandler(this.chkSquare_CheckedChanged);
            // 
            // nudTileWidth
            // 
            this.nudTileWidth.Location = new System.Drawing.Point(61, 19);
            this.nudTileWidth.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudTileWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTileWidth.Name = "nudTileWidth";
            this.nudTileWidth.Size = new System.Drawing.Size(51, 20);
            this.nudTileWidth.TabIndex = 13;
            this.nudTileWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTileWidth.ValueChanged += new System.EventHandler(this.nudTileWidth_ValueChanged);
            // 
            // nudTileHeight
            // 
            this.nudTileHeight.Location = new System.Drawing.Point(61, 45);
            this.nudTileHeight.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudTileHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTileHeight.Name = "nudTileHeight";
            this.nudTileHeight.Size = new System.Drawing.Size(51, 20);
            this.nudTileHeight.TabIndex = 14;
            this.nudTileHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTileHeight.ValueChanged += new System.EventHandler(this.nudTileHeight_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "_width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "_height:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudPannoWidth);
            this.groupBox1.Controls.Add(this.nudPannoHeight);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 73);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "_mosaicSize";
            // 
            // nudPannoWidth
            // 
            this.nudPannoWidth.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPannoWidth.Location = new System.Drawing.Point(61, 19);
            this.nudPannoWidth.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPannoWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPannoWidth.Name = "nudPannoWidth";
            this.nudPannoWidth.Size = new System.Drawing.Size(51, 20);
            this.nudPannoWidth.TabIndex = 13;
            this.nudPannoWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPannoWidth.ValueChanged += new System.EventHandler(this.nudPannoWidth_ValueChanged);
            // 
            // nudPannoHeight
            // 
            this.nudPannoHeight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPannoHeight.Location = new System.Drawing.Point(61, 45);
            this.nudPannoHeight.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPannoHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPannoHeight.Name = "nudPannoHeight";
            this.nudPannoHeight.Size = new System.Drawing.Size(51, 20);
            this.nudPannoHeight.TabIndex = 14;
            this.nudPannoHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPannoHeight.ValueChanged += new System.EventHandler(this.nudPannoHeight_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "_width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "_height:";
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(149, 58);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(513, 495);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 28;
            this.pictureBox.TabStop = false;
            this.pictureBox.WaitOnLoad = true;
            this.pictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDoubleClick_1);
            // 
            // tsMain
            // 
            this.tsMain.Dock = System.Windows.Forms.DockStyle.None;
            this.tsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnOpen,
            this.btnSave,
            this.btnPrint,
            this.btnHelp});
            this.tsMain.Location = new System.Drawing.Point(3, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(132, 27);
            this.tsMain.TabIndex = 32;
            this.tsMain.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(24, 24);
            this.btnNew.Text = "Просмотр ";
            this.btnNew.ToolTipText = "Предварительный просмотр панно по листам";
            // 
            // btnOpen
            // 
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(24, 24);
            this.btnOpen.Text = "Палитра";
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(24, 24);
            this.btnSave.Text = "Сохранить панно";
            // 
            // btnPrint
            // 
            this.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(24, 24);
            this.btnPrint.Text = "Печать панно по листам";
            // 
            // btnHelp
            // 
            this.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(24, 24);
            this.btnHelp.Text = "toolStripButton1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 560);
            this.Controls.Add(this.toolStripContainer);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "_mosaicTiles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.ContentPanel.PerformLayout();
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMY)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGap)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTileWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTileHeight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPannoWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPannoHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog dlgOpenFile;
		private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.NumericUpDown nudGap;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ListBox lbPalettes;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnImage;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox chkSquare;
		private System.Windows.Forms.NumericUpDown nudTileWidth;
		private System.Windows.Forms.NumericUpDown nudTileHeight;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown nudPannoWidth;
		private System.Windows.Forms.NumericUpDown nudPannoHeight;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.ToolStrip tsMain;
		private System.Windows.Forms.ToolStripButton btnPrint;
		private System.Windows.Forms.ToolStripButton btnNew;
		private System.Windows.Forms.ToolStripButton btnSave;
		private System.Windows.Forms.ToolStripButton btnOpen;
		private System.Windows.Forms.ToolStripButton btnHelp;
		private System.Windows.Forms.Button btnGapColor;
		private System.Windows.Forms.Label lblGapColor;
		private System.Windows.Forms.ColorDialog dlgColor;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.NumericUpDown nudMX;
		private System.Windows.Forms.NumericUpDown nudMY;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblFilePath;
		private System.Windows.Forms.Button btnGridColor;
		private System.Windows.Forms.Label lblGridColor;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnAbout;
		private System.Windows.Forms.Button buttonChange;
	}
}

