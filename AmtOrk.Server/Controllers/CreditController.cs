using AmtOrk.Server.Data;
using AmtOrk.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AmtOrk.Server.Controllers
{
	public class TEntity {} // This is here cause it wouldnt let me import a TEntity

	[Route("api/[controller]")]
	[ApiController]
	public class CreditController : ControllerBase
	{
		private readonly AmtOrkContext _context = AmtOrkContext.Instance;

		public CreditController(AmtOrkContext context)
		{

			if (context == null)
			{
				_context = new AmtOrkContext();
			}
			else 
			{
				_context = context;
			}
		}

		// GET: api/Item
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Credit>>> GetAll()
		{
			return await _context.Credit.ToListAsync();
		}

		// GET: api/Item/5
		[HttpGet("{id}")]
		public async Task<ActionResult<Credit>> GetItem(int id)
		{
			var item = await _context.Credit.FindAsync(id);

			if (item == null)
			{
				return NotFound();
			}

			return item!;
		}

		// PUT: api/Item/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutItem(int id, Credit Item)
		{
			if (id != Item.Id)
			{
				return BadRequest();
			}


			// _context.Entry(Item).State = EntityState.Modified;

			try
			{
				await _context.Credit.UpdateItem(id, Item);
			}
			catch (Exception)
			{
				if (!ItemExists(id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}

			return NoContent();
		}

		// POST: api/Item
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<Credit>> PostItem(Credit Item)
		{
			await _context.Credit.Add(Item);

			return CreatedAtAction("GetItem", new { id = Item.Id }, Item);
		}

		// DELETE: api/Item/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteItem(int id)
		{
			var Item = await _context.Credit.FindAsync(id);
			if (Item == null)
			{
				return NotFound();
			}
			var ok = (OkObjectResult)Item.Result!;
			var val = (Credit)ok.Value!;

			_context.Credit.Remove(val);

			return NoContent();
		}

		private bool ItemExists(int id)
		{
			return _context.Credit.Any(e => e.Id == id);
		}
	}
}