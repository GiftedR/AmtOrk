using AmtOrk.Server.Data.Types;
using AmtOrk.Server.EFCore.Extensions;
using AmtOrk.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace AmtOrk.Server.Data;

/// <summary>
/// Handles the database doesnt use Entity Framework, instead uses:
/// <see cref="https://github.com/litedb-org/LiteDB"/>
/// <br />
/// There is another Package that adds entity framework esque migrations, but it is a year old
/// <see cref="https://github.com/JKamsker/LiteDB.Migration"/>
/// </summary>
public class AmtOrkContext : DbContext
{
	public readonly AmtOrkContext Instance;

	public Table<Credit> Credit { get; set; } = default!;

	public AmtOrkContext() : this(new DbContextOptions<AmtOrkContext>())
	{

	}

	public AmtOrkContext(DbContextOptions<AmtOrkContext> options) : base(options) 
	{
		Instance = this;
	}
}