using System;

namespace Series_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int seasons = int.Parse(Console.ReadLine());
            int episodes = int.Parse(Console.ReadLine());
            double episodesNoAdv = double.Parse(Console.ReadLine());
            double timeEpisode = episodesNoAdv + 0.2 * episodesNoAdv;
            double finalEpisode = seasons* 10;
            double minutes = (seasons*timeEpisode*episodes) + finalEpisode;
            Console.WriteLine($"Total time needed to watch the {name} series is {Math.Floor(minutes)} minutes.");
        }
    }
}
