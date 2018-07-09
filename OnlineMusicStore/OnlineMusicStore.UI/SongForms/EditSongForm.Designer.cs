namespace OnlineMusicStore.UI.SongForms
{
	partial class EditSongForm
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
			this.SaveButton = new System.Windows.Forms.Button();
			this.SongLyricInput = new System.Windows.Forms.TextBox();
			this.SongLyricLabel = new System.Windows.Forms.Label();
			this.SongDurationInput = new System.Windows.Forms.TextBox();
			this.SongTitleInput = new System.Windows.Forms.TextBox();
			this.SongDurationLabel = new System.Windows.Forms.Label();
			this.SongTitleLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(240, 185);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 23);
			this.SaveButton.TabIndex = 23;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// SongLyricInput
			// 
			this.SongLyricInput.Location = new System.Drawing.Point(102, 103);
			this.SongLyricInput.Multiline = true;
			this.SongLyricInput.Name = "SongLyricInput";
			this.SongLyricInput.Size = new System.Drawing.Size(213, 67);
			this.SongLyricInput.TabIndex = 22;
			// 
			// SongLyricLabel
			// 
			this.SongLyricLabel.AutoSize = true;
			this.SongLyricLabel.Location = new System.Drawing.Point(28, 106);
			this.SongLyricLabel.Name = "SongLyricLabel";
			this.SongLyricLabel.Size = new System.Drawing.Size(57, 13);
			this.SongLyricLabel.TabIndex = 21;
			this.SongLyricLabel.Text = "Song Lyric";
			// 
			// SongDurationInput
			// 
			this.SongDurationInput.Location = new System.Drawing.Point(102, 70);
			this.SongDurationInput.Name = "SongDurationInput";
			this.SongDurationInput.Size = new System.Drawing.Size(213, 20);
			this.SongDurationInput.TabIndex = 20;
			// 
			// SongTitleInput
			// 
			this.SongTitleInput.Location = new System.Drawing.Point(102, 37);
			this.SongTitleInput.Name = "SongTitleInput";
			this.SongTitleInput.Size = new System.Drawing.Size(213, 20);
			this.SongTitleInput.TabIndex = 19;
			// 
			// SongDurationLabel
			// 
			this.SongDurationLabel.AutoSize = true;
			this.SongDurationLabel.Location = new System.Drawing.Point(10, 73);
			this.SongDurationLabel.Name = "SongDurationLabel";
			this.SongDurationLabel.Size = new System.Drawing.Size(75, 13);
			this.SongDurationLabel.TabIndex = 18;
			this.SongDurationLabel.Text = "Song Duration";
			// 
			// SongTitleLabel
			// 
			this.SongTitleLabel.AutoSize = true;
			this.SongTitleLabel.Location = new System.Drawing.Point(30, 40);
			this.SongTitleLabel.Name = "SongTitleLabel";
			this.SongTitleLabel.Size = new System.Drawing.Size(55, 13);
			this.SongTitleLabel.TabIndex = 17;
			this.SongTitleLabel.Text = "Song Title";
			// 
			// EditSongForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(328, 221);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.SongLyricInput);
			this.Controls.Add(this.SongLyricLabel);
			this.Controls.Add(this.SongDurationInput);
			this.Controls.Add(this.SongTitleInput);
			this.Controls.Add(this.SongDurationLabel);
			this.Controls.Add(this.SongTitleLabel);
			this.Name = "EditSongForm";
			this.Text = "EditSongForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.TextBox SongLyricInput;
		private System.Windows.Forms.Label SongLyricLabel;
		private System.Windows.Forms.TextBox SongDurationInput;
		private System.Windows.Forms.TextBox SongTitleInput;
		private System.Windows.Forms.Label SongDurationLabel;
		private System.Windows.Forms.Label SongTitleLabel;
	}
}