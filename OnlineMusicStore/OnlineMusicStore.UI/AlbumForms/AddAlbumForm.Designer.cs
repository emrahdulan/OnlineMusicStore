namespace OnlineMusicStore.UI.AlbumForms
{
	partial class AddAlbumForm
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
			this.ArtistLabel = new System.Windows.Forms.Label();
			this.GenreLabel = new System.Windows.Forms.Label();
			this.AlbumTitleLabel = new System.Windows.Forms.Label();
			this.AlbumPriceLabel = new System.Windows.Forms.Label();
			this.ArtistComboBox = new System.Windows.Forms.ComboBox();
			this.AlbumTitleInput = new System.Windows.Forms.TextBox();
			this.AlbumPriceInput = new System.Windows.Forms.TextBox();
			this.SaveButton = new System.Windows.Forms.Button();
			this.GenreComboBox = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// ArtistLabel
			// 
			this.ArtistLabel.AutoSize = true;
			this.ArtistLabel.Location = new System.Drawing.Point(46, 44);
			this.ArtistLabel.Name = "ArtistLabel";
			this.ArtistLabel.Size = new System.Drawing.Size(30, 13);
			this.ArtistLabel.TabIndex = 0;
			this.ArtistLabel.Text = "Artist";
			// 
			// GenreLabel
			// 
			this.GenreLabel.AutoSize = true;
			this.GenreLabel.Location = new System.Drawing.Point(40, 67);
			this.GenreLabel.Name = "GenreLabel";
			this.GenreLabel.Size = new System.Drawing.Size(36, 13);
			this.GenreLabel.TabIndex = 1;
			this.GenreLabel.Text = "Genre";
			// 
			// AlbumTitleLabel
			// 
			this.AlbumTitleLabel.AutoSize = true;
			this.AlbumTitleLabel.Location = new System.Drawing.Point(17, 90);
			this.AlbumTitleLabel.Name = "AlbumTitleLabel";
			this.AlbumTitleLabel.Size = new System.Drawing.Size(59, 13);
			this.AlbumTitleLabel.TabIndex = 2;
			this.AlbumTitleLabel.Text = "Album Title";
			// 
			// AlbumPriceLabel
			// 
			this.AlbumPriceLabel.AutoSize = true;
			this.AlbumPriceLabel.Location = new System.Drawing.Point(13, 113);
			this.AlbumPriceLabel.Name = "AlbumPriceLabel";
			this.AlbumPriceLabel.Size = new System.Drawing.Size(63, 13);
			this.AlbumPriceLabel.TabIndex = 3;
			this.AlbumPriceLabel.Text = "Album Price";
			// 
			// ArtistComboBox
			// 
			this.ArtistComboBox.FormattingEnabled = true;
			this.ArtistComboBox.Location = new System.Drawing.Point(82, 41);
			this.ArtistComboBox.Name = "ArtistComboBox";
			this.ArtistComboBox.Size = new System.Drawing.Size(213, 21);
			this.ArtistComboBox.TabIndex = 4;
			// 
			// AlbumTitleInput
			// 
			this.AlbumTitleInput.Location = new System.Drawing.Point(82, 87);
			this.AlbumTitleInput.Name = "AlbumTitleInput";
			this.AlbumTitleInput.Size = new System.Drawing.Size(213, 20);
			this.AlbumTitleInput.TabIndex = 6;
			// 
			// AlbumPriceInput
			// 
			this.AlbumPriceInput.Location = new System.Drawing.Point(82, 110);
			this.AlbumPriceInput.Name = "AlbumPriceInput";
			this.AlbumPriceInput.Size = new System.Drawing.Size(213, 20);
			this.AlbumPriceInput.TabIndex = 7;
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(220, 136);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 23);
			this.SaveButton.TabIndex = 8;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// GenreComboBox
			// 
			this.GenreComboBox.FormattingEnabled = true;
			this.GenreComboBox.Location = new System.Drawing.Point(82, 64);
			this.GenreComboBox.Name = "GenreComboBox";
			this.GenreComboBox.Size = new System.Drawing.Size(213, 21);
			this.GenreComboBox.TabIndex = 5;
			// 
			// AddAlbumForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(308, 170);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.AlbumPriceInput);
			this.Controls.Add(this.AlbumTitleInput);
			this.Controls.Add(this.GenreComboBox);
			this.Controls.Add(this.ArtistComboBox);
			this.Controls.Add(this.AlbumPriceLabel);
			this.Controls.Add(this.AlbumTitleLabel);
			this.Controls.Add(this.GenreLabel);
			this.Controls.Add(this.ArtistLabel);
			this.Name = "AddAlbumForm";
			this.Text = "AddAlbumForm";
			this.Load += new System.EventHandler(this.AddAlbumForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label ArtistLabel;
		private System.Windows.Forms.Label GenreLabel;
		private System.Windows.Forms.Label AlbumTitleLabel;
		private System.Windows.Forms.Label AlbumPriceLabel;
		private System.Windows.Forms.ComboBox ArtistComboBox;
		private System.Windows.Forms.TextBox AlbumTitleInput;
		private System.Windows.Forms.TextBox AlbumPriceInput;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.ComboBox GenreComboBox;
	}
}