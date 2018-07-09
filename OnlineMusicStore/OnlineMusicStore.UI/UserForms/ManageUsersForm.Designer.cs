namespace OnlineMusicStore.UI.UserForms
{
	partial class ManageUsersForm
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
			this.components = new System.ComponentModel.Container();
			this.UsersGridView = new System.Windows.Forms.DataGridView();
			this.AddUserButton = new System.Windows.Forms.Button();
			this.EditUserButton = new System.Windows.Forms.Button();
			this.NameLabel = new System.Windows.Forms.Label();
			this.SearchInput = new System.Windows.Forms.TextBox();
			this.SearchButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.UsersGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// UsersGridView
			// 
			this.UsersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.UsersGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.UsersGridView.Location = new System.Drawing.Point(0, 63);
			this.UsersGridView.MultiSelect = false;
			this.UsersGridView.Name = "UsersGridView";
			this.UsersGridView.Size = new System.Drawing.Size(800, 387);
			this.UsersGridView.TabIndex = 1;
			this.UsersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersGridView_CellContentClick);
			// 
			// AddUserButton
			// 
			this.AddUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddUserButton.Location = new System.Drawing.Point(713, 12);
			this.AddUserButton.Name = "AddUserButton";
			this.AddUserButton.Size = new System.Drawing.Size(75, 23);
			this.AddUserButton.TabIndex = 2;
			this.AddUserButton.Text = "Add User";
			this.AddUserButton.UseVisualStyleBackColor = true;
			this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
			// 
			// EditUserButton
			// 
			this.EditUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.EditUserButton.Location = new System.Drawing.Point(632, 12);
			this.EditUserButton.Name = "EditUserButton";
			this.EditUserButton.Size = new System.Drawing.Size(75, 23);
			this.EditUserButton.TabIndex = 3;
			this.EditUserButton.Text = "Edit User";
			this.EditUserButton.UseVisualStyleBackColor = true;
			this.EditUserButton.Click += new System.EventHandler(this.EditUserButton_Click);
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(12, 17);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(35, 13);
			this.NameLabel.TabIndex = 4;
			this.NameLabel.Text = "Name";
			// 
			// SearchInput
			// 
			this.SearchInput.Location = new System.Drawing.Point(53, 14);
			this.SearchInput.Name = "SearchInput";
			this.SearchInput.Size = new System.Drawing.Size(156, 20);
			this.SearchInput.TabIndex = 5;
			// 
			// SearchButton
			// 
			this.SearchButton.Location = new System.Drawing.Point(215, 12);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(75, 23);
			this.SearchButton.TabIndex = 6;
			this.SearchButton.Text = "Search";
			this.SearchButton.UseVisualStyleBackColor = true;
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// ManageUsersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.SearchButton);
			this.Controls.Add(this.SearchInput);
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.EditUserButton);
			this.Controls.Add(this.AddUserButton);
			this.Controls.Add(this.UsersGridView);
			this.Name = "ManageUsersForm";
			this.Text = "ManageUsersForm";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.UsersGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DataGridView UsersGridView;
		private System.Windows.Forms.Button AddUserButton;
		private System.Windows.Forms.Button EditUserButton;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.TextBox SearchInput;
		private System.Windows.Forms.Button SearchButton;
	}
}

