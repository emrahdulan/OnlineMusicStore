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
	public class UsersController : ApiController
	{
		private readonly Model _context = new Model();

		// GET: api/Users
		public IEnumerable<UserDto> GetUser()
		{
			var users = _context.User.Include(u => u.Role).ToList();

			return users.Select(Mapper.Map<User, UserDto>);
		}

		// GET: api/Users/5
		[ResponseType(typeof(User))]
		public IHttpActionResult GetUser(int id)
		{
			var user = _context.User.Find(id);
			if (user == null)
			{
				return NotFound();
			}

			return Ok(user);
		}

		//GET: api/Users/SearchByName/{name?}
		[HttpGet]
		[Route("api/Users/SearchByName/{name?}")]
		public IEnumerable<UserDto> SearchByName(string name = "")
		{
			var users = _context.User.Where(u => u.FirstName.Contains(name) || u.LastName.Contains(name)).ToList();

			return users.Select(Mapper.Map<User, UserDto>);
		}

		//GET: api/Users/GetByUsername/{username}
		[ResponseType(typeof(User))]
		[Route("api/Users/GetByUsername/{username}")]
		public IHttpActionResult GetByUsername(string username)
		{
			var user = _context.User.FirstOrDefault(u => u.Username == username);

			if (user == null)
				return NotFound();
			return Ok(user);
		}

		// PUT: api/Users/5
		[ResponseType(typeof(void))]
		public IHttpActionResult PutUser(int id, User user)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			if (id != user.UserId)
			{
				return BadRequest();
			}

			_context.Entry(user).State = EntityState.Modified;

			try
			{
				_context.SaveChanges();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!UserExists(id))
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

		// POST: api/Users
		[ResponseType(typeof(User))]
		public IHttpActionResult PostUser(User user)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			_context.User.Add(user);
			_context.SaveChanges();

			return CreatedAtRoute("DefaultApi", new { id = user.UserId }, user);
		}

		// DELETE: api/Users/5
		[ResponseType(typeof(User))]
		public IHttpActionResult DeleteUser(int id)
		{
			var user = _context.User.Find(id);
			if (user == null)
			{
				return NotFound();
			}

			_context.User.Remove(user);
			_context.SaveChanges();

			return Ok(user);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				_context.Dispose();
			}
			base.Dispose(disposing);
		}

		private bool UserExists(int id)
		{
			return _context.User.Count(e => e.UserId == id) > 0;
		}
	}
}