namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"What database would you like to use?");

            var answer = Console.ReadLine();

            var newDatabase = DataAccessFactory.GetDataAccessType(answer);

            newDatabase.LoadData();
            newDatabase.SaveData();
           
            
        }
    }
}
