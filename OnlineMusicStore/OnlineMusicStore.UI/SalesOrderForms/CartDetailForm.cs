using OnlineMusicStore.API.Models;
using OnlineMusicStore.UI.Helper;
using System;
using System.Windows.Forms;

namespace OnlineMusicStore.UI.SalesOrderForms
{
	public partial class CartDetailForm : Form
	{
		private readonly WebApiHelper _salesOrderService = new WebApiHelper("http://localhost:56644/", "api/SalesOrders");
		private SalesOrder SalesOrder { get; set; }

		public CartDetailForm(SalesOrder cart)
		{
			InitializeComponent();

			if (cart == null)
			{
				cart = new SalesOrder
				{
					UserId = Global.OnlineUser.UserId,
					OrderDate = DateTime.Now
				};
			}

			SalesOrder = cart;
		}

		private void CartDetailForm_Load(object sender, EventArgs e)
		{
			CalculateTotal();

			SODGridView.DataSource = SalesOrder.SalesOrderDetail;
		}

		private void BuyButton_Click(object sender, EventArgs e)
		{
			var response = _salesOrderService.PostResponse(SalesOrder);

			if (response.IsSuccessStatusCode)
			{
				MessageBox.Show("Order successfully created");
				DialogResult = DialogResult.OK;
				Global.CurrentOrder = null;
				Close();
			}
			else
			{
				MessageBox.Show("Error Code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
			}
		}

		private void DeleteAllButton_Click(object sender, EventArgs e)
		{
			SalesOrder.SalesOrderDetail.Clear();

			CalculateTotal();
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			if (SODGridView.CurrentRow != null)
			{
				SalesOrderDetail sod = (SalesOrderDetail)SODGridView.CurrentRow.DataBoundItem;
				SalesOrder.SalesOrderDetail.Remove(sod);
				SODGridView.DataSource = SalesOrder.SalesOrderDetail;
			}
			CalculateTotal();
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
