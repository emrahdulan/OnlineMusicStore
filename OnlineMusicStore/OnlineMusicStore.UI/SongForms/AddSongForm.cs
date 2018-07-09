using OnlineMusicStore.API.Models;
using OnlineMusicStore.UI.Helper;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace OnlineMusicStore.UI.SongForms
{
	public partial class AddSongForm : Form
	{
		private readonly WebApiHelper _albumService = new WebApiHelper("http://localhost:56644/", "api/Albums");
		private readonly WebApiHelper _songService = new WebApiHelper("http://localhost:56644/", "api/Songs");

		public AddSongForm()
		{
			InitializeComponent();
		}

		private void AddSongForm_Load(object sender, System.EventArgs e)
		{
			var responseGenre = _albumService.GetResponse();

			if (responseGenre.IsSuccessStatusCode)
			{
				AlbumComboBox.DataSource = responseGenre.Content.ReadAsAsync<List<Album>>().Result;
				AlbumComboBox.DisplayMember = "AlbumTitle";
			}
		}

		private void SaveButton_Click(object sender, System.EventArgs e)
		{
			var song = new Song();

			var album = (Album)AlbumComboBox.SelectedItem;
			song.AlbumId = album.AlbumId;

			song.SongTitle = SongTitleInput.Text;
			song.SongDuration = Convert.ToInt32(SongDurationInput.Text);
			song.SongLyric = SongLyricInput.Text;

			var response = _songService.PostResponse(song);
			if (response.IsSuccessStatusCode)
			{
				MessageBox.Show("Song successfully created");
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
