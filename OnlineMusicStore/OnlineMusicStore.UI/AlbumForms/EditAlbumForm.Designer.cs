namespace OnlineMusicStore.UI.AlbumForms
{
	partial class EditAlbumForm
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
			this.AlbumPriceInput = new System.Windows.Forms.TextBox();
			this.AlbumTitleInput = new System.Windows.Forms.TextBox();
			this.AlbumPriceLabel = new System.Windows.Forms.Label();
			this.AlbumTitleLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(215, 81);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 23);
			this.SaveButton.TabIndex = 17;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// AlbumPriceInput
			// 
			this.AlbumPriceInput.Location = new System.Drawing.Point(77, 55);
			this.AlbumPriceInput.Name = "AlbumPriceInput";
			this.AlbumPriceInput.Size = new System.Drawing.Size(213, 20);
			this.AlbumPriceInput.TabIndex = 16;
			// 
			// AlbumTitleInput
			// 
			this.AlbumTitleInput.Location = new System.Drawing.Point(77, 32);
			this.AlbumTitleInput.Name = "AlbumTitleInput";
			this.AlbumTitleInput.Size = new System.Drawing.Size(213, 20);
			this.AlbumTitleInput.TabIndex = 15;
			// 
			// AlbumPriceLabel
			// 
			this.AlbumPriceLabel.AutoSize = true;
			this.AlbumPriceLabel.Location = new System.Drawing.Point(8, 58);
			this.AlbumPriceLabel.Name = "AlbumPriceLabel";
			this.AlbumPriceLabel.Size = new System.Drawing.Size(63, 13);
			this.AlbumPriceLabel.TabIndex = 12;
			this.AlbumPriceLabel.Text = "Album Price";
			// 
			// AlbumTitleLabel
			// 
			this.AlbumTitleLabel.AutoSize = true;
			this.AlbumTitleLabel.Location = new System.Drawing.Point(12, 35);
			this.AlbumTitleLabel.Name = "AlbumTitleLabel";
			this.AlbumTitleLabel.Size = new System.Drawing.Size(59, 13);
			this.AlbumTitleLabel.TabIndex = 11;
			this.AlbumTitleLabel.Text = "Album Title";
			// 
			// EditAlbumForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(304, 114);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.AlbumPriceInput);
			this.Controls.Add(this.AlbumTitleInput);
			this.Controls.Add(this.AlbumPriceLabel);
			this.Controls.Add(this.AlbumTitleLabel);
			this.Name = "EditAlbumForm";
			this.Text = "EditAlbumForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.TextBox AlbumPriceInput;
		private System.Windows.Forms.TextBox AlbumTitleInput;
		private System.Windows.Forms.Label AlbumPriceLabel;
		private System.Windows.Forms.Label AlbumTitleLabel;
	}
}