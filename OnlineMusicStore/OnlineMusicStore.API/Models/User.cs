namespace OnlineMusicStore.API.Models
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	[Table("User")]
	public partial class User
	{
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public User()
		{
			SalesOrder = new List<SalesOrder>();
		}

		public int UserId { get; set; }

		[Required]
		[StringLength(50)]
		public string Username { get; set; }

		[Required]
		[StringLength(50)]
		public string FirstName { get; set; }

		[Required]
		[StringLength(50)]
		public string LastName { get; set; }

		[Required]
		[StringLength(100)]
		public string Email { get; set; }

		[Required]
		[StringLength(50)]
		public string PasswordHash { get; set; }

		[Required]
		[StringLength(50)]
		public string PasswordSalt { get; set; }

		public int RoleId { get; set; }

		public virtual Role Role { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual List<SalesOrder> SalesOrder { get; set; }
	}
}
