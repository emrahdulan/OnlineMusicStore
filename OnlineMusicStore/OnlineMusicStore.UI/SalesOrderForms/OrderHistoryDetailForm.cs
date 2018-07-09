using OnlineMusicStore.API.Models;
using OnlineMusicStore.UI.Helper;
using System;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace OnlineMusicStore.UI.SalesOrderForms
{
	public partial class OrderHistoryDetailForm : Form
	{
		private readonly WebApiHelper _salesOrderService = new WebApiHelper("http://localhost:56644/", "api/SalesOrders");
		private SalesOrder SalesOrder { get; set; }

		public OrderHistoryDetailForm(int salesOrderId)
		{
			InitializeComponent();

			var response = _salesOrderService.GetResponse(salesOrderId.ToString());

			if (response.StatusCode == HttpStatusCode.NotFound)
				SalesOrder = null;
			else if (response.IsSuccessStatusCode)
			{
				SalesOrder = response.Content.ReadAsAsync<SalesOrder>().Result;
				SODGridView.DataSource = SalesOrder.SalesOrderDetail;
				CalculateTotal();
			}
		}

		private void CalculateTotal()
		{
			decimal total = 0;
			foreach (var sod in SalesOrder.SalesOrderDetail)
			{
				total += sod.AlbumPrice;
			}

			PriceLabel.Text = Convert.ToString(total);
		}
	}
}
