namespace OnlineMusicStore.API.Models
{
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	[Table("SalesOrderDetail")]
	public partial class SalesOrderDetail
	{
		[Key]
		public int OrderDetailId { get; set; }

		public int OrderId { get; set; }

		public int AlbumId { get; set; }

		public decimal AlbumPrice { get; set; }

		public virtual Album Album { get; set; }

		public virtual SalesOrder SalesOrder { get; set; }
	}
}
