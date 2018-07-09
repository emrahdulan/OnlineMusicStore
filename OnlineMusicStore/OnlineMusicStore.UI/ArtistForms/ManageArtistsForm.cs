using OnlineMusicStore.API.Dto;
using OnlineMusicStore.UI.Helper;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace OnlineMusicStore.UI.ArtistForms
{
	public partial class ManageArtistsForm : Form
	{
		private readonly WebApiHelper _artistService = new WebApiHelper("http://localhost:56644/", "api/Artists");

		public ManageArtistsForm()
		{
			InitializeComponent();
		}

		private void LoadArtists()
		{
			var response = _artistService.GetResponse();

			if (response.IsSuccessStatusCode)
			{
				var artists = response.Content.ReadAsAsync<List<ArtistDto>>().Result;
				ArtistGridView.DataSource = artists;
			}
			else
			{
				MessageBox.Show("Error Code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
			}
		}

		private void EditArtistButton_Click(object sender, EventArgs e)
		{
			var form = new EditArtistForm(Convert.ToInt32(ArtistGridView.SelectedRows[0].Cells[0].Value));
			if (form.ShowDialog() == DialogResult.OK)
			{
				LoadArtists();
			}
		}

		private void AddArtistButton_Click(object sender, EventArgs e)
		{
			var form = new AddArtistForm();
			if (form.ShowDialog() == DialogResult.OK)
			{
				LoadArtists();
			}
		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			var response = _artistService.GetActionResponse("SearchByName", SearchInput.Text.Trim());

			if (response.IsSuccessStatusCode)
			{
				var artists = response.Content.ReadAsAsync<List<ArtistDto>>().Result;
				ArtistGridView.DataSource = artists;
				ArtistGridView.ClearSelection();
			}
			else
			{
				MessageBox.Show("Error Code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
			}
		}

		private void ManageArtistForm_Load(object sender, EventArgs e)
		{
			LoadArtists();
		}

		private void DeleteArtistButton_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Are you sure to delete this artist?", "Warning", MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				var response =
					_artistService.DeleteResponse(Convert.ToInt32(ArtistGridView.SelectedRows[0].Cells[0].Value));

				if (response.IsSuccessStatusCode)
				{
					LoadArtists();
				}
				else
				{
					MessageBox.Show("Error Code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
				}
			}
		}

		private void DetailsButton_Click(object sender, EventArgs e)
		{
			var form = new ArtistDetailForm(Convert.ToInt32(ArtistGridView.SelectedRows[0].Cells[0].Value));
			form.Show();
		}
	}
}
