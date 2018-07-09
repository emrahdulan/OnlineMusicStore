namespace OnlineMusicStore.API.Models
{
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	[Table("Song")]
	public partial class Song
	{
		public int SongId { get; set; }

		public int AlbumId { get; set; }

		[Required]
		[StringLength(100)]
		public string SongTitle { get; set; }

		public int SongDuration { get; set; }

		[StringLength(1000)]
		public string SongLyric { get; set; }

		public virtual Album Album { get; set; }
	}
}
