using OnlineMusicStore.API.Dto;
using OnlineMusicStore.API.Models;
using OnlineMusicStore.UI.Helper;
using OnlineMusicStore.UI.SalesOrderForms;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace OnlineMusicStore.UI.AlbumForms
{
	public partial class AlbumBrowserForm : Form
	{
		private readonly WebApiHelper _albumService = new WebApiHelper("http://localhost:56644/", "api/Albums");

		public AlbumBrowserForm()
		{
			InitializeComponent();
		}

		private void AddToCartButton_Click(object sender, EventArgs e)
		{
			if (Global.CurrentOrder == null)
			{
				Global.CurrentOrder = new SalesOrder
				{
					UserId = Global.OnlineUser.UserId,
					OrderDate = DateTime.Now
				};
			}

			var sod = new SalesOrderDetail
			{
				AlbumId = Convert.ToInt32(AlbumsGridView.SelectedRows[0].Cells[0].Value),
				OrderId = Global.CurrentOrder.OrderId,
				AlbumPrice = Convert.ToDecimal(AlbumsGridView.SelectedRows[0].Cells[4].Value)
			};

			Global.CurrentOrder.SalesOrderDetail.Add(sod);
		}

		private void DetailsButton_Click(object sender, EventArgs e)
		{
			var form = new AlbumDetailForm(Convert.ToInt32(AlbumsGridView.SelectedRows[0].Cells[0].Value));
			form.Show();
		}

		private void CartButton_Click(object sender, EventArgs e)
		{
			var form = new CartDetailForm(Global.CurrentOrder);
			form.Show();
		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			var response = _albumService.GetActionResponse("SearchByName", SearchInput.Text.Trim());

			if (response.IsSuccessStatusCode)
			{
				var albums = response.Content.ReadAsAsync<List<AlbumDto>>().Result;
				AlbumsGridView.DataSource = albums;
				AlbumsGridView.ClearSelection();
			}
			else
			{
				MessageBox.Show("Error Code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
			}
		}

		private void AlbumBrowserForm_Load(object sender, EventArgs e)
		{
			LoadAlbums();
		}


		private void LoadAlbums()
		{
			var response = _albumService.GetResponse();

			if (response.IsSuccessStatusCode)
			{
				var albums = response.Content.ReadAsAsync<List<AlbumDto>>().Result;
				AlbumsGridView.DataSource = albums;
			}
			else
			{
				MessageBox.Show("Error Code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
			}
		}
	}
}
