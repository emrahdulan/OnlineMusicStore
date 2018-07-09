using AutoMapper;
using OnlineMusicStore.API.Dto;
using OnlineMusicStore.API.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;

namespace OnlineMusicStore.API.Controllers
{
	public class GenresController : ApiController
	{
		private readonly Model _context = new Model();

		// GET: api/Genres
		public IEnumerable<GenreDto> GetGenre()
		{
			var genres = _context.Genre.ToList();

			return genres.Select(Mapper.Map<Genre, GenreDto>);
		}

		// GET: api/Genres/5
		[ResponseType(typeof(Genre))]
		public IHttpActionResult GetGenre(int id)
		{
			Genre genre = _context.Genre.Find(id);
			if (genre == null)
			{
				return NotFound();
			}

			return Ok(genre);
		}

		// PUT: api/Genres/5
		[ResponseType(typeof(void))]
		public IHttpActionResult PutGenre(int id, Genre genre)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			if (id != genre.GenreId)
			{
				return BadRequest();
			}

			_context.Entry(genre).State = EntityState.Modified;

			try
			{
				_context.SaveChanges();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!GenreExists(id))
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

		// POST: api/Genres
		[ResponseType(typeof(Genre))]
		public IHttpActionResult PostGenre(Genre genre)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			_context.Genre.Add(genre);
			_context.SaveChanges();

			return CreatedAtRoute("DefaultApi", new { id = genre.GenreId }, genre);
		}

		// DELETE: api/Genres/5
		[ResponseType(typeof(Genre))]
		public IHttpActionResult DeleteGenre(int id)
		{
			Genre genre = _context.Genre.Find(id);
			if (genre == null)
			{
				return NotFound();
			}

			_context.Genre.Remove(genre);
			_context.SaveChanges();

			return Ok(genre);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				_context.Dispose();
			}
			base.Dispose(disposing);
		}

		private bool GenreExists(int id)
		{
			return _context.Genre.Count(e => e.GenreId == id) > 0;
		}
	}
}