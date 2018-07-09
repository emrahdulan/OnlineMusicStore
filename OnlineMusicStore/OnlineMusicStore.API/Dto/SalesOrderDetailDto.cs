namespace OnlineMusicStore.API.Dto
{
	public class SalesOrderDetailDto
	{
		public int OrderDetailId { get; set; }

		public int OrderId { get; set; }

		public AlbumDto Album { get; set; }

		public decimal AlbumPrice { get; set; }
	}
}