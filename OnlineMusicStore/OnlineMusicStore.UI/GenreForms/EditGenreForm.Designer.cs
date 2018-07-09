namespace OnlineMusicStore.UI.GenreForms
{
	partial class EditGenreForm
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
			this.GenreDescriptionInput = new System.Windows.Forms.TextBox();
			this.GenreNameInput = new System.Windows.Forms.TextBox();
			this.GenreDescriptionLabel = new System.Windows.Forms.Label();
			this.GenreNameLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(232, 145);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 23);
			this.SaveButton.TabIndex = 9;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// GenreDescriptionInput
			// 
			this.GenreDescriptionInput.Location = new System.Drawing.Point(108, 63);
			this.GenreDescriptionInput.Multiline = true;
			this.GenreDescriptionInput.Name = "GenreDescriptionInput";
			this.GenreDescriptionInput.Size = new System.Drawing.Size(199, 67);
			this.GenreDescriptionInput.TabIndex = 8;
			// 
			// GenreNameInput
			// 
			this.GenreNameInput.Location = new System.Drawing.Point(108, 34);
			this.GenreNameInput.Name = "GenreNameInput";
			this.GenreNameInput.Size = new System.Drawing.Size(199, 20);
			this.GenreNameInput.TabIndex = 7;
			// 
			// GenreDescriptionLabel
			// 
			this.GenreDescriptionLabel.AutoSize = true;
			this.GenreDescriptionLabel.Location = new System.Drawing.Point(10, 66);
			this.GenreDescriptionLabel.Name = "GenreDescriptionLabel";
			this.GenreDescriptionLabel.Size = new System.Drawing.Size(92, 13);
			this.GenreDescriptionLabel.TabIndex = 6;
			this.GenreDescriptionLabel.Text = "Genre Description";
			// 
			// GenreNameLabel
			// 
			this.GenreNameLabel.AutoSize = true;
			this.GenreNameLabel.Location = new System.Drawing.Point(35, 37);
			this.GenreNameLabel.Name = "GenreNameLabel";
			this.GenreNameLabel.Size = new System.Drawing.Size(67, 13);
			this.GenreNameLabel.TabIndex = 5;
			this.GenreNameLabel.Text = "Genre Name";
			// 
			// EditGenreForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(326, 180);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.GenreDescriptionInput);
			this.Controls.Add(this.GenreNameInput);
			this.Controls.Add(this.GenreDescriptionLabel);
			this.Controls.Add(this.GenreNameLabel);
			this.Name = "EditGenreForm";
			this.Text = "EditGenreForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.TextBox GenreDescriptionInput;
		private System.Windows.Forms.TextBox GenreNameInput;
		private System.Windows.Forms.Label GenreDescriptionLabel;
		private System.Windows.Forms.Label GenreNameLabel;
	}
}