using OnlineMusicStore.API.Dto;
using OnlineMusicStore.UI.Helper;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace OnlineMusicStore.UI.SalesOrderForms
{
	public partial class OrderHistoryForm : Form
	{
		private readonly WebApiHelper _salesOrderService = new WebApiHelper("http://localhost:56644/", "api/SalesOrders");

		public OrderHistoryForm()
		{
			InitializeComponent();
		}

		private void OrderHistoryForm_Load(object sender, EventArgs e)
		{
			LoadOrders();
		}

		private void DetailsButton_Click(object sender, EventArgs e)
		{
			var form = new OrderHistoryDetailForm(Convert.ToInt32(SOGridView.SelectedRows[0].Cells[0].Value));
			form.Show();
		}

		private void LoadOrders()
		{
			var response = _salesOrderService.GetResponse();

			if (response.IsSuccessStatusCode)
			{
				var so = response.Content.ReadAsAsync<List<SalesOrderDto>>().Result;
				SOGridView.DataSource = so;
			}
			else
			{
				MessageBox.Show("Error Code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
			}
		}
	}
}
