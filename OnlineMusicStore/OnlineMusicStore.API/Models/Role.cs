namespace OnlineMusicStore.API.Models
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	[Table("Role")]
	public partial class Role
	{
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public Role()
		{
			User = new List<User>();
		}

		public int RoleId { get; set; }

		[Required]
		[StringLength(50)]
		public string RoleName { get; set; }

		[StringLength(200)]
		public string RoleDescription { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual List<User> User { get; set; }
	}
}
