using System;

namespace Bike_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityJuniors = int.Parse(Console.ReadLine());
            int quantitySeniors = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            double sum = 0;
            int sumPeople = quantitySeniors + quantityJuniors;
            switch (type)
            {
                case "trail":sum = quantityJuniors * 5.5 + quantitySeniors * 7; break;
                case "cross-country": sum = quantityJuniors * 8 + quantitySeniors * 9.5; break;
                case "downhill": sum = quantityJuniors * 12.25 + quantitySeniors * 13.75; break;
                case "road": sum = quantityJuniors * 20 + quantitySeniors * 21.5; break;
            }
            if (type == "cross-country" && sumPeople >= 50) { sum = sum - sum * 0.25; }
            sum = sum - sum * 0.05;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
