using OnlineMusicStore.API.Dto;
using OnlineMusicStore.UI.Helper;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace OnlineMusicStore.UI.AlbumForms
{
	public partial class ManageAlbumsForm : Form
	{
		private readonly WebApiHelper _albumService = new WebApiHelper("http://localhost:56644/", "api/Albums");

		public ManageAlbumsForm()
		{
			InitializeComponent();
		}

		private void LoadAlbums()
		{
			var response = _albumService.GetResponse();

			if (response.IsSuccessStatusCode)
			{
				var albums = response.Content.ReadAsAsync<List<AlbumDto>>().Result;
				AlbumsGridView.DataSource = albums;
			}
			else
			{
				MessageBox.Show("Error Code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
			}
		}

		private void AddAlbumButton_Click_1(object sender, EventArgs e)
		{
			var form = new AddAlbumForm();
			if (form.ShowDialog() == DialogResult.OK)
			{
				LoadAlbums();
			}
		}

		private void EditAlbumButton_Click_1(object sender, EventArgs e)
		{
			var form = new EditAlbumForm(Convert.ToInt32(AlbumsGridView.SelectedRows[0].Cells[0].Value));
			if (form.ShowDialog() == DialogResult.OK)
			{
				LoadAlbums();
			}
		}

		private void DeleteAlbumButton_Click_1(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Are you sure to delete this album?", "Warning", MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				var response =
					_albumService.DeleteResponse(Convert.ToInt32(AlbumsGridView.SelectedRows[0].Cells[0].Value));

				if (response.IsSuccessStatusCode)
				{
					LoadAlbums();
				}
				else
				{
					MessageBox.Show("Error Code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
				}
			}
		}

		private void DetailsButton_Click_1(object sender, EventArgs e)
		{
			var form = new AlbumDetailForm(Convert.ToInt32(AlbumsGridView.SelectedRows[0].Cells[0].Value));
			form.Show();
		}

		private void ManageAlbumsForm_Load_1(object sender, EventArgs e)
		{
			LoadAlbums();
		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			var response = _albumService.GetActionResponse("SearchByName", SearchInput.Text.Trim());

			if (response.IsSuccessStatusCode)
			{
				var albums = response.Content.ReadAsAsync<List<AlbumDto>>().Result;
				AlbumsGridView.DataSource = albums;
				AlbumsGridView.ClearSelection();
			}
			else
			{
				MessageBox.Show("Error Code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
			}
		}
	}
}
