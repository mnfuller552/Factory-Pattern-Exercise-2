using System;
namespace FactoryPatternExercise2
{
	public class SQLDataAccess : IDataAccess
	{
		public void LoadData()
		{
			Console.WriteLine($"I am reading data from SQL Database");
		}

		public void SaveData()
		{
			Console.WriteLine($"I am saving data from SQL Database!");
		}
	}
}

