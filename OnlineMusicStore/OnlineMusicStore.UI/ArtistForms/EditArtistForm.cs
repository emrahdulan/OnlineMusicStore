using OnlineMusicStore.API.Models;
using OnlineMusicStore.UI.Helper;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace OnlineMusicStore.UI.ArtistForms
{
	public partial class EditArtistForm : Form
	{
		private readonly WebApiHelper _userService = new WebApiHelper("http://localhost:56644/", "api/Artists");
		private Artist Artist { get; set; }

		public EditArtistForm(int artistId)
		{
			InitializeComponent();

			var response = _userService.GetResponse(artistId.ToString());

			if (response.StatusCode == HttpStatusCode.NotFound)
				Artist = null;
			else if (response.IsSuccessStatusCode)
			{
				Artist = response.Content.ReadAsAsync<Artist>().Result;
				FillForm();
			}
		}

		private void FillForm()
		{
			ArtistNameInput.Text = Artist.ArtistName;
		}

		private void SaveButton_Click(object sender, System.EventArgs e)
		{
			if (Artist != null)
			{
				Artist.ArtistName = ArtistNameInput.Text;

				var response = _userService.PutResponse(Artist.ArtistId, Artist);

				if (response.IsSuccessStatusCode)
				{
					MessageBox.Show("Artist successfully edited", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
