using OnlineMusicStore.API.Models;
using OnlineMusicStore.UI.Helper;
using System;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace OnlineMusicStore.UI.AlbumForms
{
	public partial class EditAlbumForm : Form
	{
		private readonly WebApiHelper _albumService = new WebApiHelper("http://localhost:56644/", "api/Albums");
		private Album Album { get; set; }

		public EditAlbumForm(int albumId)
		{
			InitializeComponent();

			var response = _albumService.GetResponse(albumId.ToString());

			if (response.StatusCode == HttpStatusCode.NotFound)
				Album = null;
			else if (response.IsSuccessStatusCode)
			{
				Album = response.Content.ReadAsAsync<Album>().Result;
				FillForm();
			}
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			if (Album != null)
			{
				Album.AlbumTitle = AlbumTitleInput.Text;
				Album.AlbumPrice = Convert.ToDecimal(AlbumPriceInput.Text);

				var response = _albumService.PutResponse(Album.AlbumId, Album);

				if (response.IsSuccessStatusCode)
				{
					MessageBox.Show("Album successfully edited", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
					DialogResult = DialogResult.OK;
					Close();
				}
				else
				{
					MessageBox.Show("Error Code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
				}
			}
		}

		private void FillForm()
		{
			AlbumTitleInput.Text = Album.AlbumTitle;
			AlbumPriceInput.Text = Convert.ToString(Album.AlbumPrice);
		}
	}
}
