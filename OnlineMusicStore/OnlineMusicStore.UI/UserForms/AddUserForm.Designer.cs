namespace OnlineMusicStore.UI.UserForms
{
	partial class AddUserForm
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
			this.UsernameLabel = new System.Windows.Forms.Label();
			this.UsernameInput = new System.Windows.Forms.TextBox();
			this.FirstNameInput = new System.Windows.Forms.TextBox();
			this.FirstNameLabel = new System.Windows.Forms.Label();
			this.LastNameInput = new System.Windows.Forms.TextBox();
			this.LastNameLabel = new System.Windows.Forms.Label();
			this.EmailInput = new System.Windows.Forms.TextBox();
			this.EmailLabel = new System.Windows.Forms.Label();
			this.PasswordInput = new System.Windows.Forms.TextBox();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.RoleComboBox = new System.Windows.Forms.ComboBox();
			this.RoleLabel = new System.Windows.Forms.Label();
			this.SaveButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// UsernameLabel
			// 
			this.UsernameLabel.AutoSize = true;
			this.UsernameLabel.Location = new System.Drawing.Point(20, 24);
			this.UsernameLabel.Name = "UsernameLabel";
			this.UsernameLabel.Size = new System.Drawing.Size(55, 13);
			this.UsernameLabel.TabIndex = 0;
			this.UsernameLabel.Text = "Username";
			// 
			// UsernameInput
			// 
			this.UsernameInput.Location = new System.Drawing.Point(79, 21);
			this.UsernameInput.Name = "UsernameInput";
			this.UsernameInput.Size = new System.Drawing.Size(163, 20);
			this.UsernameInput.TabIndex = 1;
			// 
			// FirstNameInput
			// 
			this.FirstNameInput.Location = new System.Drawing.Point(79, 47);
			this.FirstNameInput.Name = "FirstNameInput";
			this.FirstNameInput.Size = new System.Drawing.Size(163, 20);
			this.FirstNameInput.TabIndex = 3;
			// 
			// FirstNameLabel
			// 
			this.FirstNameLabel.AutoSize = true;
			this.FirstNameLabel.Location = new System.Drawing.Point(18, 50);
			this.FirstNameLabel.Name = "FirstNameLabel";
			this.FirstNameLabel.Size = new System.Drawing.Size(57, 13);
			this.FirstNameLabel.TabIndex = 2;
			this.FirstNameLabel.Text = "First Name";
			// 
			// LastNameInput
			// 
			this.LastNameInput.Location = new System.Drawing.Point(79, 73);
			this.LastNameInput.Name = "LastNameInput";
			this.LastNameInput.Size = new System.Drawing.Size(163, 20);
			this.LastNameInput.TabIndex = 5;
			// 
			// LastNameLabel
			// 
			this.LastNameLabel.AutoSize = true;
			this.LastNameLabel.Location = new System.Drawing.Point(15, 76);
			this.LastNameLabel.Name = "LastNameLabel";
			this.LastNameLabel.Size = new System.Drawing.Size(58, 13);
			this.LastNameLabel.TabIndex = 4;
			this.LastNameLabel.Text = "Last Name";
			// 
			// EmailInput
			// 
			this.EmailInput.Location = new System.Drawing.Point(79, 99);
			this.EmailInput.Name = "EmailInput";
			this.EmailInput.Size = new System.Drawing.Size(163, 20);
			this.EmailInput.TabIndex = 7;
			// 
			// EmailLabel
			// 
			this.EmailLabel.AutoSize = true;
			this.EmailLabel.Location = new System.Drawing.Point(41, 102);
			this.EmailLabel.Name = "EmailLabel";
			this.EmailLabel.Size = new System.Drawing.Size(32, 13);
			this.EmailLabel.TabIndex = 6;
			this.EmailLabel.Text = "Email";
			// 
			// PasswordInput
			// 
			this.PasswordInput.Location = new System.Drawing.Point(79, 125);
			this.PasswordInput.Name = "PasswordInput";
			this.PasswordInput.PasswordChar = '*';
			this.PasswordInput.Size = new System.Drawing.Size(163, 20);
			this.PasswordInput.TabIndex = 9;
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Location = new System.Drawing.Point(22, 128);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
			this.PasswordLabel.TabIndex = 8;
			this.PasswordLabel.Text = "Password";
			// 
			// RoleComboBox
			// 
			this.RoleComboBox.FormattingEnabled = true;
			this.RoleComboBox.Location = new System.Drawing.Point(79, 151);
			this.RoleComboBox.Name = "RoleComboBox";
			this.RoleComboBox.Size = new System.Drawing.Size(163, 21);
			this.RoleComboBox.TabIndex = 10;
			// 
			// RoleLabel
			// 
			this.RoleLabel.AutoSize = true;
			this.RoleLabel.Location = new System.Drawing.Point(44, 154);
			this.RoleLabel.Name = "RoleLabel";
			this.RoleLabel.Size = new System.Drawing.Size(29, 13);
			this.RoleLabel.TabIndex = 11;
			this.RoleLabel.Text = "Role";
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(167, 178);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 23);
			this.SaveButton.TabIndex = 12;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// AddUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(266, 215);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.RoleLabel);
			this.Controls.Add(this.RoleComboBox);
			this.Controls.Add(this.PasswordInput);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.EmailInput);
			this.Controls.Add(this.EmailLabel);
			this.Controls.Add(this.LastNameInput);
			this.Controls.Add(this.LastNameLabel);
			this.Controls.Add(this.FirstNameInput);
			this.Controls.Add(this.FirstNameLabel);
			this.Controls.Add(this.UsernameInput);
			this.Controls.Add(this.UsernameLabel);
			this.Name = "AddUserForm";
			this.Text = "AddUserForm";
			this.Load += new System.EventHandler(this.AddUserForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label UsernameLabel;
		private System.Windows.Forms.TextBox UsernameInput;
		private System.Windows.Forms.TextBox FirstNameInput;
		private System.Windows.Forms.Label FirstNameLabel;
		private System.Windows.Forms.TextBox LastNameInput;
		private System.Windows.Forms.Label LastNameLabel;
		private System.Windows.Forms.TextBox EmailInput;
		private System.Windows.Forms.Label EmailLabel;
		private System.Windows.Forms.TextBox PasswordInput;
		private System.Windows.Forms.Label PasswordLabel;
		private System.Windows.Forms.ComboBox RoleComboBox;
		private System.Windows.Forms.Label RoleLabel;
		private System.Windows.Forms.Button SaveButton;
	}
}