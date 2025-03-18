using AmtOrk.Server.Data;
using AmtOrk.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AmtOrk.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class KingdomsController : GenericController<Kingdom>
{
	public KingdomsController(AmtOrkContext context) : base(context, context.Kingdom)
	{
	}

	[HttpGet("name/{slug}")]
	public async Task<ActionResult<Kingdom>> GetKingdomFromSlug(string slug)
	{
		// var kingdom = await _dbset.FindAsync((Kingdom k ) => k.KingdomSlug.Equals(slug, StringComparison.InvariantCultureIgnoreCase)); // Couldnt get working
		var kingdomList = await _dbset.ToListAsync();
		Kingdom? kingdom = null;
		foreach (Kingdom k in kingdomList)
		{
			if (k.KingdomSlug == slug)
			{
				kingdom = k;
			}
		}
		if (kingdom == null)
		{
			return NotFound();
		}
		return kingdom;
	}
}