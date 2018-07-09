using System;

namespace OnlineMusicStore.API.Dto
{
	public class SalesOrderDto
	{
		public int OrderId { get; set; }

		public UserDto User { get; set; }

		public DateTime OrderDate { get; set; }
	}
}