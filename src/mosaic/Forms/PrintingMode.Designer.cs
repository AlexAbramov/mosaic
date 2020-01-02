namespace Mosaic
{
	partial class PrintingMode
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
            this.textBoxMRS = new System.Windows.Forms.TextBox();
            this.textBoxMB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxLP = new System.Windows.Forms.CheckBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxMRS
            // 
            this.textBoxMRS.Location = new System.Drawing.Point(270, 12);
            this.textBoxMRS.Name = "textBoxMRS";
            this.textBoxMRS.Size = new System.Drawing.Size(100, 20);
            this.textBoxMRS.TabIndex = 0;
            this.textBoxMRS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxMB
            // 
            this.textBoxMB.Location = new System.Drawing.Point(270, 38);
            this.textBoxMB.Name = "textBoxMB";
            this.textBoxMB.Size = new System.Drawing.Size(100, 20);
            this.textBoxMB.TabIndex = 1;
            this.textBoxMB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "_sheetPrintingSize:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "_sheetPrintingGap:";
            // 
            // checkBoxLP
            // 
            this.checkBoxLP.AutoSize = true;
            this.checkBoxLP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBoxLP.Location = new System.Drawing.Point(15, 68);
            this.checkBoxLP.Name = "checkBoxLP";
            this.checkBoxLP.Size = new System.Drawing.Size(93, 17);
            this.checkBoxLP.TabIndex = 4;
            this.checkBoxLP.Text = "_printTileColor";
            this.checkBoxLP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxLP.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(235, 159);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "_save";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(316, 159);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "_cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(86, 98);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(40, 34);
            this.buttonColor.TabIndex = 7;
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "_lineColor:";
            // 
            // PrintingMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 194);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.checkBoxLP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMB);
            this.Controls.Add(this.textBoxMRS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PrintingMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "_matrixPrintMode";
            this.Load += new System.EventHandler(this.PrintingMode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxMRS;
		private System.Windows.Forms.TextBox textBoxMB;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBoxLP;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonColor;
		private System.Windows.Forms.Label label3;
	}
}