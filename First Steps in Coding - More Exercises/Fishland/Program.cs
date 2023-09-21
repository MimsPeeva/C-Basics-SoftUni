using System;

namespace Fishland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mackerelPriceForKg = double.Parse(Console.ReadLine());
            double spratFishPriceForKg = double.Parse(Console.ReadLine());
            double kgBonito = double.Parse(Console.ReadLine());
            double kgSafrid = double.Parse(Console.ReadLine());
            int kgMussels = int.Parse(Console.ReadLine());
            double bonitoPriceForKg = +mackerelPriceForKg + 0.6 * mackerelPriceForKg;
            double safridPriceForKg = spratFishPriceForKg + 0.8 * spratFishPriceForKg;
           double musselsPriceForKg = 7.5;
            double sum = kgBonito * bonitoPriceForKg + kgSafrid * safridPriceForKg + kgMussels * musselsPriceForKg;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
