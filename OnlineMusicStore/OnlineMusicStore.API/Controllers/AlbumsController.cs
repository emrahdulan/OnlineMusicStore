using AutoMapper;
using OnlineMusicStore.API.Dto;
using OnlineMusicStore.API.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;

namespace OnlineMusicStore.API.Controllers
{
	public class AlbumsController : ApiController
	{
		private readonly Model _context = new Model();

		// GET: api/Albums
		public IEnumerable<AlbumDto> GetAlbum()
		{
			var albums = _context.Album.Include(a => a.Artist).Include(a => a.Genre).ToList();

			return albums.Select(Mapper.Map<Album, AlbumDto>);
		}

		// GET: api/Albums/5
		[ResponseType(typeof(Album))]
		public IHttpActionResult GetAlbum(int id)
		{
			Album album = _context.Album.Find(id);
			if (album == null)
			{
				return NotFound();
			}

			return Ok(album);
		}

		//GET: api/Albums/SearchByName/{name?}
		[HttpGet]
		[Route("api/Albums/SearchByName/{name?}")]
		public IEnumerable<AlbumDto> SearchByName(string name = "")
		{
			var albums = _context.Album.Where(u => u.AlbumTitle.Contains(name)).ToList();

			return albums.Select(Mapper.Map<Album, AlbumDto>);
		}

		// PUT: api/Albums/5
		[ResponseType(typeof(void))]
		public IHttpActionResult PutAlbum(int id, Album album)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			if (id != album.AlbumId)
			{
				return BadRequest();
			}

			_context.Entry(album).State = EntityState.Modified;

			try
			{
				_context.SaveChanges();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!AlbumExists(id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}

			return StatusCode(HttpStatusCode.NoContent);
		}

		// POST: api/Albums
		[ResponseType(typeof(Album))]
		public IHttpActionResult PostAlbum(Album album)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			_context.Album.Add(album);
			_context.SaveChanges();

			return CreatedAtRoute("DefaultApi", new { id = album.AlbumId }, album);
		}

		// DELETE: api/Albums/5
		[ResponseType(typeof(Album))]
		public IHttpActionResult DeleteAlbum(int id)
		{
			Album album = _context.Album.Find(id);
			if (album == null)
			{
				return NotFound();
			}

			_context.Album.Remove(album);
			_context.SaveChanges();

			return Ok(album);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				_context.Dispose();
			}
			base.Dispose(disposing);
		}

		private bool AlbumExists(int id)
		{
			return _context.Album.Count(e => e.AlbumId == id) > 0;
		}
	}
}