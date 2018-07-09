using OnlineMusicStore.UI.AlbumForms;
using OnlineMusicStore.UI.ArtistForms;
using OnlineMusicStore.UI.GenreForms;
using OnlineMusicStore.UI.SongForms;
using OnlineMusicStore.UI.UserForms;
using System;
using System.Windows.Forms;

namespace OnlineMusicStore.UI
{
	public partial class AdminMainForm : Form
	{
		public AdminMainForm()
		{
			InitializeComponent();
		}

		private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = new ManageUsersForm();
			form.MdiParent = this;
			form.Show();
		}

		private void manageArtistsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = new ManageArtistsForm();
			form.MdiParent = this;
			form.Show();
		}

		private void manageGenresToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = new ManageGenresForm();
			form.MdiParent = this;
			form.Show();
		}

		private void manageAlbumsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = new ManageAlbumsForm();
			form.MdiParent = this;
			form.Show();
		}

		private void manageSongsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = new ManageSongsForm();
			form.MdiParent = this;
			form.Show();
		}
	}
}
