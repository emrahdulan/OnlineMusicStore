namespace OnlineMusicStore.API.Models
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	[Table("Artist")]
	public partial class Artist
	{
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public Artist()
		{
			Album = new List<Album>();
		}

		public int ArtistId { get; set; }

		[Required]
		[StringLength(50)]
		public string ArtistName { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual List<Album> Album { get; set; }
	}
}
