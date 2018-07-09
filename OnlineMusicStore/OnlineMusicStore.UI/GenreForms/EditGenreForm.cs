using OnlineMusicStore.API.Models;
using OnlineMusicStore.UI.Helper;
using System;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace OnlineMusicStore.UI.GenreForms
{

	public partial class EditGenreForm : Form
	{
		private readonly WebApiHelper _genreService = new WebApiHelper("http://localhost:56644/", "api/Genres");
		private Genre Genre { get; set; }

		public EditGenreForm(int genreId)
		{
			InitializeComponent();

			var response = _genreService.GetResponse(genreId.ToString());

			if (response.StatusCode == HttpStatusCode.NotFound)
				Genre = null;
			else if (response.IsSuccessStatusCode)
			{
				Genre = response.Content.ReadAsAsync<Genre>().Result;
				FillForm();
			}
		}

		private void FillForm()
		{
			GenreNameInput.Text = Genre.GenreName;
			GenreDescriptionInput.Text = Genre.GenreDescription;
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			if (Genre != null)
			{
				Genre.GenreName = GenreNameInput.Text;

				var response = _genreService.PutResponse(Genre.GenreId, Genre);

				if (response.IsSuccessStatusCode)
				{
					MessageBox.Show("Genre successfully edited", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
