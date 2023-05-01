using System;
namespace FactoryPatternExercise2
{
	public class ListDataAccess : IDataAccess
	{
        public void LoadData()
        {
            Console.WriteLine($"I am reading data from List Database");
        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data from List Database!");
        }
    }
}

