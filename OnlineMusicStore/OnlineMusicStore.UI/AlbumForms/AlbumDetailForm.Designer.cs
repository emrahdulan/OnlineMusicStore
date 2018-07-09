namespace OnlineMusicStore.UI.AlbumForms
{
	partial class AlbumDetailForm
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
			this.SongsGridView = new System.Windows.Forms.DataGridView();
			this.AlbumTitleLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.SongsGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// SongsGridView
			// 
			this.SongsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.SongsGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.SongsGridView.Location = new System.Drawing.Point(0, 45);
			this.SongsGridView.Name = "SongsGridView";
			this.SongsGridView.Size = new System.Drawing.Size(800, 405);
			this.SongsGridView.TabIndex = 0;
			// 
			// AlbumTitleLabel
			// 
			this.AlbumTitleLabel.AutoSize = true;
			this.AlbumTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.AlbumTitleLabel.Location = new System.Drawing.Point(13, 13);
			this.AlbumTitleLabel.Name = "AlbumTitleLabel";
			this.AlbumTitleLabel.Size = new System.Drawing.Size(0, 29);
			this.AlbumTitleLabel.TabIndex = 1;
			// 
			// AlbumDetailForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.AlbumTitleLabel);
			this.Controls.Add(this.SongsGridView);
			this.Name = "AlbumDetailForm";
			this.Text = "AlbumDetailForm";
			((System.ComponentModel.ISupportInitialize)(this.SongsGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView SongsGridView;
		private System.Windows.Forms.Label AlbumTitleLabel;
	}
}