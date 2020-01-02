namespace Mosaic
{
	partial class ChangeImageForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent( )
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeImageForm));
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.sbText = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbCoords = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsNavigation = new System.Windows.Forms.ToolStrip();
            this.btnScaleDown = new System.Windows.Forms.ToolStripButton();
            this.btnScaleUp = new System.Windows.Forms.ToolStripButton();
            this.btnLeft = new System.Windows.Forms.ToolStripButton();
            this.btnTop = new System.Windows.Forms.ToolStripButton();
            this.btnBottom = new System.Windows.Forms.ToolStripButton();
            this.btnRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.statusBar.SuspendLayout();
            this.tsNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbText,
            this.sbCoords});
            this.statusBar.Location = new System.Drawing.Point(0, 389);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(496, 22);
            this.statusBar.SizingGrip = false;
            this.statusBar.TabIndex = 27;
            this.statusBar.Text = "statusStrip1";
            // 
            // sbText
            // 
            this.sbText.Name = "sbText";
            this.sbText.Size = new System.Drawing.Size(38, 17);
            this.sbText.Text = "status";
            // 
            // sbCoords
            // 
            this.sbCoords.Name = "sbCoords";
            this.sbCoords.Size = new System.Drawing.Size(43, 17);
            this.sbCoords.Text = "coords";
            // 
            // tsNavigation
            // 
            this.tsNavigation.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsNavigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnScaleDown,
            this.btnScaleUp,
            this.btnLeft,
            this.btnTop,
            this.btnBottom,
            this.btnRight,
            this.toolStripSeparator1,
            this.btnSave,
            this.toolStripSeparator2,
            this.btnCancel,
            this.toolStripSeparator3});
            this.tsNavigation.Location = new System.Drawing.Point(0, 0);
            this.tsNavigation.Name = "tsNavigation";
            this.tsNavigation.Size = new System.Drawing.Size(496, 27);
            this.tsNavigation.TabIndex = 31;
            this.tsNavigation.Text = "toolStrip1";
            // 
            // btnScaleDown
            // 
            this.btnScaleDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnScaleDown.Image = ((System.Drawing.Image)(resources.GetObject("btnScaleDown.Image")));
            this.btnScaleDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnScaleDown.Name = "btnScaleDown";
            this.btnScaleDown.Size = new System.Drawing.Size(24, 24);
            this.btnScaleDown.Text = "toolStripButton1";
            this.btnScaleDown.ToolTipText = "_scaleDown";
            this.btnScaleDown.Click += new System.EventHandler(this.btnScaleDown_Click);
            // 
            // btnScaleUp
            // 
            this.btnScaleUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnScaleUp.Image = ((System.Drawing.Image)(resources.GetObject("btnScaleUp.Image")));
            this.btnScaleUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnScaleUp.Name = "btnScaleUp";
            this.btnScaleUp.Size = new System.Drawing.Size(24, 24);
            this.btnScaleUp.Text = "toolStripButton1";
            this.btnScaleUp.ToolTipText = "_scaleUp";
            this.btnScaleUp.Click += new System.EventHandler(this.btnScaleUp_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft.Image")));
            this.btnLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(24, 24);
            this.btnLeft.Text = "toolStripButton1";
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
            this.btnTop.Text = "toolStripButton2";
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
            this.btnBottom.Text = "toolStripButton3";
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
            this.btnRight.Text = "toolStripButton4";
            this.btnRight.ToolTipText = "_right";
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(39, 24);
            this.btnSave.Text = "_save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnCancel
            // 
            this.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 24);
            this.btnCancel.Text = "_cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // ChangeImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 411);
            this.Controls.Add(this.tsNavigation);
            this.Controls.Add(this.statusBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeImageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_selectRegion";
            this.Load += new System.EventHandler(this.ChangeImage_Load);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.tsNavigation.ResumeLayout(false);
            this.tsNavigation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.ToolStripStatusLabel sbText;
		private System.Windows.Forms.ToolStripStatusLabel sbCoords;
		private System.Windows.Forms.ToolStrip tsNavigation;
		private System.Windows.Forms.ToolStripButton btnScaleDown;
		private System.Windows.Forms.ToolStripButton btnScaleUp;
		private System.Windows.Forms.ToolStripButton btnLeft;
		private System.Windows.Forms.ToolStripButton btnTop;
		private System.Windows.Forms.ToolStripButton btnBottom;
		private System.Windows.Forms.ToolStripButton btnRight;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btnSave;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton btnCancel;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;


	}
}