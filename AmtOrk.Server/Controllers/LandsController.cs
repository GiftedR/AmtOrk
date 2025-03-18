using AmtOrk.Server.Data;
using AmtOrk.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AmtOrk.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LandsController : GenericController<Land>
{
	public LandsController(AmtOrkContext context) : base(context, context.Land)
	{
	}
	
	[HttpGet("name/{slug}")]
	public async Task<ActionResult<Land>> GetLandFromSlug(string slug)
	{
		var landList = await _dbset.ToListAsync();
		Land? land = null;
		foreach (Land l in landList)
		{
			if (l.LandSlug == slug)
			{
				land = l;
			}
		}
		if (land == null)
		{
			return NotFound();
		}
		return land;
	}
}
