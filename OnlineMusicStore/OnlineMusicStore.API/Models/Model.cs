namespace OnlineMusicStore.API.Models
{
	using System.Data.Entity;

	public partial class Model : DbContext
	{
		public Model()
			: base("name=ModelConnectionSettings")
		{
		}

		public virtual DbSet<Album> Album { get; set; }
		public virtual DbSet<Artist> Artist { get; set; }
		public virtual DbSet<Genre> Genre { get; set; }
		public virtual DbSet<Role> Role { get; set; }
		public virtual DbSet<SalesOrder> SalesOrder { get; set; }
		public virtual DbSet<SalesOrderDetail> SalesOrderDetail { get; set; }
		public virtual DbSet<Song> Song { get; set; }
		public virtual DbSet<User> User { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Album>()
				.Property(e => e.AlbumPrice)
				.HasPrecision(6, 2);

			modelBuilder.Entity<Album>()
				.HasMany(e => e.SalesOrderDetail)
				.WithRequired(e => e.Album)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Album>()
				.HasMany(e => e.Song)
				.WithRequired(e => e.Album)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Artist>()
				.HasMany(e => e.Album)
				.WithRequired(e => e.Artist)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Genre>()
				.HasMany(e => e.Album)
				.WithRequired(e => e.Genre)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Role>()
				.HasMany(e => e.User)
				.WithRequired(e => e.Role)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<SalesOrder>()
				.HasMany(e => e.SalesOrderDetail)
				.WithRequired(e => e.SalesOrder)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<SalesOrderDetail>()
				.Property(e => e.AlbumPrice)
				.HasPrecision(6, 2);

			modelBuilder.Entity<User>()
				.HasMany(e => e.SalesOrder)
				.WithRequired(e => e.User)
				.WillCascadeOnDelete(false);
		}
	}
}
