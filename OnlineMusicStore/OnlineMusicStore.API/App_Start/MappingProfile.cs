using AutoMapper;
using OnlineMusicStore.API.Dto;
using OnlineMusicStore.API.Models;

namespace OnlineMusicStore.API.App_Start
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			Mapper.CreateMap<Album, AlbumDto>();
			Mapper.CreateMap<Artist, ArtistDto>();
			Mapper.CreateMap<Genre, GenreDto>();
			Mapper.CreateMap<Role, RoleDto>();
			Mapper.CreateMap<SalesOrder, SalesOrderDto>();
			Mapper.CreateMap<SalesOrderDetail, SalesOrderDetailDto>();
			Mapper.CreateMap<Song, SongDto>();
			Mapper.CreateMap<User, UserDto>();
		}
	}
}