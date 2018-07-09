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
	public class ArtistsController : ApiController
	{
		private readonly Model _context = new Model();

		// GET: api/Artists
		public IEnumerable<ArtistDto> GetArtist()
		{
			var artists = _context.Artist.ToList();

			return artists.Select(Mapper.Map<Artist, ArtistDto>);
		}

		// GET: api/Artists/5
		[ResponseType(typeof(Artist))]
		public IHttpActionResult GetArtist(int id)
		{
			var artist = _context.Artist.Find(id);
			if (artist == null)
			{
				return NotFound();
			}

			return Ok(artist);
		}

		//GET: api/Artists/SearchByName/{name?}
		[HttpGet]
		[Route("api/Artists/SearchByName/{name?}")]
		public IEnumerable<ArtistDto> SearchByName(string name = "")
		{
			var artists = _context.Artist.Where(u => u.ArtistName.Contains(name)).ToList();

			return artists.Select(Mapper.Map<Artist, ArtistDto>);
		}

		// PUT: api/Artists/5
		[ResponseType(typeof(void))]
		public IHttpActionResult PutArtist(int id, Artist artist)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			if (id != artist.ArtistId)
			{
				return BadRequest();
			}

			_context.Entry(artist).State = EntityState.Modified;

			try
			{
				_context.SaveChanges();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!ArtistExists(id))
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

		// POST: api/Artists
		[ResponseType(typeof(Artist))]
		public IHttpActionResult PostArtist(Artist artist)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			_context.Artist.Add(artist);
			_context.SaveChanges();

			return CreatedAtRoute("DefaultApi", new { id = artist.ArtistId }, artist);
		}

		// DELETE: api/Artists/5
		[ResponseType(typeof(Artist))]
		public IHttpActionResult DeleteArtist(int id)
		{
			Artist artist = _context.Artist.Find(id);
			if (artist == null)
			{
				return NotFound();
			}

			_context.Artist.Remove(artist);
			_context.SaveChanges();

			return Ok(artist);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				_context.Dispose();
			}
			base.Dispose(disposing);
		}

		private bool ArtistExists(int id)
		{
			return _context.Artist.Count(e => e.ArtistId == id) > 0;
		}
	}
}