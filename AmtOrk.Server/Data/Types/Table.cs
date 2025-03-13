using AmtOrk.Server.Models;
using LiteDB;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace AmtOrk.Server.Data.Types;

public class Table<Model> where Model : notnull, RootModel
{
	private string _tblName { get => typeof(Model).FullName!.ToLower(); }

#region Create
	public async Task<ActionResult<bool>> Add(Model item)
	{
		return await Task.Run(() => AddSync(item));
	}

	public bool AddSync(Model item)
	{
		
		bool result;

		using (LiteDatabase db = new LiteDatabase(Program.ConnectionString))
		{
			var tbl = db.GetCollection<Model>(_tblName);

			tbl.Insert(item);

			result = db.Commit();
		}

		return result;
	}

#endregion
#region Read
	public async Task<ActionResult<IEnumerable<Model>>> ToListAsync()
	{
		Console.WriteLine("ToListAsync ->", typeof(Model).FullName!);
		return await Task.Run(ToList);
	}

	public List<Model> ToList()
	{
		Console.WriteLine("ToList ->", typeof(Model).FullName!);
		List<Model> lst;

		using (LiteDatabase db = new LiteDatabase(Program.ConnectionString))
		{
			lst = db.GetCollection<Model>(_tblName).Query().ToList();
		}

		return lst;
	}

	public async Task<ActionResult<Model?>> FindAsync(int id)
	{
		return await Task.Run(() => Find(id));
	}

	public Model? Find(int id)
	{
		Model? mdl;

		using (LiteDatabase db = new LiteDatabase(Program.ConnectionString))
		{
			List<Model> lst = db.GetCollection<Model>(_tblName).Query()
				.Where(item => item.Id == id)
				.ToList();
			
			mdl = lst.Count < 0 ? null : lst[0];
		}

		return mdl;
	}

	public bool Any(Expression<Func<Model, bool>> lambda)
	{
		bool doesExist = false;

		using (LiteDatabase db = new LiteDatabase(Program.ConnectionString))
		{
			doesExist = db.GetCollection<Model>(_tblName)
				.FindOne(lambda) != null;
		}

		return doesExist;
	}
#endregion
#region Update

	public async Task<ActionResult<bool>> UpdateItem(int id, Model item)
	{
		return await Task.Run(() => UpdateItemSync(id, item));
	}

	public bool UpdateItemSync(int id, Model item)
	{
		bool result;

		using (LiteDatabase db = new LiteDatabase(Program.ConnectionString))
		{
			var col = db.GetCollection<Model>(_tblName);

			result = col.Update(item);
		}

		return result;
	}

#endregion
#region Delete
	public void Remove(Model item)
	{
		using(LiteDatabase db = new LiteDatabase(Program.ConnectionString))
		{
			var col = db.GetCollection<Model>(_tblName);

			col.Delete(item.Id);
		}
	}
#endregion
}