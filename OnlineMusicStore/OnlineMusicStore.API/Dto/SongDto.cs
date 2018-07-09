namespace OnlineMusicStore.API.Dto
{
	public class SongDto
	{
		public int SongId { get; set; }

		public AlbumDto Album { get; set; }

		public string SongTitle { get; set; }

		public int SongDuration { get; set; }

		public string SongLyric { get; set; }
	}
}