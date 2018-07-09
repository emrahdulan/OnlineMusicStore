using OnlineMusicStore.API.Dto;
using OnlineMusicStore.UI.Helper;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace OnlineMusicStore.UI.UserForms
{
	public partial class ManageUsersForm : Form
	{
		private readonly WebApiHelper _userService = new WebApiHelper("http://localhost:56644/", "api/Users");

		public ManageUsersForm()
		{
			InitializeComponent();
		}

		private void LoadUsers()
		{
			var response = _userService.GetResponse();

			if (response.IsSuccessStatusCode)
			{
				var users = response.Content.ReadAsAsync<List<UserDto>>().Result;
				UsersGridView.DataSource = users;
			}
			else
			{
				MessageBox.Show("Error Code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
			}
		}

		private void AddUserButton_Click(object sender, EventArgs e)
		{
			var form = new AddUserForm();
			if (form.ShowDialog() == DialogResult.OK)
			{
				LoadUsers();
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			LoadUsers();
		}

		private void EditUserButton_Click(object sender, EventArgs e)
		{
			var form = new EditUserForm(Convert.ToInt32(UsersGridView.SelectedRows[0].Cells[0].Value));
			if (form.ShowDialog() == DialogResult.OK)
			{
				LoadUsers();
			}
		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			var response = _userService.GetActionResponse("SearchByName", SearchInput.Text.Trim());

			if (response.IsSuccessStatusCode)
			{
				var users = response.Content.ReadAsAsync<List<UserDto>>().Result;
				UsersGridView.DataSource = users;
				UsersGridView.ClearSelection();
			}
			else
			{
				MessageBox.Show("Error Code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
			}
		}

		private void UsersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
