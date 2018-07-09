namespace OnlineMusicStore.UI.AlbumForms
{
	partial class AlbumBrowserForm
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
			this.SearchButton = new System.Windows.Forms.Button();
			this.SearchInput = new System.Windows.Forms.TextBox();
			this.NameLabel = new System.Windows.Forms.Label();
			this.DetailsButton = new System.Windows.Forms.Button();
			this.AddToCartButton = new System.Windows.Forms.Button();
			this.CartButton = new System.Windows.Forms.Button();
			this.AlbumsGridView = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.AlbumsGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// SearchButton
			// 
			this.SearchButton.Location = new System.Drawing.Point(228, 23);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(75, 23);
			this.SearchButton.TabIndex = 32;
			this.SearchButton.Text = "Search";
			this.SearchButton.UseVisualStyleBackColor = true;
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// SearchInput
			// 
			this.SearchInput.Location = new System.Drawing.Point(66, 25);
			this.SearchInput.Name = "SearchInput";
			this.SearchInput.Size = new System.Drawing.Size(156, 20);
			this.SearchInput.TabIndex = 31;
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(25, 28);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(35, 13);
			this.NameLabel.TabIndex = 30;
			this.NameLabel.Text = "Name";
			// 
			// DetailsButton
			// 
			this.DetailsButton.Location = new System.Drawing.Point(821, 23);
			this.DetailsButton.Name = "DetailsButton";
			this.DetailsButton.Size = new System.Drawing.Size(76, 23);
			this.DetailsButton.TabIndex = 29;
			this.DetailsButton.Text = "Details";
			this.DetailsButton.UseVisualStyleBackColor = true;
			this.DetailsButton.Click += new System.EventHandler(this.DetailsButton_Click);
			// 
			// AddToCartButton
			// 
			this.AddToCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddToCartButton.Location = new System.Drawing.Point(903, 23);
			this.AddToCartButton.Name = "AddToCartButton";
			this.AddToCartButton.Size = new System.Drawing.Size(75, 23);
			this.AddToCartButton.TabIndex = 27;
			this.AddToCartButton.Text = "Add To Cart";
			this.AddToCartButton.UseVisualStyleBackColor = true;
			this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
			// 
			// CartButton
			// 
			this.CartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CartButton.Location = new System.Drawing.Point(984, 23);
			this.CartButton.Name = "CartButton";
			this.CartButton.Size = new System.Drawing.Size(75, 23);
			this.CartButton.TabIndex = 26;
			this.CartButton.Text = "Cart";
			this.CartButton.UseVisualStyleBackColor = true;
			this.CartButton.Click += new System.EventHandler(this.CartButton_Click);
			// 
			// AlbumsGridView
			// 
			this.AlbumsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.AlbumsGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.AlbumsGridView.Location = new System.Drawing.Point(0, 67);
			this.AlbumsGridView.Name = "AlbumsGridView";
			this.AlbumsGridView.Size = new System.Drawing.Size(1071, 555);
			this.AlbumsGridView.TabIndex = 33;
			// 
			// AlbumBrowserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1071, 622);
			this.Controls.Add(this.AlbumsGridView);
			this.Controls.Add(this.SearchButton);
			this.Controls.Add(this.SearchInput);
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.DetailsButton);
			this.Controls.Add(this.AddToCartButton);
			this.Controls.Add(this.CartButton);
			this.Name = "AlbumBrowserForm";
			this.Text = "AlbumBrowserForm";
			this.Load += new System.EventHandler(this.AlbumBrowserForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.AlbumsGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button SearchButton;
		private System.Windows.Forms.TextBox SearchInput;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.Button DetailsButton;
		private System.Windows.Forms.Button AddToCartButton;
		private System.Windows.Forms.Button CartButton;
		private System.Windows.Forms.DataGridView AlbumsGridView;
	}
}