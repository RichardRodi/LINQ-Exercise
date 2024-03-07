namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>() { "Fallout", "Stalker", "Helldivers", "Guilty Gear X", "Rocket League", "World of Warcraft" };

            var videoGameList = videoGames.OrderBy(name => name.Length > 4).ToList();
            Console.WriteLine("Here is the list of video games by name length:\n\n");

            foreach (var videoGame in videoGames)
            {
                Console.WriteLine($"{videoGame}");
            }

        }
    }
}
