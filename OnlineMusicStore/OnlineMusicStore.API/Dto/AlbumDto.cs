namespace OnlineMusicStore.API.Dto
{
	public class AlbumDto
	{
		public int AlbumId { get; set; }

		public ArtistDto Artist { get; set; }

		public GenreDto Genre { get; set; }

		public string AlbumTitle { get; set; }

		public decimal AlbumPrice { get; set; }
	}
}