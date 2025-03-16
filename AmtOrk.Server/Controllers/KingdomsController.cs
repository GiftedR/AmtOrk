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
}