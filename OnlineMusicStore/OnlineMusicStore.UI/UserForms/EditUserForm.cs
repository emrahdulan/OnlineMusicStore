using OnlineMusicStore.API.Models;
using OnlineMusicStore.UI.Helper;
using System;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace OnlineMusicStore.UI.UserForms
{
	public partial class EditUserForm : Form
	{
		private readonly WebApiHelper _userService = new WebApiHelper("http://localhost:56644/", "api/Users");
		private User User { get; set; }

		public EditUserForm(int userId)
		{
			InitializeComponent();

			var response = _userService.GetResponse(userId.ToString());

			if (response.StatusCode == HttpStatusCode.NotFound)
				User = null;
			else if (response.IsSuccessStatusCode)
			{
				User = response.Content.ReadAsAsync<User>().Result;
				FillForm();
			}
		}

		private void FillForm()
		{
			UsernameInput.Text = User.Username;
			FirstNameInput.Text = User.FirstName;
			LastNameInput.Text = User.LastName;
			EmailInput.Text = User.Email;
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			if (User != null)
			{
				User.FirstName = FirstNameInput.Text;
				User.LastName = LastNameInput.Text;

				if (PasswordInput.Text != String.Empty)
				{
					User.PasswordSalt = PasswordHelper.GenerateSalt();
					User.PasswordHash = PasswordHelper.GenerateHash(PasswordInput.Text, User.PasswordSalt);
				}

				var response = _userService.PutResponse(User.UserId, User);

				if (response.IsSuccessStatusCode)
				{
					MessageBox.Show("User successfully edited", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
					DialogResult = DialogResult.OK;
					Close();
				}
				else
				{
					MessageBox.Show("Error Code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
				}
			}
		}
	}
}
