namespace OnlineMusicStore.UI.SongForms
{
	partial class ManageSongsForm
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
			this.DeleteSongButton = new System.Windows.Forms.Button();
			this.EditSongButton = new System.Windows.Forms.Button();
			this.AddSongButton = new System.Windows.Forms.Button();
			this.SearchButton = new System.Windows.Forms.Button();
			this.SearchInput = new System.Windows.Forms.TextBox();
			this.NameLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.SongsGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// SongsGridView
			// 
			this.SongsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.SongsGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.SongsGridView.Location = new System.Drawing.Point(0, 63);
			this.SongsGridView.Name = "SongsGridView";
			this.SongsGridView.Size = new System.Drawing.Size(800, 387);
			this.SongsGridView.TabIndex = 0;
			// 
			// DeleteSongButton
			// 
			this.DeleteSongButton.Location = new System.Drawing.Point(539, 21);
			this.DeleteSongButton.Name = "DeleteSongButton";
			this.DeleteSongButton.Size = new System.Drawing.Size(85, 23);
			this.DeleteSongButton.TabIndex = 19;
			this.DeleteSongButton.Text = "Delete Song";
			this.DeleteSongButton.UseVisualStyleBackColor = true;
			this.DeleteSongButton.Click += new System.EventHandler(this.DeleteSongButton_Click);
			// 
			// EditSongButton
			// 
			this.EditSongButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.EditSongButton.Location = new System.Drawing.Point(630, 21);
			this.EditSongButton.Name = "EditSongButton";
			this.EditSongButton.Size = new System.Drawing.Size(75, 23);
			this.EditSongButton.TabIndex = 18;
			this.EditSongButton.Text = "Edit Song";
			this.EditSongButton.UseVisualStyleBackColor = true;
			this.EditSongButton.Click += new System.EventHandler(this.EditSongButton_Click);
			// 
			// AddSongButton
			// 
			this.AddSongButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddSongButton.Location = new System.Drawing.Point(711, 21);
			this.AddSongButton.Name = "AddSongButton";
			this.AddSongButton.Size = new System.Drawing.Size(75, 23);
			this.AddSongButton.TabIndex = 17;
			this.AddSongButton.Text = "Add Song";
			this.AddSongButton.UseVisualStyleBackColor = true;
			this.AddSongButton.Click += new System.EventHandler(this.AddSongButton_Click);
			// 
			// SearchButton
			// 
			this.SearchButton.Location = new System.Drawing.Point(218, 21);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(75, 23);
			this.SearchButton.TabIndex = 22;
			this.SearchButton.Text = "Search";
			this.SearchButton.UseVisualStyleBackColor = true;
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// SearchInput
			// 
			this.SearchInput.Location = new System.Drawing.Point(56, 23);
			this.SearchInput.Name = "SearchInput";
			this.SearchInput.Size = new System.Drawing.Size(156, 20);
			this.SearchInput.TabIndex = 21;
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(15, 26);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(35, 13);
			this.NameLabel.TabIndex = 20;
			this.NameLabel.Text = "Name";
			// 
			// ManageSongsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.SearchButton);
			this.Controls.Add(this.SearchInput);
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.DeleteSongButton);
			this.Controls.Add(this.EditSongButton);
			this.Controls.Add(this.AddSongButton);
			this.Controls.Add(this.SongsGridView);
			this.Name = "ManageSongsForm";
			this.Text = "ManageSongsForm";
			this.Load += new System.EventHandler(this.ManageSongsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.SongsGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView SongsGridView;
		private System.Windows.Forms.Button DeleteSongButton;
		private System.Windows.Forms.Button EditSongButton;
		private System.Windows.Forms.Button AddSongButton;
		private System.Windows.Forms.Button SearchButton;
		private System.Windows.Forms.TextBox SearchInput;
		private System.Windows.Forms.Label NameLabel;
	}
}