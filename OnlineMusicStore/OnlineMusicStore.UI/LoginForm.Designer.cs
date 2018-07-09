namespace OnlineMusicStore.UI
{
	partial class LoginForm
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
			this.PasswordInput = new System.Windows.Forms.TextBox();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.UsernameInput = new System.Windows.Forms.TextBox();
			this.UsernameLabel = new System.Windows.Forms.Label();
			this.LoginButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// PasswordInput
			// 
			this.PasswordInput.Location = new System.Drawing.Point(82, 38);
			this.PasswordInput.Name = "PasswordInput";
			this.PasswordInput.PasswordChar = '*';
			this.PasswordInput.Size = new System.Drawing.Size(189, 20);
			this.PasswordInput.TabIndex = 13;
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Location = new System.Drawing.Point(25, 41);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
			this.PasswordLabel.TabIndex = 12;
			this.PasswordLabel.Text = "Password";
			// 
			// UsernameInput
			// 
			this.UsernameInput.Location = new System.Drawing.Point(82, 12);
			this.UsernameInput.Name = "UsernameInput";
			this.UsernameInput.Size = new System.Drawing.Size(189, 20);
			this.UsernameInput.TabIndex = 11;
			// 
			// UsernameLabel
			// 
			this.UsernameLabel.AutoSize = true;
			this.UsernameLabel.Location = new System.Drawing.Point(21, 15);
			this.UsernameLabel.Name = "UsernameLabel";
			this.UsernameLabel.Size = new System.Drawing.Size(55, 13);
			this.UsernameLabel.TabIndex = 10;
			this.UsernameLabel.Text = "Username";
			// 
			// LoginButton
			// 
			this.LoginButton.Location = new System.Drawing.Point(196, 64);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new System.Drawing.Size(75, 23);
			this.LoginButton.TabIndex = 14;
			this.LoginButton.Text = "Login";
			this.LoginButton.UseVisualStyleBackColor = true;
			this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(115, 64);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 23);
			this.CancelButton.TabIndex = 15;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(283, 100);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.LoginButton);
			this.Controls.Add(this.PasswordInput);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.UsernameInput);
			this.Controls.Add(this.UsernameLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LoginForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox PasswordInput;
		private System.Windows.Forms.Label PasswordLabel;
		private System.Windows.Forms.TextBox UsernameInput;
		private System.Windows.Forms.Label UsernameLabel;
		private System.Windows.Forms.Button LoginButton;
		private new System.Windows.Forms.Button CancelButton;
	}
}