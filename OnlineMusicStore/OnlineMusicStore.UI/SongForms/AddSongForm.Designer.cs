namespace OnlineMusicStore.UI.SongForms
{
	partial class AddSongForm
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
			this.SongDurationInput = new System.Windows.Forms.TextBox();
			this.SongTitleInput = new System.Windows.Forms.TextBox();
			this.AlbumComboBox = new System.Windows.Forms.ComboBox();
			this.SongDurationLabel = new System.Windows.Forms.Label();
			this.SongTitleLabel = new System.Windows.Forms.Label();
			this.AlbumLabel = new System.Windows.Forms.Label();
			this.SongLyricInput = new System.Windows.Forms.TextBox();
			this.SongLyricLabel = new System.Windows.Forms.Label();
			this.SaveButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// SongDurationInput
			// 
			this.SongDurationInput.Location = new System.Drawing.Point(99, 109);
			this.SongDurationInput.Name = "SongDurationInput";
			this.SongDurationInput.Size = new System.Drawing.Size(213, 20);
			this.SongDurationInput.TabIndex = 13;
			// 
			// SongTitleInput
			// 
			this.SongTitleInput.Location = new System.Drawing.Point(99, 76);
			this.SongTitleInput.Name = "SongTitleInput";
			this.SongTitleInput.Size = new System.Drawing.Size(213, 20);
			this.SongTitleInput.TabIndex = 12;
			// 
			// AlbumComboBox
			// 
			this.AlbumComboBox.FormattingEnabled = true;
			this.AlbumComboBox.Location = new System.Drawing.Point(99, 42);
			this.AlbumComboBox.Name = "AlbumComboBox";
			this.AlbumComboBox.Size = new System.Drawing.Size(213, 21);
			this.AlbumComboBox.TabIndex = 11;
			// 
			// SongDurationLabel
			// 
			this.SongDurationLabel.AutoSize = true;
			this.SongDurationLabel.Location = new System.Drawing.Point(7, 112);
			this.SongDurationLabel.Name = "SongDurationLabel";
			this.SongDurationLabel.Size = new System.Drawing.Size(75, 13);
			this.SongDurationLabel.TabIndex = 10;
			this.SongDurationLabel.Text = "Song Duration";
			// 
			// SongTitleLabel
			// 
			this.SongTitleLabel.AutoSize = true;
			this.SongTitleLabel.Location = new System.Drawing.Point(27, 79);
			this.SongTitleLabel.Name = "SongTitleLabel";
			this.SongTitleLabel.Size = new System.Drawing.Size(55, 13);
			this.SongTitleLabel.TabIndex = 9;
			this.SongTitleLabel.Text = "Song Title";
			// 
			// AlbumLabel
			// 
			this.AlbumLabel.AutoSize = true;
			this.AlbumLabel.Location = new System.Drawing.Point(46, 45);
			this.AlbumLabel.Name = "AlbumLabel";
			this.AlbumLabel.Size = new System.Drawing.Size(36, 13);
			this.AlbumLabel.TabIndex = 8;
			this.AlbumLabel.Text = "Album";
			// 
			// SongLyricInput
			// 
			this.SongLyricInput.Location = new System.Drawing.Point(99, 142);
			this.SongLyricInput.Multiline = true;
			this.SongLyricInput.Name = "SongLyricInput";
			this.SongLyricInput.Size = new System.Drawing.Size(213, 67);
			this.SongLyricInput.TabIndex = 15;
			// 
			// SongLyricLabel
			// 
			this.SongLyricLabel.AutoSize = true;
			this.SongLyricLabel.Location = new System.Drawing.Point(25, 145);
			this.SongLyricLabel.Name = "SongLyricLabel";
			this.SongLyricLabel.Size = new System.Drawing.Size(57, 13);
			this.SongLyricLabel.TabIndex = 14;
			this.SongLyricLabel.Text = "Song Lyric";
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(237, 224);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 23);
			this.SaveButton.TabIndex = 16;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// AddSongForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(327, 259);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.SongLyricInput);
			this.Controls.Add(this.SongLyricLabel);
			this.Controls.Add(this.SongDurationInput);
			this.Controls.Add(this.SongTitleInput);
			this.Controls.Add(this.AlbumComboBox);
			this.Controls.Add(this.SongDurationLabel);
			this.Controls.Add(this.SongTitleLabel);
			this.Controls.Add(this.AlbumLabel);
			this.Name = "AddSongForm";
			this.Text = "AddSongForm";
			this.Load += new System.EventHandler(this.AddSongForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox SongDurationInput;
		private System.Windows.Forms.TextBox SongTitleInput;
		private System.Windows.Forms.ComboBox AlbumComboBox;
		private System.Windows.Forms.Label SongDurationLabel;
		private System.Windows.Forms.Label SongTitleLabel;
		private System.Windows.Forms.Label AlbumLabel;
		private System.Windows.Forms.TextBox SongLyricInput;
		private System.Windows.Forms.Label SongLyricLabel;
		private System.Windows.Forms.Button SaveButton;
	}
}