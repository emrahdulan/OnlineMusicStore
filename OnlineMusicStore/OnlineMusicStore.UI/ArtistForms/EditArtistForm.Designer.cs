namespace OnlineMusicStore.UI.ArtistForms
{
	partial class EditArtistForm
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
			this.ArtistNameInput = new System.Windows.Forms.TextBox();
			this.ArtistNameLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(236, 66);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 23);
			this.SaveButton.TabIndex = 5;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// ArtistNameInput
			// 
			this.ArtistNameInput.Location = new System.Drawing.Point(85, 22);
			this.ArtistNameInput.Name = "ArtistNameInput";
			this.ArtistNameInput.Size = new System.Drawing.Size(226, 20);
			this.ArtistNameInput.TabIndex = 4;
			// 
			// ArtistNameLabel
			// 
			this.ArtistNameLabel.AutoSize = true;
			this.ArtistNameLabel.Location = new System.Drawing.Point(18, 25);
			this.ArtistNameLabel.Name = "ArtistNameLabel";
			this.ArtistNameLabel.Size = new System.Drawing.Size(61, 13);
			this.ArtistNameLabel.TabIndex = 3;
			this.ArtistNameLabel.Text = "Artist Name";
			// 
			// EditArtistForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(336, 101);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.ArtistNameInput);
			this.Controls.Add(this.ArtistNameLabel);
			this.Name = "EditArtistForm";
			this.Text = "EditArtistForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.TextBox ArtistNameInput;
		private System.Windows.Forms.Label ArtistNameLabel;
	}
}