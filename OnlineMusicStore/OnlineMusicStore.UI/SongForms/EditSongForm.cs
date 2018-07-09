using OnlineMusicStore.API.Models;
using OnlineMusicStore.UI.Helper;
using System;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace OnlineMusicStore.UI.SongForms
{
	public partial class EditSongForm : Form
	{
		private readonly WebApiHelper _songService = new WebApiHelper("http://localhost:56644/", "api/Songs");
		private Song Song { get; set; }

		public EditSongForm(int songId)
		{
			InitializeComponent();

			var response = _songService.GetResponse(songId.ToString());

			if (response.StatusCode == HttpStatusCode.NotFound)
				Song = null;
			else if (response.IsSuccessStatusCode)
			{
				Song = response.Content.ReadAsAsync<Song>().Result;
				FillForm();
			}
		}

		private void SaveButton_Click(object sender, System.EventArgs e)
		{
			if (Song != null)
			{
				Song.SongTitle = SongTitleInput.Text;
				Song.SongDuration = Convert.ToInt32(SongDurationInput.Text);
				Song.SongLyric = SongLyricInput.Text;

				var response = _songService.PutResponse(Song.SongId, Song);

				if (response.IsSuccessStatusCode)
				{
					MessageBox.Show("Song successfully edited", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
			SongTitleInput.Text = Song.SongTitle;
			SongDurationInput.Text = Convert.ToString(Song.SongDuration);
			SongLyricInput.Text = Song.SongLyric;
		}
	}
}
