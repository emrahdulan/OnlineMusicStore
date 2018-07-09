using OnlineMusicStore.UI.AlbumForms;
using OnlineMusicStore.UI.SalesOrderForms;
using System;
using System.Windows.Forms;

namespace OnlineMusicStore.UI
{
	public partial class UserMainForm : Form
	{
		public UserMainForm()
		{
			InitializeComponent();
		}

		private void browseAlbumsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = new AlbumBrowserForm();
			form.MdiParent = this;
			form.Show();
		}

		private void myOrdersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = new OrderHistoryForm();
			form.MdiParent = this;
			form.Show();
		}
	}
}
