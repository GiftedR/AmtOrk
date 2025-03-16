using AmtOrk.Server.Data;
using AmtOrk.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace AmtOrk.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LandsController : GenericController<Land>
{
	public LandsController(AmtOrkContext context) : base(context, context.Land)
	{
	}
}
