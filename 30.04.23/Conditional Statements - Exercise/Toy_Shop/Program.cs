using System;

namespace Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double HolidayPrice = double.Parse(Console.ReadLine());
            int numberOfPuzzles = int.Parse(Console.ReadLine());
            int numberOfTalkingDolls = int.Parse(Console.ReadLine());
            int numberOfTeddyBears = int.Parse(Console.ReadLine());
            int numberOfMinions = int.Parse(Console.ReadLine());
            int numberOfTrucks = int.Parse(Console.ReadLine());
            int numberOfToys = numberOfPuzzles + numberOfTalkingDolls + numberOfTeddyBears + numberOfMinions + numberOfTrucks;
            double sum = 2.6 * numberOfPuzzles + 3 * numberOfTalkingDolls + 4.1 * numberOfTeddyBears + 8.2 * numberOfMinions + 2 * numberOfTrucks;
            if (numberOfToys >= 50)
            {
                sum = sum - 0.25 * sum;
            }
            double rent = 0.1 * sum;
            double moneyLeftOver = sum - rent;
            if (moneyLeftOver >= HolidayPrice)
            {
                double remainder = moneyLeftOver - HolidayPrice;
                Console.WriteLine($"Yes! {remainder:f2} lv left.");
            }
            else
            {
                double lack = HolidayPrice - moneyLeftOver;
                Console.WriteLine($"Not enough money! {lack:f2} lv needed.");
            }
        }
    }
}
