namespace OnlineMusicStore.UI.GenreForms
{
	partial class ManageGenresForm
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
			this.GenreGridView = new System.Windows.Forms.DataGridView();
			this.AddGenreButton = new System.Windows.Forms.Button();
			this.EditGenreButton = new System.Windows.Forms.Button();
			this.DeleteGenreButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.GenreGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// GenreGridView
			// 
			this.GenreGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GenreGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.GenreGridView.Location = new System.Drawing.Point(0, 69);
			this.GenreGridView.Name = "GenreGridView";
			this.GenreGridView.Size = new System.Drawing.Size(493, 381);
			this.GenreGridView.TabIndex = 0;
			// 
			// AddGenreButton
			// 
			this.AddGenreButton.Location = new System.Drawing.Point(406, 28);
			this.AddGenreButton.Name = "AddGenreButton";
			this.AddGenreButton.Size = new System.Drawing.Size(75, 23);
			this.AddGenreButton.TabIndex = 1;
			this.AddGenreButton.Text = "Add Genre";
			this.AddGenreButton.UseVisualStyleBackColor = true;
			this.AddGenreButton.Click += new System.EventHandler(this.AddGenreButton_Click);
			// 
			// EditGenreButton
			// 
			this.EditGenreButton.Location = new System.Drawing.Point(325, 28);
			this.EditGenreButton.Name = "EditGenreButton";
			this.EditGenreButton.Size = new System.Drawing.Size(75, 23);
			this.EditGenreButton.TabIndex = 2;
			this.EditGenreButton.Text = "Edit Genre";
			this.EditGenreButton.UseVisualStyleBackColor = true;
			this.EditGenreButton.Click += new System.EventHandler(this.EditGenreButton_Click);
			// 
			// DeleteGenreButton
			// 
			this.DeleteGenreButton.Location = new System.Drawing.Point(244, 28);
			this.DeleteGenreButton.Name = "DeleteGenreButton";
			this.DeleteGenreButton.Size = new System.Drawing.Size(75, 23);
			this.DeleteGenreButton.TabIndex = 3;
			this.DeleteGenreButton.Text = "Delete Genre";
			this.DeleteGenreButton.UseVisualStyleBackColor = true;
			this.DeleteGenreButton.Click += new System.EventHandler(this.DeleteGenreButton_Click);
			// 
			// MenageGenresForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(493, 450);
			this.Controls.Add(this.DeleteGenreButton);
			this.Controls.Add(this.EditGenreButton);
			this.Controls.Add(this.AddGenreButton);
			this.Controls.Add(this.GenreGridView);
			this.Name = "MenageGenresForm";
			this.Text = "MenageGenresForm";
			this.Load += new System.EventHandler(this.MenageGenresForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.GenreGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView GenreGridView;
		private System.Windows.Forms.Button AddGenreButton;
		private System.Windows.Forms.Button EditGenreButton;
		private System.Windows.Forms.Button DeleteGenreButton;
	}
}