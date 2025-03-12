namespace FileDB.Tables;

public class Table
{
	protected TableOptions _tbo;

	public Table() : this(new TableOptions()){}

	public Table(TableOptions tableOptions)
	{
		_tbo = tableOptions;
	}
}