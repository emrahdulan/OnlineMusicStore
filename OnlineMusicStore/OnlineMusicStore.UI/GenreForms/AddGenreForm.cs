using OnlineMusicStore.API.Models;
using OnlineMusicStore.UI.Helper;
using System;
using System.Windows.Forms;

namespace OnlineMusicStore.UI.GenreForms
{
	public partial class AddGenreForm : Form
	{
		private readonly WebApiHelper _genreService = new WebApiHelper("http://localhost:56644/", "api/Genres");

		public AddGenreForm()
		{
			InitializeComponent();
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			var genre = new Genre
			{
				GenreName = GenreNameInput.Text,
				GenreDescription = GenreDescriptionInput.Text
			};

			var response = _genreService.PostResponse(genre);
			if (response.IsSuccessStatusCode)
			{
				MessageBox.Show("Genre successfully created");
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
