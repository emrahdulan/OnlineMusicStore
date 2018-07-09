namespace OnlineMusicStore.API.Models
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	[Table("Genre")]
	public partial class Genre
	{
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public Genre()
		{
			Album = new List<Album>();
		}

		public int GenreId { get; set; }

		[Required]
		[StringLength(50)]
		public string GenreName { get; set; }

		[StringLength(100)]
		public string GenreDescription { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual List<Album> Album { get; set; }
	}
}
