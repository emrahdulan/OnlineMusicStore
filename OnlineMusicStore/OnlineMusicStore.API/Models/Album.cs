namespace OnlineMusicStore.API.Models
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	[Table("Album")]
	public partial class Album
	{
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public Album()
		{
			SalesOrderDetail = new List<SalesOrderDetail>();
			Song = new List<Song>();
		}

		public int AlbumId { get; set; }

		public int ArtistId { get; set; }

		public int GenreId { get; set; }

		[Required]
		[StringLength(100)]
		public string AlbumTitle { get; set; }

		public decimal AlbumPrice { get; set; }

		public virtual Artist Artist { get; set; }

		public virtual Genre Genre { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual List<SalesOrderDetail> SalesOrderDetail { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual List<Song> Song { get; set; }
	}
}
