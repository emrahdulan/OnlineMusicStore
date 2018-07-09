using OnlineMusicStore.API.Models;
using OnlineMusicStore.UI.Helper;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace OnlineMusicStore.UI.AlbumForms
{
	public partial class AddAlbumForm : Form
	{
		private readonly WebApiHelper _genreService = new WebApiHelper("http://localhost:56644/", "api/Genres");
		private readonly WebApiHelper _artistService = new WebApiHelper("http://localhost:56644/", "api/Artists");
		private readonly WebApiHelper _albumService = new WebApiHelper("http://localhost:56644/", "api/Albums");

		public AddAlbumForm()
		{
			InitializeComponent();
		}

		private void AddAlbumForm_Load(object sender, EventArgs e)
		{
			var responseGenre = _genreService.GetResponse();

			if (responseGenre.IsSuccessStatusCode)
			{
				GenreComboBox.DataSource = responseGenre.Content.ReadAsAsync<List<Genre>>().Result;
				GenreComboBox.DisplayMember = "GenreName";
			}

			var responseArtist = _artistService.GetResponse();

			if (responseArtist.IsSuccessStatusCode)
			{
				ArtistComboBox.DataSource = responseArtist.Content.ReadAsAsync<List<Artist>>().Result;
				ArtistComboBox.DisplayMember = "ArtistName";
			}
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			var album = new Album();

			var artist = (Artist)ArtistComboBox.SelectedItem;
			album.ArtistId = artist.ArtistId;

			var genre = (Genre)GenreComboBox.SelectedItem;
			album.GenreId = genre.GenreId;

			album.AlbumTitle = AlbumTitleInput.Text;
			album.AlbumPrice = Convert.ToDecimal(AlbumPriceInput.Text);

			var response = _albumService.PostResponse(album);
			if (response.IsSuccessStatusCode)
			{
				MessageBox.Show("Album successfully created");
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
