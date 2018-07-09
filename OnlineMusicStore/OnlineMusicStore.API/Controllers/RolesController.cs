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
	public class RolesController : ApiController
	{
		private readonly Model _context = new Model();

		// GET: api/Roles
		public IEnumerable<RoleDto> GetRole()
		{
			var roles = _context.Role.ToList();

			return roles.Select(Mapper.Map<Role, RoleDto>);
		}

		// GET: api/Roles/5
		[ResponseType(typeof(Role))]
		public IHttpActionResult GetRole(int id)
		{
			Role role = _context.Role.Find(id);
			if (role == null)
			{
				return NotFound();
			}

			return Ok(role);
		}

		// PUT: api/Roles/5
		[ResponseType(typeof(void))]
		public IHttpActionResult PutRole(int id, Role role)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			if (id != role.RoleId)
			{
				return BadRequest();
			}

			_context.Entry(role).State = EntityState.Modified;

			try
			{
				_context.SaveChanges();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!RoleExists(id))
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

		// POST: api/Roles
		[ResponseType(typeof(Role))]
		public IHttpActionResult PostRole(Role role)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			_context.Role.Add(role);
			_context.SaveChanges();

			return CreatedAtRoute("DefaultApi", new { id = role.RoleId }, role);
		}

		// DELETE: api/Roles/5
		[ResponseType(typeof(Role))]
		public IHttpActionResult DeleteRole(int id)
		{
			Role role = _context.Role.Find(id);
			if (role == null)
			{
				return NotFound();
			}

			_context.Role.Remove(role);
			_context.SaveChanges();

			return Ok(role);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				_context.Dispose();
			}
			base.Dispose(disposing);
		}

		private bool RoleExists(int id)
		{
			return _context.Role.Count(e => e.RoleId == id) > 0;
		}
	}
}