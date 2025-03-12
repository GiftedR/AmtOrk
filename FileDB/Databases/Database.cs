namespace FileDB.Databases;

public class Database
{
	protected DatabaseOptions _dbo;

	public Database() : this(new DatabaseOptions()){}

	public Database(DatabaseOptions databaseOptions)
	{
		_dbo = databaseOptions;
	}
}