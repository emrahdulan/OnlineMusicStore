namespace OnlineMusicStore.UI.ArtistForms
{
	partial class AddArtistForm
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
			this.ArtistNameLabel = new System.Windows.Forms.Label();
			this.ArtistNameInput = new System.Windows.Forms.TextBox();
			this.SaveButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ArtistNameLabel
			// 
			this.ArtistNameLabel.AutoSize = true;
			this.ArtistNameLabel.Location = new System.Drawing.Point(26, 26);
			this.ArtistNameLabel.Name = "ArtistNameLabel";
			this.ArtistNameLabel.Size = new System.Drawing.Size(61, 13);
			this.ArtistNameLabel.TabIndex = 0;
			this.ArtistNameLabel.Text = "Artist Name";
			// 
			// ArtistNameInput
			// 
			this.ArtistNameInput.Location = new System.Drawing.Point(93, 23);
			this.ArtistNameInput.Name = "ArtistNameInput";
			this.ArtistNameInput.Size = new System.Drawing.Size(226, 20);
			this.ArtistNameInput.TabIndex = 1;
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(244, 66);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 23);
			this.SaveButton.TabIndex = 2;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// AddArtistForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(339, 109);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.ArtistNameInput);
			this.Controls.Add(this.ArtistNameLabel);
			this.Name = "AddArtistForm";
			this.Text = "AddArtistForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label ArtistNameLabel;
		private System.Windows.Forms.TextBox ArtistNameInput;
		private System.Windows.Forms.Button SaveButton;
	}
}