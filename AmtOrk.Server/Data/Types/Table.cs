using AmtOrk.Server.Models;

namespace AmtOrk.Server.Data.Types;

public class Table<Model> where Model : RootModel
{

	public async Task<IEnumerable<Model>> ToListAsync()
	{
		return AmtOrkContext.Database.GetCollection<Model>().FindAll();
	}

	public async void FindAsync()
	{

	}

	public async void Any()
	{
		
	}
}