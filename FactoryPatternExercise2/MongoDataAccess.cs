using System;
namespace FactoryPatternExercise2
{
	public class MongoDataAccess : IDataAccess
	{
        public void LoadData()
        {
            Console.WriteLine($"I am reading data from Mongo Database");
        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data from Mongo Database!");
        }
    }
}

