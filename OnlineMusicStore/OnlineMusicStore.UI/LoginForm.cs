using OnlineMusicStore.API.Models;
using OnlineMusicStore.UI.Helper;
using System;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace OnlineMusicStore.UI
{
	public partial class LoginForm : Form
	{
		private readonly WebApiHelper _userService = new WebApiHelper("http://localhost:56644/", "api/Users");

		public LoginForm()
		{
			InitializeComponent();
		}


		private void Login()
		{
			var response = _userService.GetActionResponse("GetByUsername", UsernameInput.Text);

			if (response.StatusCode == HttpStatusCode.NotFound)
			{
				MessageBox.Show("Username or password is incorrect", "Warning", MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
			}
			else if (response.IsSuccessStatusCode)
			{
				var user = response.Content.ReadAsAsync<User>().Result;
				if (user.PasswordHash == PasswordHelper.GenerateHash(PasswordInput.Text, user.PasswordSalt))
				{
					DialogResult = DialogResult.OK;
					Global.OnlineUser = user;
					Close();
				}
				else
				{
					MessageBox.Show("Password is incorrect", "Warning", MessageBoxButtons.OK,
						MessageBoxIcon.Warning);
				}
			}
			else
			{
				MessageBox.Show("Error Code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
			}
		}

		private void LoginButton_Click(object sender, EventArgs e)
		{
			Login();
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
