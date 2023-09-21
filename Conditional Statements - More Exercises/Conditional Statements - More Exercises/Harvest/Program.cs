using System;

namespace Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int workersNumber = int.Parse(Console.ReadLine());
            double totalKgGrapes = x * y * 0.4;
            double litterswine = totalKgGrapes/2.5;
            double difference = Math.Abs(litterswine-z);
            if (litterswine < z)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(difference)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Abs(litterswine)} liters.");
                Console.WriteLine($"{Math.Ceiling(difference)} liters left -> {Math.Ceiling(difference/workersNumber)} liters per person.");
            }
        }
    }
}
