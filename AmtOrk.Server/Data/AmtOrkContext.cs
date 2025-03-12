using AmtOrk.Server.Data.Types;
using AmtOrk.Server.Models;
using LiteDB;

namespace AmtOrk.Server.Data;

/// <summary>
/// Handles the database doesnt use Entity Framework, instead uses:
/// <see cref="https://github.com/litedb-org/LiteDB"/>
/// </summary>
public class AmtOrkContext
{
	private LiteDatabase _ldb;

	public Table<Credit> Credit { get; set; } = default!;

	public AmtOrkContext()
	{
		_ldb = new LiteDatabase(@"AmtOrk.db");
	}

	~AmtOrkContext()
	{

	}

	public void SaveChangesAsync()
	{
		
	}
}