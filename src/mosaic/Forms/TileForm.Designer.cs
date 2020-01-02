namespace Mosaic
{
	partial class TileForm
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
			if( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.btnChange = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.chColor = new System.Windows.Forms.ColumnHeader();
            this.chName = new System.Windows.Forms.ColumnHeader();
            this.chCnt = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChange.Location = new System.Drawing.Point(0, 407);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(98, 23);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "_change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Location = new System.Drawing.Point(98, 407);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "_close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chColor,
            this.chName,
            this.chCnt});
            this.listView.FullRowSelect = true;
            this.listView.LabelEdit = true;
            this.listView.Location = new System.Drawing.Point(0, 3);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.ShowGroups = false;
            this.listView.Size = new System.Drawing.Size(200, 398);
            this.listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView.TabIndex = 11;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
            this.listView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_KeyDown);
            // 
            // chColor
            // 
            this.chColor.Text = "_color";
            this.chColor.Width = 50;
            // 
            // chName
            // 
            this.chName.Text = "_name";
            this.chName.Width = 70;
            // 
            // chCnt
            // 
            this.chCnt.Text = "_count";
            this.chCnt.Width = 75;
            // 
            // TileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 430);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "TileForm";
            this.Text = "_changeColor";
            this.Load += new System.EventHandler(this.TileForm_Load);
            this.Shown += new System.EventHandler(this.ChangeTile_Shown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ChangeTile_KeyUp);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChangeTile_KeyDown);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnChange;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.ListView listView;
		private System.Windows.Forms.ColumnHeader chColor;
		private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chCnt;
	}
}