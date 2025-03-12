using AmtOrk.Server.Data;
using AmtOrk.Server.Data.Types;
using AmtOrk.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace AmtOrk.Server.Controllers
{
	public class TEntity {} // This is here cause it wouldnt let me import a TEntity

	public class GenericController<M> : ControllerBase where M : RootModel
	{
		protected readonly AmtOrkContext _context;
		protected readonly Table<M> _tbl;

		public GenericController(AmtOrkContext context, Table<M> table)
		{
			_context = context;
			_tbl = table;
		}

		// GET: api/Item
		[HttpGet]
		public async Task<ActionResult<IEnumerable<M>>> GetAll()
		{
			return await _tbl.ToListAsync();
		}

		// GET: api/Item/5
		[HttpGet("{id}")]
		public async Task<ActionResult<M>> GetItem(int id)
		{
			var item = await _tbl.FindAsync(id);

			if (item == null)
			{
				return NotFound();
			}

			return item;
		}

		// PUT: api/Item/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutItem(int id, M Item)
		{
			if (id != Item.Id)
			{
				return BadRequest();
			}

			_context.Entry(Item).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
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
		public async Task<ActionResult<M>> PostItem(M Item)
		{
			_tbl.Add(Item);
			await _context.SaveChangesAsync();

			return CreatedAtAction("GetItem", new { id = Item.Id }, Item);
		}

		// DELETE: api/Item/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteItem(int id)
		{
			var Item = await _tbl.FindAsync(id);
			if (Item == null)
			{
				return NotFound();
			}
			_tbl.Remove(Item);
			await _context.SaveChangesAsync();

			return NoContent();
		}

		private bool ItemExists(int id)
		{
			return _tbl.Any(e => e.Id == id);
		}
	}
}