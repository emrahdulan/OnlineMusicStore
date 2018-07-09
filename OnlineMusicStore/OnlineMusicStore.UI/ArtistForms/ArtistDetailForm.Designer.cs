namespace OnlineMusicStore.UI.ArtistForms
{
	partial class ArtistDetailForm
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
			this.AlbumsGridView = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.AlbumsGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// ArtistNameLabel
			// 
			this.ArtistNameLabel.AutoSize = true;
			this.ArtistNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ArtistNameLabel.Location = new System.Drawing.Point(12, 9);
			this.ArtistNameLabel.Name = "ArtistNameLabel";
			this.ArtistNameLabel.Size = new System.Drawing.Size(0, 31);
			this.ArtistNameLabel.TabIndex = 0;
			// 
			// AlbumsGridView
			// 
			this.AlbumsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.AlbumsGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.AlbumsGridView.Location = new System.Drawing.Point(0, 43);
			this.AlbumsGridView.Name = "AlbumsGridView";
			this.AlbumsGridView.Size = new System.Drawing.Size(800, 407);
			this.AlbumsGridView.TabIndex = 1;
			// 
			// ArtistDetailForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.AlbumsGridView);
			this.Controls.Add(this.ArtistNameLabel);
			this.Name = "ArtistDetailForm";
			this.Text = "ArtistDetailForm";
			((System.ComponentModel.ISupportInitialize)(this.AlbumsGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label ArtistNameLabel;
		private System.Windows.Forms.DataGridView AlbumsGridView;
	}
}