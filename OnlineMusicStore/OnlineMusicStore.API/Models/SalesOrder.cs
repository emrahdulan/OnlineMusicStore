namespace OnlineMusicStore.API.Models
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	[Table("SalesOrder")]
	public partial class SalesOrder
	{
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public SalesOrder()
		{
			SalesOrderDetail = new List<SalesOrderDetail>();
		}

		[Key]
		public int OrderId { get; set; }

		public int UserId { get; set; }

		[Column(TypeName = "datetime2")]
		public DateTime OrderDate { get; set; }

		public virtual User User { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual List<SalesOrderDetail> SalesOrderDetail { get; set; }
	}
}
