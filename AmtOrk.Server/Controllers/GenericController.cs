using AmtOrk.Server.Data;
using AmtOrk.Server.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// Did you know you can make a generic controller and have the other ones inherit from it, way less code (:

namespace AmtOrk.Server.Controllers
{
	// [Authorize]
	public class GenericController<Model> : ControllerBase where Model : RootModel
	{
		protected readonly AmtOrkContext _context;
		protected readonly DbSet<Model> _dbset;

		public GenericController(AmtOrkContext context, DbSet<Model> dbset)
		{
			_context = context;
			_dbset = dbset;
		}

		// GET: api/Models
		[AllowAnonymous]
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Model>>> GetModels()
		{
			return await _dbset.ToListAsync();
		}

		// GET: api/Models/5
		[AllowAnonymous]
		[HttpGet("{id}")]
		public virtual async Task<ActionResult<Model>> GetModel(int id)
		{
			var Model = await _dbset.FindAsync(id);

			if (Model == null)
			{
				return NotFound();
			}

			return Model;
		}

		// PUT: api/Models/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutModel(int id, Model Model)
		{
			if (id != Model.Id)
			{
				return BadRequest();
			}

			_context.Entry(Model).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!ModelExists(id))
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

		// POST: api/Models
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<Model>> PostModel(Model Model)
		{
			_dbset.Add(Model);
			await _context.SaveChangesAsync();

			return CreatedAtAction("GetModel", new { id = Model.Id }, Model);
		}

		// DELETE: api/Models/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteModel(int id)
		{
			var Model = await _dbset.FindAsync(id);
			if (Model == null)
			{
				return NotFound();
			}

			_dbset.Remove(Model);
			await _context.SaveChangesAsync();

			return NoContent();
		}

		private bool ModelExists(int id)
		{
			return _dbset.Any(e => e.Id == id);
		}
	}
}