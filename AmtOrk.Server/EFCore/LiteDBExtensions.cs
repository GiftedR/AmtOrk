using LiteDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace AmtOrk.Server.EFCore.Extensions;

public static class LiteDBServiceExtension
{
	public static DbContextOptionsBuilder AddLiteDB(this DbContextOptionsBuilder options, string databasePath)
	{
		// Something needs to go here

		return options;
	}
}

public class LiteDBContext
{
	public readonly LiteDatabase Context;
	public LiteDBContext(IOptions<LiteDBConfig> configs)
	{
		try
		{
			LiteDatabase db = new(configs.Value.DatabasePath);
			if (db != null) Context = db;
		}
		catch (Exception ex)
		{
			throw new Exception("Can't find or create LiteDB database. ", ex);
		}
	}
}

public class LiteDBConfig
{
	public string DatabasePath { get; set; }
}