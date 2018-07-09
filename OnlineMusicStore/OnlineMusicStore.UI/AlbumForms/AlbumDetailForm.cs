using OnlineMusicStore.API.Models;
using OnlineMusicStore.UI.Helper;
using System;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace OnlineMusicStore.UI.AlbumForms
{
	public partial class AlbumDetailForm : Form
	{
		private readonly WebApiHelper _albumService = new WebApiHelper("http://localhost:56644/", "api/Albums");
		private Album Album { get; set; }

		public AlbumDetailForm(int albumId)
		{
			InitializeComponent();

			var response = _albumService.GetResponse(albumId.ToString());

			if (response.StatusCode == HttpStatusCode.NotFound)
				Album = null;
			else if (response.IsSuccessStatusCode)
			{
				Album = response.Content.ReadAsAsync<Album>().Result;
				AlbumTitleLabel.Text = Album.AlbumTitle + " " + Convert.ToString(Album.AlbumPrice);
				SongsGridView.DataSource = Album.Song;
			}
		}
	}
}
