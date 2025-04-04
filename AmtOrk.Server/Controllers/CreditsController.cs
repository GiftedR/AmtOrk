using AmtOrk.Server.Data;
using AmtOrk.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AmtOrk.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CreditsController : GenericController<Credit>
{
	public CreditsController(AmtOrkContext context) : base(context, context.Credit)
	{
	}
}
