using OnlineMusicStore.API.Models;
using OnlineMusicStore.UI.Helper;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace OnlineMusicStore.UI.ArtistForms
{
	public partial class ArtistDetailForm : Form
	{
		private readonly WebApiHelper _artistService = new WebApiHelper("http://localhost:56644/", "api/Artists");
		private Artist Artist { get; set; }

		public ArtistDetailForm(int artistId)
		{
			InitializeComponent();

			var response = _artistService.GetResponse(artistId.ToString());

			if (response.StatusCode == HttpStatusCode.NotFound)
				Artist = null;
			else if (response.IsSuccessStatusCode)
			{
				Artist = response.Content.ReadAsAsync<Artist>().Result;
				ArtistNameLabel.Text = Artist.ArtistName;
				AlbumsGridView.DataSource = Artist.Album;
			}
		}
	}
}
