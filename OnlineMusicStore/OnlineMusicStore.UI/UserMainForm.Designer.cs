namespace OnlineMusicStore.UI
{
	partial class UserMainForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.browseAlbumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.myOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1004, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseAlbumsToolStripMenuItem,
            this.myOrdersToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// browseAlbumsToolStripMenuItem
			// 
			this.browseAlbumsToolStripMenuItem.Name = "browseAlbumsToolStripMenuItem";
			this.browseAlbumsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.browseAlbumsToolStripMenuItem.Text = "Browse Albums";
			this.browseAlbumsToolStripMenuItem.Click += new System.EventHandler(this.browseAlbumsToolStripMenuItem_Click);
			// 
			// myOrdersToolStripMenuItem
			// 
			this.myOrdersToolStripMenuItem.Name = "myOrdersToolStripMenuItem";
			this.myOrdersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.myOrdersToolStripMenuItem.Text = "My Orders";
			this.myOrdersToolStripMenuItem.Click += new System.EventHandler(this.myOrdersToolStripMenuItem_Click);
			// 
			// UserMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1004, 588);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UserMainForm";
			this.ShowIcon = false;
			this.Text = "UserMainForm";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem browseAlbumsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem myOrdersToolStripMenuItem;
	}
}