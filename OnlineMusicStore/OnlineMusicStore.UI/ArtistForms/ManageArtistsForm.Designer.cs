namespace OnlineMusicStore.UI.ArtistForms
{
	partial class ManageArtistsForm
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
			this.ArtistGridView = new System.Windows.Forms.DataGridView();
			this.SearchButton = new System.Windows.Forms.Button();
			this.SearchInput = new System.Windows.Forms.TextBox();
			this.NameLabel = new System.Windows.Forms.Label();
			this.EditArtistButton = new System.Windows.Forms.Button();
			this.AddArtistButton = new System.Windows.Forms.Button();
			this.DeleteArtistButton = new System.Windows.Forms.Button();
			this.DetailsButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ArtistGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// ArtistGridView
			// 
			this.ArtistGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ArtistGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ArtistGridView.Location = new System.Drawing.Point(0, 73);
			this.ArtistGridView.Name = "ArtistGridView";
			this.ArtistGridView.Size = new System.Drawing.Size(800, 377);
			this.ArtistGridView.TabIndex = 0;
			// 
			// SearchButton
			// 
			this.SearchButton.Location = new System.Drawing.Point(215, 24);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(75, 23);
			this.SearchButton.TabIndex = 11;
			this.SearchButton.Text = "Search";
			this.SearchButton.UseVisualStyleBackColor = true;
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// SearchInput
			// 
			this.SearchInput.Location = new System.Drawing.Point(53, 26);
			this.SearchInput.Name = "SearchInput";
			this.SearchInput.Size = new System.Drawing.Size(156, 20);
			this.SearchInput.TabIndex = 10;
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(12, 29);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(35, 13);
			this.NameLabel.TabIndex = 9;
			this.NameLabel.Text = "Name";
			// 
			// EditArtistButton
			// 
			this.EditArtistButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.EditArtistButton.Location = new System.Drawing.Point(632, 24);
			this.EditArtistButton.Name = "EditArtistButton";
			this.EditArtistButton.Size = new System.Drawing.Size(75, 23);
			this.EditArtistButton.TabIndex = 8;
			this.EditArtistButton.Text = "Edit Artist";
			this.EditArtistButton.UseVisualStyleBackColor = true;
			this.EditArtistButton.Click += new System.EventHandler(this.EditArtistButton_Click);
			// 
			// AddArtistButton
			// 
			this.AddArtistButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddArtistButton.Location = new System.Drawing.Point(713, 24);
			this.AddArtistButton.Name = "AddArtistButton";
			this.AddArtistButton.Size = new System.Drawing.Size(75, 23);
			this.AddArtistButton.TabIndex = 7;
			this.AddArtistButton.Text = "Add Artist";
			this.AddArtistButton.UseVisualStyleBackColor = true;
			this.AddArtistButton.Click += new System.EventHandler(this.AddArtistButton_Click);
			// 
			// DeleteArtistButton
			// 
			this.DeleteArtistButton.Location = new System.Drawing.Point(551, 24);
			this.DeleteArtistButton.Name = "DeleteArtistButton";
			this.DeleteArtistButton.Size = new System.Drawing.Size(75, 23);
			this.DeleteArtistButton.TabIndex = 12;
			this.DeleteArtistButton.Text = "Delete Artist";
			this.DeleteArtistButton.UseVisualStyleBackColor = true;
			this.DeleteArtistButton.Click += new System.EventHandler(this.DeleteArtistButton_Click);
			// 
			// DetailsButton
			// 
			this.DetailsButton.Location = new System.Drawing.Point(469, 24);
			this.DetailsButton.Name = "DetailsButton";
			this.DetailsButton.Size = new System.Drawing.Size(76, 23);
			this.DetailsButton.TabIndex = 13;
			this.DetailsButton.Text = "Details";
			this.DetailsButton.UseVisualStyleBackColor = true;
			this.DetailsButton.Click += new System.EventHandler(this.DetailsButton_Click);
			// 
			// ManageArtistsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.DetailsButton);
			this.Controls.Add(this.DeleteArtistButton);
			this.Controls.Add(this.SearchButton);
			this.Controls.Add(this.SearchInput);
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.EditArtistButton);
			this.Controls.Add(this.AddArtistButton);
			this.Controls.Add(this.ArtistGridView);
			this.Name = "ManageArtistsForm";
			this.Text = "ManageArtistForm";
			this.Load += new System.EventHandler(this.ManageArtistForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.ArtistGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView ArtistGridView;
		private System.Windows.Forms.Button SearchButton;
		private System.Windows.Forms.TextBox SearchInput;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.Button EditArtistButton;
		private System.Windows.Forms.Button AddArtistButton;
		private System.Windows.Forms.Button DeleteArtistButton;
		private System.Windows.Forms.Button DetailsButton;
	}
}