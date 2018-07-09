namespace OnlineMusicStore.UI.UserForms
{
	partial class EditUserForm
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
			this.PasswordInput = new System.Windows.Forms.TextBox();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.EmailInput = new System.Windows.Forms.TextBox();
			this.EmailLabel = new System.Windows.Forms.Label();
			this.LastNameInput = new System.Windows.Forms.TextBox();
			this.LastNameLabel = new System.Windows.Forms.Label();
			this.FirstNameInput = new System.Windows.Forms.TextBox();
			this.FirstNameLabel = new System.Windows.Forms.Label();
			this.UsernameInput = new System.Windows.Forms.TextBox();
			this.UsernameLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(178, 142);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 23);
			this.SaveButton.TabIndex = 25;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// PasswordInput
			// 
			this.PasswordInput.Location = new System.Drawing.Point(90, 116);
			this.PasswordInput.Name = "PasswordInput";
			this.PasswordInput.PasswordChar = '*';
			this.PasswordInput.Size = new System.Drawing.Size(163, 20);
			this.PasswordInput.TabIndex = 22;
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Location = new System.Drawing.Point(33, 119);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
			this.PasswordLabel.TabIndex = 21;
			this.PasswordLabel.Text = "Password";
			// 
			// EmailInput
			// 
			this.EmailInput.Enabled = false;
			this.EmailInput.Location = new System.Drawing.Point(90, 90);
			this.EmailInput.Name = "EmailInput";
			this.EmailInput.ReadOnly = true;
			this.EmailInput.Size = new System.Drawing.Size(163, 20);
			this.EmailInput.TabIndex = 20;
			// 
			// EmailLabel
			// 
			this.EmailLabel.AutoSize = true;
			this.EmailLabel.Location = new System.Drawing.Point(52, 93);
			this.EmailLabel.Name = "EmailLabel";
			this.EmailLabel.Size = new System.Drawing.Size(32, 13);
			this.EmailLabel.TabIndex = 19;
			this.EmailLabel.Text = "Email";
			// 
			// LastNameInput
			// 
			this.LastNameInput.Location = new System.Drawing.Point(90, 64);
			this.LastNameInput.Name = "LastNameInput";
			this.LastNameInput.Size = new System.Drawing.Size(163, 20);
			this.LastNameInput.TabIndex = 18;
			// 
			// LastNameLabel
			// 
			this.LastNameLabel.AutoSize = true;
			this.LastNameLabel.Location = new System.Drawing.Point(26, 67);
			this.LastNameLabel.Name = "LastNameLabel";
			this.LastNameLabel.Size = new System.Drawing.Size(58, 13);
			this.LastNameLabel.TabIndex = 17;
			this.LastNameLabel.Text = "Last Name";
			// 
			// FirstNameInput
			// 
			this.FirstNameInput.Location = new System.Drawing.Point(90, 38);
			this.FirstNameInput.Name = "FirstNameInput";
			this.FirstNameInput.Size = new System.Drawing.Size(163, 20);
			this.FirstNameInput.TabIndex = 16;
			// 
			// FirstNameLabel
			// 
			this.FirstNameLabel.AutoSize = true;
			this.FirstNameLabel.Location = new System.Drawing.Point(29, 41);
			this.FirstNameLabel.Name = "FirstNameLabel";
			this.FirstNameLabel.Size = new System.Drawing.Size(57, 13);
			this.FirstNameLabel.TabIndex = 15;
			this.FirstNameLabel.Text = "First Name";
			// 
			// UsernameInput
			// 
			this.UsernameInput.Enabled = false;
			this.UsernameInput.Location = new System.Drawing.Point(90, 12);
			this.UsernameInput.Name = "UsernameInput";
			this.UsernameInput.ReadOnly = true;
			this.UsernameInput.Size = new System.Drawing.Size(163, 20);
			this.UsernameInput.TabIndex = 14;
			// 
			// UsernameLabel
			// 
			this.UsernameLabel.AutoSize = true;
			this.UsernameLabel.Location = new System.Drawing.Point(31, 15);
			this.UsernameLabel.Name = "UsernameLabel";
			this.UsernameLabel.Size = new System.Drawing.Size(55, 13);
			this.UsernameLabel.TabIndex = 13;
			this.UsernameLabel.Text = "Username";
			// 
			// EditUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(270, 181);
			this.Controls.Add(this.SaveButton);
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
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditUserForm";
			this.Text = "EditUserForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.TextBox PasswordInput;
		private System.Windows.Forms.Label PasswordLabel;
		private System.Windows.Forms.TextBox EmailInput;
		private System.Windows.Forms.Label EmailLabel;
		private System.Windows.Forms.TextBox LastNameInput;
		private System.Windows.Forms.Label LastNameLabel;
		private System.Windows.Forms.TextBox FirstNameInput;
		private System.Windows.Forms.Label FirstNameLabel;
		private System.Windows.Forms.TextBox UsernameInput;
		private System.Windows.Forms.Label UsernameLabel;
	}
}