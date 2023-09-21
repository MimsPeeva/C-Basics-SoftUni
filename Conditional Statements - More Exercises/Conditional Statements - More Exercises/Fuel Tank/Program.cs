using System;
using System.Security.Cryptography;

namespace Fuel_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeFuel = Console.ReadLine();
            double litters = double.Parse(Console.ReadLine());
            if (typeFuel == "Diesel" || typeFuel == "Gasoline" || typeFuel == "Gas")
            {
                if (litters >= 25)
                {
                    Console.WriteLine($"You have enough {typeFuel.ToLower()}.");
                }
                else Console.WriteLine($"Fill your tank with {typeFuel.ToLower()}!");
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
