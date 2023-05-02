namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine();

      

            List<string> games = new List<string>() { "Call Of Duty" , "Roblox", " Rocket League", " Grand T Auto"};

            var NumOfGames = games.OrderBy(name => name.Length);

            foreach ( var game in NumOfGames)
            {
                Console.WriteLine( game);
            }
        }
    }
}
