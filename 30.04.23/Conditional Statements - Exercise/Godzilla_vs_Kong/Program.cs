using System;

namespace Godzilla_vs_Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfExtras = int.Parse(Console.ReadLine());
            double costOfClothingForOne = double.Parse(Console.ReadLine());
            double decor = 0.1 * budget;
            if (numberOfExtras > 150)
            {
                costOfClothingForOne = costOfClothingForOne - costOfClothingForOne * 0.1;
            }
            double sum = numberOfExtras * costOfClothingForOne + decor;
            if (budget >= sum)
            { 
                double remainder = budget - sum;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {remainder:f2} leva left.");
            }
            else
            {
                double lack = sum - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {lack:f2} leva more.");
            }
           
        }
    }
}
