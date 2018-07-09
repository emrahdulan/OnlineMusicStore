namespace OnlineMusicStore.UI.GenreForms
{
	partial class AddGenreForm
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
			this.GenreNameLabel = new System.Windows.Forms.Label();
			this.GenreDescriptionLabel = new System.Windows.Forms.Label();
			this.GenreNameInput = new System.Windows.Forms.TextBox();
			this.GenreDescriptionInput = new System.Windows.Forms.TextBox();
			this.SaveButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// GenreNameLabel
			// 
			this.GenreNameLabel.AutoSize = true;
			this.GenreNameLabel.Location = new System.Drawing.Point(38, 35);
			this.GenreNameLabel.Name = "GenreNameLabel";
			this.GenreNameLabel.Size = new System.Drawing.Size(67, 13);
			this.GenreNameLabel.TabIndex = 0;
			this.GenreNameLabel.Text = "Genre Name";
			// 
			// GenreDescriptionLabel
			// 
			this.GenreDescriptionLabel.AutoSize = true;
			this.GenreDescriptionLabel.Location = new System.Drawing.Point(13, 64);
			this.GenreDescriptionLabel.Name = "GenreDescriptionLabel";
			this.GenreDescriptionLabel.Size = new System.Drawing.Size(92, 13);
			this.GenreDescriptionLabel.TabIndex = 1;
			this.GenreDescriptionLabel.Text = "Genre Description";
			// 
			// GenreNameInput
			// 
			this.GenreNameInput.Location = new System.Drawing.Point(111, 32);
			this.GenreNameInput.Name = "GenreNameInput";
			this.GenreNameInput.Size = new System.Drawing.Size(199, 20);
			this.GenreNameInput.TabIndex = 2;
			// 
			// GenreDescriptionInput
			// 
			this.GenreDescriptionInput.Location = new System.Drawing.Point(111, 61);
			this.GenreDescriptionInput.Multiline = true;
			this.GenreDescriptionInput.Name = "GenreDescriptionInput";
			this.GenreDescriptionInput.Size = new System.Drawing.Size(199, 67);
			this.GenreDescriptionInput.TabIndex = 3;
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(235, 143);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 23);
			this.SaveButton.TabIndex = 4;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// AddGenreForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(324, 177);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.GenreDescriptionInput);
			this.Controls.Add(this.GenreNameInput);
			this.Controls.Add(this.GenreDescriptionLabel);
			this.Controls.Add(this.GenreNameLabel);
			this.Name = "AddGenreForm";
			this.Text = "AddGenreForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label GenreNameLabel;
		private System.Windows.Forms.Label GenreDescriptionLabel;
		private System.Windows.Forms.TextBox GenreNameInput;
		private System.Windows.Forms.TextBox GenreDescriptionInput;
		private System.Windows.Forms.Button SaveButton;
	}
}