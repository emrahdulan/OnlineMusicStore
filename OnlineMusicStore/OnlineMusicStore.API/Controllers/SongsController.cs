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
	public class SongsController : ApiController
	{
		private readonly Model _context = new Model();

		// GET: api/Songs
		public IQueryable<Song> GetSong()
		{
			return _context.Song;
		}

		// GET: api/Songs/5
		[ResponseType(typeof(Song))]
		public IHttpActionResult GetSong(int id)
		{
			Song song = _context.Song.Find(id);
			if (song == null)
			{
				return NotFound();
			}

			return Ok(song);
		}

		//GET: api/Songs/SearchByName/{name?}
		[HttpGet]
		[Route("api/Songs/SearchByName/{name?}")]
		public IEnumerable<SongDto> SearchByName(string name = "")
		{
			var users = _context.Song.Where(s => s.SongTitle.Contains(name)).ToList();

			return users.Select(Mapper.Map<Song, SongDto>);
		}

		// PUT: api/Songs/5
		[ResponseType(typeof(void))]
		public IHttpActionResult PutSong(int id, Song song)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			if (id != song.SongId)
			{
				return BadRequest();
			}

			_context.Entry(song).State = EntityState.Modified;

			try
			{
				_context.SaveChanges();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!SongExists(id))
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

		// POST: api/Songs
		[ResponseType(typeof(Song))]
		public IHttpActionResult PostSong(Song song)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			_context.Song.Add(song);
			_context.SaveChanges();

			return CreatedAtRoute("DefaultApi", new { id = song.SongId }, song);
		}

		// DELETE: api/Songs/5
		[ResponseType(typeof(Song))]
		public IHttpActionResult DeleteSong(int id)
		{
			Song song = _context.Song.Find(id);
			if (song == null)
			{
				return NotFound();
			}

			_context.Song.Remove(song);
			_context.SaveChanges();

			return Ok(song);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				_context.Dispose();
			}
			base.Dispose(disposing);
		}

		private bool SongExists(int id)
		{
			return _context.Song.Count(e => e.SongId == id) > 0;
		}
	}
}