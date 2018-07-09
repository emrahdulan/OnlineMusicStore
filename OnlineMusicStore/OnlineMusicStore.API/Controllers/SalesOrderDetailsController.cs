using OnlineMusicStore.API.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;

namespace OnlineMusicStore.API.Controllers
{
	public class SalesOrderDetailsController : ApiController
	{
		private readonly Model _context = new Model();

		// GET: api/SalesOrderDetails
		public IQueryable<SalesOrderDetail> GetSalesOrderDetail()
		{
			return _context.SalesOrderDetail;
		}

		// GET: api/SalesOrderDetails/5
		[ResponseType(typeof(SalesOrderDetail))]
		public IHttpActionResult GetSalesOrderDetail(int id)
		{
			SalesOrderDetail salesOrderDetail = _context.SalesOrderDetail.Find(id);
			if (salesOrderDetail == null)
			{
				return NotFound();
			}

			return Ok(salesOrderDetail);
		}

		// PUT: api/SalesOrderDetails/5
		[ResponseType(typeof(void))]
		public IHttpActionResult PutSalesOrderDetail(int id, SalesOrderDetail salesOrderDetail)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			if (id != salesOrderDetail.OrderDetailId)
			{
				return BadRequest();
			}

			_context.Entry(salesOrderDetail).State = EntityState.Modified;

			try
			{
				_context.SaveChanges();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!SalesOrderDetailExists(id))
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

		// POST: api/SalesOrderDetails
		[ResponseType(typeof(SalesOrderDetail))]
		public IHttpActionResult PostSalesOrderDetail(SalesOrderDetail salesOrderDetail)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			_context.SalesOrderDetail.Add(salesOrderDetail);
			_context.SaveChanges();

			return CreatedAtRoute("DefaultApi", new { id = salesOrderDetail.OrderDetailId }, salesOrderDetail);
		}

		// DELETE: api/SalesOrderDetails/5
		[ResponseType(typeof(SalesOrderDetail))]
		public IHttpActionResult DeleteSalesOrderDetail(int id)
		{
			SalesOrderDetail salesOrderDetail = _context.SalesOrderDetail.Find(id);
			if (salesOrderDetail == null)
			{
				return NotFound();
			}

			_context.SalesOrderDetail.Remove(salesOrderDetail);
			_context.SaveChanges();

			return Ok(salesOrderDetail);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				_context.Dispose();
			}
			base.Dispose(disposing);
		}

		private bool SalesOrderDetailExists(int id)
		{
			return _context.SalesOrderDetail.Count(e => e.OrderDetailId == id) > 0;
		}
	}
}