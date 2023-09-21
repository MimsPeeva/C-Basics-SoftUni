using System;

namespace Balls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberBalls = int.Parse(Console.ReadLine());
            int points=0;
            int r = 0;
            int o = 0;
            int y = 0;
            int w = 0;
            int b = 0;
            int other = 0;
            for (int i = 1; i <= numberBalls; i++)
            { 
                string color = Console.ReadLine();
                if (color == "red") { points += 5; r++; }
                else if (color == "orange") { points += 10; o++; }
                else if (color == "yellow") { points += 15; y++; }
                else if (color == "white") { points += 20; w++; }
                else if (color == "black") { points = points/2; b++; }
                else other++;
            }
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Red balls: {r}");
            Console.WriteLine($"Orange balls: {o}");
            Console.WriteLine($"Yellow balls: {y}");
            Console.WriteLine($"White balls: {w}");
            Console.WriteLine($"Other colors picked: {other}");
            Console.WriteLine($"Divides from black balls: {b}");
        }
    }
}
