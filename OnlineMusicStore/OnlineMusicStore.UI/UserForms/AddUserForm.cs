using OnlineMusicStore.API.Models;
using OnlineMusicStore.UI.Helper;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace OnlineMusicStore.UI.UserForms
{
	public partial class AddUserForm : Form
	{

		private readonly WebApiHelper _userService = new WebApiHelper("http://localhost:56644/", "api/Users");
		private readonly WebApiHelper _roleService = new WebApiHelper("http://localhost:56644/", "api/Roles");

		public AddUserForm()
		{
			InitializeComponent();
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			var user = new User();
			user.Username = UsernameInput.Text;
			user.FirstName = FirstNameInput.Text;
			user.LastName = LastNameInput.Text;
			user.Email = EmailInput.Text;
			user.PasswordSalt = PasswordHelper.GenerateSalt();
			user.PasswordHash = PasswordHelper.GenerateHash(PasswordInput.Text, user.PasswordSalt);

			var role = (Role)RoleComboBox.SelectedItem;
			user.RoleId = role.RoleId;


			var response = _userService.PostResponse(user);
			if (response.IsSuccessStatusCode)
			{
				MessageBox.Show("User successfully created");
				DialogResult = DialogResult.OK;
				Close();
			}
			else
			{
				MessageBox.Show("Error Code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
			}
		}

		private void AddUserForm_Load(object sender, EventArgs e)
		{
			var response = _roleService.GetResponse();

			if (response.IsSuccessStatusCode)
			{
				RoleComboBox.DataSource = response.Content.ReadAsAsync<List<Role>>().Result;
				RoleComboBox.DisplayMember = "RoleName";
			}
		}
	}
}
