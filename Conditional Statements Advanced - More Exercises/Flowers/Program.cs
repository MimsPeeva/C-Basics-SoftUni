using System;

namespace Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemums = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();
            double sumCh = 0;
            double sumRoses = 0;
            double sumTulips = 0;
            int quantity = chrysanthemums + roses + tulips;
            switch (season)
            {
                case "Spring":
                case "Summer": sumCh = chrysanthemums * 2; sumRoses = roses * 4.1; sumTulips = tulips * 2.5; break;
                case "Autumn":
                case "Winter": sumCh = chrysanthemums * 3.75; sumRoses = roses * 4.5; sumTulips = tulips * 4.15; break;
            }
            double sumFlowers = sumCh + sumRoses + sumTulips;
            if (holiday == "Y") { sumFlowers = sumFlowers + sumFlowers * 0.15; }
            if (tulips >= 7 && season =="Spring") { sumFlowers = sumFlowers - sumFlowers * 0.05; }
            if (roses >= 10 && season == "Winter") { sumFlowers = sumFlowers - sumFlowers * 0.1; }
            if (quantity >= 20) { sumFlowers = sumFlowers - sumFlowers * 0.2; }
            double sum = sumFlowers + 2;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
