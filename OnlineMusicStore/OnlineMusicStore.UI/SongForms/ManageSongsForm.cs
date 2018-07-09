using OnlineMusicStore.API.Dto;
using OnlineMusicStore.UI.Helper;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace OnlineMusicStore.UI.SongForms
{
	public partial class ManageSongsForm : Form
	{
		private readonly WebApiHelper _songService = new WebApiHelper("http://localhost:56644/", "api/Songs");

		public ManageSongsForm()
		{
			InitializeComponent();
		}

		private void ManageSongsForm_Load(object sender, EventArgs e)
		{
			LoadSongs();
		}

		private void AddSongButton_Click(object sender, EventArgs e)
		{
			var form = new AddSongForm();
			if (form.ShowDialog() == DialogResult.OK)
			{
				LoadSongs();
			}
		}

		private void EditSongButton_Click(object sender, EventArgs e)
		{
			var form = new EditSongForm(Convert.ToInt32(SongsGridView.SelectedRows[0].Cells[0].Value));
			if (form.ShowDialog() == DialogResult.OK)
			{
				LoadSongs();
			}
		}

		private void DeleteSongButton_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Are you sure to delete this song?", "Warning", MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				var response =
					_songService.DeleteResponse(Convert.ToInt32(SongsGridView.SelectedRows[0].Cells[0].Value));

				if (response.IsSuccessStatusCode)
				{
					LoadSongs();
				}
				else
				{
					MessageBox.Show("Error Code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
				}
			}
		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			var response = _songService.GetActionResponse("SearchByName", SearchInput.Text.Trim());

			if (response.IsSuccessStatusCode)
			{
				var songs = response.Content.ReadAsAsync<List<SongDto>>().Result;
				SongsGridView.DataSource = songs;
				SongsGridView.ClearSelection();
			}
			else
			{
				MessageBox.Show("Error Code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
			}
		}

		private void LoadSongs()
		{
			var response = _songService.GetResponse();

			if (response.IsSuccessStatusCode)
			{
				var songs = response.Content.ReadAsAsync<List<SongDto>>().Result;
				SongsGridView.DataSource = songs;
			}
			else
			{
				MessageBox.Show("Error Code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
			}
		}
	}
}
