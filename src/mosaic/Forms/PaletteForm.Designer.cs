namespace Mosaic
{
	partial class PaletteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaletteForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tbPaletteName = new System.Windows.Forms.TextBox();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.listView = new System.Windows.Forms.ListView();
            this.chColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblImagePath = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbColorName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxBlue = new System.Windows.Forms.TextBox();
            this.textBoxGreen = new System.Windows.Forms.TextBox();
            this.textBoxRed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnUnselect = new System.Windows.Forms.Button();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "_paletteName:";
            // 
            // tbPaletteName
            // 
            this.tbPaletteName.Location = new System.Drawing.Point(93, 12);
            this.tbPaletteName.Name = "tbPaletteName";
            this.tbPaletteName.Size = new System.Drawing.Size(147, 20);
            this.tbPaletteName.TabIndex = 1;
            this.tbPaletteName.TextChanged += new System.EventHandler(this.tbPaletteName_TextChanged);
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.Filter = "Графические файлы (*.bmp; *.gif; *.jpg; *.png)|*.bmp; *.gif; *.jpg; *.png; |Все ф" +
    "айлы|*.*";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 100);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView.CheckBoxes = true;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chColor,
            this.chName});
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.LabelWrap = false;
            this.listView.Location = new System.Drawing.Point(18, 65);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.ShowGroups = false;
            this.listView.Size = new System.Drawing.Size(228, 292);
            this.listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView.TabIndex = 10;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            this.listView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView_ItemChecked);
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // chColor
            // 
            this.chColor.Text = "_color";
            // 
            // chName
            // 
            this.chName.Text = "_name";
            this.chName.Width = 139;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.AutoSize = true;
            this.btnLoadImage.Location = new System.Drawing.Point(6, 19);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(100, 23);
            this.btnLoadImage.TabIndex = 11;
            this.btnLoadImage.Text = "_fromImage";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Location = new System.Drawing.Point(6, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 320);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblColor
            // 
            this.lblColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblColor.Location = new System.Drawing.Point(6, 15);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(110, 20);
            this.lblColor.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(6, 191);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "_add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Location = new System.Drawing.Point(12, 392);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(111, 23);
            this.btnRemove.TabIndex = 19;
            this.btnRemove.Text = "_remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblImagePath
            // 
            this.lblImagePath.AutoSize = true;
            this.lblImagePath.Location = new System.Drawing.Point(112, 24);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(68, 13);
            this.lblImagePath.TabIndex = 17;
            this.lblImagePath.Text = "lblImagePath";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "_name:";
            // 
            // tbColorName
            // 
            this.tbColorName.Location = new System.Drawing.Point(50, 43);
            this.tbColorName.Name = "tbColorName";
            this.tbColorName.Size = new System.Drawing.Size(98, 20);
            this.tbColorName.TabIndex = 21;
            this.tbColorName.TextChanged += new System.EventHandler(this.tbColorName_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnLoadImage);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.lblImagePath);
            this.groupBox1.Location = new System.Drawing.Point(406, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 374);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "_selectColor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "_colorChannels:";
            // 
            // textBoxBlue
            // 
            this.textBoxBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBlue.BackColor = System.Drawing.Color.White;
            this.textBoxBlue.ForeColor = System.Drawing.Color.Navy;
            this.textBoxBlue.Location = new System.Drawing.Point(112, 152);
            this.textBoxBlue.Name = "textBoxBlue";
            this.textBoxBlue.ReadOnly = true;
            this.textBoxBlue.Size = new System.Drawing.Size(36, 20);
            this.textBoxBlue.TabIndex = 28;
            // 
            // textBoxGreen
            // 
            this.textBoxGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGreen.BackColor = System.Drawing.Color.White;
            this.textBoxGreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBoxGreen.Location = new System.Drawing.Point(112, 126);
            this.textBoxGreen.Name = "textBoxGreen";
            this.textBoxGreen.ReadOnly = true;
            this.textBoxGreen.Size = new System.Drawing.Size(36, 20);
            this.textBoxGreen.TabIndex = 27;
            // 
            // textBoxRed
            // 
            this.textBoxRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRed.BackColor = System.Drawing.Color.White;
            this.textBoxRed.ForeColor = System.Drawing.Color.Red;
            this.textBoxRed.Location = new System.Drawing.Point(112, 100);
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.ReadOnly = true;
            this.textBoxRed.Size = new System.Drawing.Size(36, 20);
            this.textBoxRed.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "_blue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "_green";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "_red";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(536, 392);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 23;
            this.btnOk.Text = "_save";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(617, 392);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "_cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUp.Location = new System.Drawing.Point(129, 363);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(111, 23);
            this.btnUp.TabIndex = 26;
            this.btnUp.Text = "_top";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDown.Location = new System.Drawing.Point(129, 392);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(111, 23);
            this.btnDown.TabIndex = 27;
            this.btnDown.Text = "_bottom";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "_sorting:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbSort
            // 
            this.cbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "Default",
            "Name",
            "Color"});
            this.cbSort.Location = new System.Drawing.Point(93, 38);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(147, 21);
            this.cbSort.TabIndex = 29;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnColor);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.textBoxBlue);
            this.groupBox2.Controls.Add(this.lblColor);
            this.groupBox2.Controls.Add(this.textBoxGreen);
            this.groupBox2.Controls.Add(this.tbColorName);
            this.groupBox2.Controls.Add(this.textBoxRed);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(246, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 220);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "_color";
            // 
            // btnColor
            // 
            this.btnColor.AutoSize = true;
            this.btnColor.Location = new System.Drawing.Point(122, 14);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(26, 23);
            this.btnColor.TabIndex = 30;
            this.btnColor.Text = "...";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnUnselect
            // 
            this.btnUnselect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUnselect.Location = new System.Drawing.Point(12, 363);
            this.btnUnselect.Name = "btnUnselect";
            this.btnUnselect.Size = new System.Drawing.Size(111, 23);
            this.btnUnselect.TabIndex = 31;
            this.btnUnselect.Text = "_deselect";
            this.btnUnselect.UseVisualStyleBackColor = true;
            this.btnUnselect.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // PaletteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 427);
            this.Controls.Add(this.btnUnselect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.tbPaletteName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaletteForm";
            this.Text = "_palette";
            this.Load += new System.EventHandler(this.PaletteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbPaletteName;
		private System.Windows.Forms.OpenFileDialog dlgOpenFile;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.ListView listView;
		private System.Windows.Forms.ColumnHeader chName;
		private System.Windows.Forms.ColumnHeader chColor;
		private System.Windows.Forms.Button btnLoadImage;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblColor;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Label lblImagePath;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbColorName;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnUp;
		private System.Windows.Forms.Button btnDown;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxBlue;
        private System.Windows.Forms.TextBox textBoxGreen;
        private System.Windows.Forms.TextBox textBoxRed;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnColor;
		private System.Windows.Forms.ColorDialog dlgColor;
		private System.Windows.Forms.Button btnUnselect;
	}
}