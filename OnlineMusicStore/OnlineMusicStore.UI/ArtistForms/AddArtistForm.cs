using OnlineMusicStore.API.Models;
using OnlineMusicStore.UI.Helper;
using System;
using System.Windows.Forms;

namespace OnlineMusicStore.UI.ArtistForms
{
	public partial class AddArtistForm : Form
	{
		private readonly WebApiHelper _artistService = new WebApiHelper("http://localhost:56644/", "api/Artists");


		public AddArtistForm()
		{
			InitializeComponent();
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			var artist = new Artist();
			artist.ArtistName = ArtistNameInput.Text;

			var response = _artistService.PostResponse(artist);
			if (response.IsSuccessStatusCode)
			{
				MessageBox.Show("Artist successfully created");
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
