using System;

namespace Fuel_Tank___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeFuel = Console.ReadLine();
            double litters = double.Parse(Console.ReadLine());
            string Card = Console.ReadLine();
            double sum;
            if (typeFuel == "Gas")
            {
                sum = litters * 0.93;
                if (Card == "Yes")
                {
                    sum = litters * (0.93 - 0.08);
                }
                if (litters >= 20 && litters <= 25)
                {
                    sum = sum - sum * 0.08;
                }
                else if (litters >= 26) { sum = sum - sum * 0.1; }
                Console.WriteLine($"{sum:f2} lv.");
            }
            if (typeFuel == "Gasoline")
            {
                sum = litters * 2.22;
                if (Card == "Yes")
                {
                    sum = litters * (2.22 - 0.18);
                }
                if (litters >= 20 && litters <= 25)
                {
                    sum = sum - sum * 0.08;
                }
                else if (litters >= 26) { sum = sum - sum * 0.1; }
                Console.WriteLine($"{sum:f2} lv.");
            }
            if (typeFuel == "Diesel")
            {
                sum = litters * 2.33;
                if (Card == "Yes")
                {
                    sum = litters * (2.33 - 0.12);
                }
                if (litters >= 20 && litters <= 25)
                {
                    sum = sum - sum * 0.08;
                }
                else if (litters >= 26) { sum = sum - sum * 0.1; }
                Console.WriteLine($"{sum:f2} lv.");
            }
        }
        }
    }

