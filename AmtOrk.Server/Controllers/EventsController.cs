using AmtOrk.Server.Data;
using AmtOrk.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace AmtOrk.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EventsController : GenericController<Event>
{
	public EventsController(AmtOrkContext context) : base(context, context.Event)
	{
	}
}
