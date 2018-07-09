namespace OnlineMusicStore.UI
{
	partial class AdminMainForm
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
			this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manageArtistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manageGenresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manageAlbumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manageSongsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1070, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUsersToolStripMenuItem,
            this.manageArtistsToolStripMenuItem,
            this.manageGenresToolStripMenuItem,
            this.manageAlbumsToolStripMenuItem,
            this.manageSongsToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// manageUsersToolStripMenuItem
			// 
			this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
			this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.manageUsersToolStripMenuItem.Text = "Manage Users";
			this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
			// 
			// manageArtistsToolStripMenuItem
			// 
			this.manageArtistsToolStripMenuItem.Name = "manageArtistsToolStripMenuItem";
			this.manageArtistsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.manageArtistsToolStripMenuItem.Text = "Manage Artists";
			this.manageArtistsToolStripMenuItem.Click += new System.EventHandler(this.manageArtistsToolStripMenuItem_Click);
			// 
			// manageGenresToolStripMenuItem
			// 
			this.manageGenresToolStripMenuItem.Name = "manageGenresToolStripMenuItem";
			this.manageGenresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.manageGenresToolStripMenuItem.Text = "Manage Genres";
			this.manageGenresToolStripMenuItem.Click += new System.EventHandler(this.manageGenresToolStripMenuItem_Click);
			// 
			// manageAlbumsToolStripMenuItem
			// 
			this.manageAlbumsToolStripMenuItem.Name = "manageAlbumsToolStripMenuItem";
			this.manageAlbumsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.manageAlbumsToolStripMenuItem.Text = "Manage Albums";
			this.manageAlbumsToolStripMenuItem.Click += new System.EventHandler(this.manageAlbumsToolStripMenuItem_Click);
			// 
			// manageSongsToolStripMenuItem
			// 
			this.manageSongsToolStripMenuItem.Name = "manageSongsToolStripMenuItem";
			this.manageSongsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.manageSongsToolStripMenuItem.Text = "Manage Songs";
			this.manageSongsToolStripMenuItem.Click += new System.EventHandler(this.manageSongsToolStripMenuItem_Click);
			// 
			// AdminMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1070, 616);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AdminMainForm";
			this.ShowIcon = false;
			this.Text = "Online Music Store";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem manageArtistsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem manageGenresToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem manageAlbumsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem manageSongsToolStripMenuItem;
	}
}