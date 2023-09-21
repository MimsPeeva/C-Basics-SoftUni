using System;

namespace Vegetable_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceForKgVegetables = double.Parse(Console.ReadLine());
            double priceForKvFruits = double.Parse(Console.ReadLine());
            int KgVegetables = int.Parse(Console.ReadLine());
            int KgFruits = int.Parse(Console.ReadLine());
            double sumInLv = priceForKgVegetables * KgVegetables + priceForKvFruits * KgFruits;
            double sumInEu = sumInLv / 1.94;
            Console.WriteLine($"{sumInEu:f2}");
        }
    }
}
