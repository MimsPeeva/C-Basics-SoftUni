using System;

namespace Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double sum = 0;
            if (season == "Spring") { sum = 3000; }
            else if (season == "Summer" || season == "Autumn") { sum = 4200; }
            else if (season == "Winter") { sum = 2600; }
            if (quantity <= 6)
            {
                sum = sum - sum * 0.1;
            }
            else if (quantity >= 7 && quantity <= 11)
            {
                sum = sum - sum * 0.15;
            }
            else if (quantity > 12)
            {
                sum = sum - sum * 0.25;
            }
            if (season == "Spring" || season == "Summer" || season == "Winter")
            {
                if (quantity % 2 == 0)
                {
                    sum = sum - 0.05 * sum;
                }
            }
            if (budget >= sum) Console.WriteLine($"Yes! You have {(budget - sum):f2} leva left.");
            else Console.WriteLine($"Not enough money! You need {Math.Abs(sum-budget):f2} leva.");
        }
    }
}
