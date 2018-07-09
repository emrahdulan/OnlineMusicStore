using OnlineMusicStore.API.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;

namespace OnlineMusicStore.API.Controllers
{
	public class SalesOrdersController : ApiController
	{
		private readonly Model _context = new Model();

		// GET: api/SalesOrders
		public IQueryable<SalesOrder> GetSalesOrder()
		{
			return _context.SalesOrder;
		}

		// GET: api/SalesOrders/5
		[ResponseType(typeof(SalesOrder))]
		public IHttpActionResult GetSalesOrder(int id)
		{
			SalesOrder salesOrder = _context.SalesOrder.Find(id);
			if (salesOrder == null)
			{
				return NotFound();
			}

			return Ok(salesOrder);
		}

		// PUT: api/SalesOrders/5
		[ResponseType(typeof(void))]
		public IHttpActionResult PutSalesOrder(int id, SalesOrder salesOrder)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			if (id != salesOrder.OrderId)
			{
				return BadRequest();
			}

			_context.Entry(salesOrder).State = EntityState.Modified;

			try
			{
				_context.SaveChanges();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!SalesOrderExists(id))
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

		// POST: api/SalesOrders
		[ResponseType(typeof(SalesOrder))]
		public IHttpActionResult PostSalesOrder(SalesOrder salesOrder)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			_context.SalesOrder.Add(salesOrder);

			foreach (var sod in salesOrder.SalesOrderDetail)
			{
				_context.SalesOrderDetail.Add(sod);
			}

			_context.SaveChanges();

			return CreatedAtRoute("DefaultApi", new { id = salesOrder.OrderId }, salesOrder);
		}

		// DELETE: api/SalesOrders/5
		[ResponseType(typeof(SalesOrder))]
		public IHttpActionResult DeleteSalesOrder(int id)
		{
			SalesOrder salesOrder = _context.SalesOrder.Find(id);
			if (salesOrder == null)
			{
				return NotFound();
			}

			_context.SalesOrder.Remove(salesOrder);
			_context.SaveChanges();

			return Ok(salesOrder);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				_context.Dispose();
			}
			base.Dispose(disposing);
		}

		private bool SalesOrderExists(int id)
		{
			return _context.SalesOrder.Count(e => e.OrderId == id) > 0;
		}
	}
}