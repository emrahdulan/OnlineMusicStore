namespace OnlineMusicStore.UI.AlbumForms
{
	partial class ManageAlbumsForm
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
			this.AlbumsGridView = new System.Windows.Forms.DataGridView();
			this.DetailsButton = new System.Windows.Forms.Button();
			this.DeleteAlbumButton = new System.Windows.Forms.Button();
			this.EditAlbumButton = new System.Windows.Forms.Button();
			this.AddAlbumButton = new System.Windows.Forms.Button();
			this.SearchButton = new System.Windows.Forms.Button();
			this.SearchInput = new System.Windows.Forms.TextBox();
			this.NameLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.AlbumsGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// AlbumsGridView
			// 
			this.AlbumsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.AlbumsGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.AlbumsGridView.Location = new System.Drawing.Point(0, 69);
			this.AlbumsGridView.Name = "AlbumsGridView";
			this.AlbumsGridView.Size = new System.Drawing.Size(800, 381);
			this.AlbumsGridView.TabIndex = 0;
			// 
			// DetailsButton
			// 
			this.DetailsButton.Location = new System.Drawing.Point(461, 26);
			this.DetailsButton.Name = "DetailsButton";
			this.DetailsButton.Size = new System.Drawing.Size(76, 23);
			this.DetailsButton.TabIndex = 17;
			this.DetailsButton.Text = "Details";
			this.DetailsButton.UseVisualStyleBackColor = true;
			this.DetailsButton.Click += new System.EventHandler(this.DetailsButton_Click_1);
			// 
			// DeleteAlbumButton
			// 
			this.DeleteAlbumButton.Location = new System.Drawing.Point(543, 26);
			this.DeleteAlbumButton.Name = "DeleteAlbumButton";
			this.DeleteAlbumButton.Size = new System.Drawing.Size(85, 23);
			this.DeleteAlbumButton.TabIndex = 16;
			this.DeleteAlbumButton.Text = "Delete Album";
			this.DeleteAlbumButton.UseVisualStyleBackColor = true;
			this.DeleteAlbumButton.Click += new System.EventHandler(this.DeleteAlbumButton_Click_1);
			// 
			// EditAlbumButton
			// 
			this.EditAlbumButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.EditAlbumButton.Location = new System.Drawing.Point(634, 26);
			this.EditAlbumButton.Name = "EditAlbumButton";
			this.EditAlbumButton.Size = new System.Drawing.Size(75, 23);
			this.EditAlbumButton.TabIndex = 15;
			this.EditAlbumButton.Text = "Edit Album";
			this.EditAlbumButton.UseVisualStyleBackColor = true;
			this.EditAlbumButton.Click += new System.EventHandler(this.EditAlbumButton_Click_1);
			// 
			// AddAlbumButton
			// 
			this.AddAlbumButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddAlbumButton.Location = new System.Drawing.Point(715, 26);
			this.AddAlbumButton.Name = "AddAlbumButton";
			this.AddAlbumButton.Size = new System.Drawing.Size(75, 23);
			this.AddAlbumButton.TabIndex = 14;
			this.AddAlbumButton.Text = "Add Album";
			this.AddAlbumButton.UseVisualStyleBackColor = true;
			this.AddAlbumButton.Click += new System.EventHandler(this.AddAlbumButton_Click_1);
			// 
			// SearchButton
			// 
			this.SearchButton.Location = new System.Drawing.Point(225, 26);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(75, 23);
			this.SearchButton.TabIndex = 25;
			this.SearchButton.Text = "Search";
			this.SearchButton.UseVisualStyleBackColor = true;
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// SearchInput
			// 
			this.SearchInput.Location = new System.Drawing.Point(63, 28);
			this.SearchInput.Name = "SearchInput";
			this.SearchInput.Size = new System.Drawing.Size(156, 20);
			this.SearchInput.TabIndex = 24;
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(22, 31);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(35, 13);
			this.NameLabel.TabIndex = 23;
			this.NameLabel.Text = "Name";
			// 
			// ManageAlbumsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.SearchButton);
			this.Controls.Add(this.SearchInput);
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.DetailsButton);
			this.Controls.Add(this.DeleteAlbumButton);
			this.Controls.Add(this.EditAlbumButton);
			this.Controls.Add(this.AddAlbumButton);
			this.Controls.Add(this.AlbumsGridView);
			this.Name = "ManageAlbumsForm";
			this.Text = "ManageAlbumsForm";
			this.Load += new System.EventHandler(this.ManageAlbumsForm_Load_1);
			((System.ComponentModel.ISupportInitialize)(this.AlbumsGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView AlbumsGridView;
		private System.Windows.Forms.Button DetailsButton;
		private System.Windows.Forms.Button DeleteAlbumButton;
		private System.Windows.Forms.Button EditAlbumButton;
		private System.Windows.Forms.Button AddAlbumButton;
		private System.Windows.Forms.Button SearchButton;
		private System.Windows.Forms.TextBox SearchInput;
		private System.Windows.Forms.Label NameLabel;
	}
}