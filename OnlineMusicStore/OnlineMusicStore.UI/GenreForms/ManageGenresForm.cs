using OnlineMusicStore.API.Dto;
using OnlineMusicStore.UI.Helper;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace OnlineMusicStore.UI.GenreForms
{
	public partial class ManageGenresForm : Form
	{
		private readonly WebApiHelper _genreService = new WebApiHelper("http://localhost:56644/", "api/Genres");

		public ManageGenresForm()
		{
			InitializeComponent();
		}

		private void LoadGenres()
		{
			var response = _genreService.GetResponse();

			if (response.IsSuccessStatusCode)
			{
				var genres = response.Content.ReadAsAsync<List<GenreDto>>().Result;
				GenreGridView.DataSource = genres;
			}
			else
			{
				MessageBox.Show("Error Code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
			}
		}

		private void AddGenreButton_Click(object sender, EventArgs e)
		{
			var form = new AddGenreForm();
			if (form.ShowDialog() == DialogResult.OK)
			{
				LoadGenres();
			}
		}

		private void EditGenreButton_Click(object sender, EventArgs e)
		{
			var form = new EditGenreForm(Convert.ToInt32(GenreGridView.SelectedRows[0].Cells[0].Value));
			if (form.ShowDialog() == DialogResult.OK)
			{
				LoadGenres();
			}
		}

		private void DeleteGenreButton_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Are you sure to delete this genre?", "Warning", MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				var response =
					_genreService.DeleteResponse(Convert.ToInt32(GenreGridView.SelectedRows[0].Cells[0].Value));

				if (response.IsSuccessStatusCode)
				{
					LoadGenres();
				}
				else
				{
					MessageBox.Show("Error Code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
				}
			}
		}

		private void MenageGenresForm_Load(object sender, EventArgs e)
		{
			LoadGenres();
		}
	}
}
