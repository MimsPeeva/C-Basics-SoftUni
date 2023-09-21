using System;

namespace Back_To_The_Past
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inheritedMoney = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int age = 18;

            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 1)
                {
                    inheritedMoney -= 12000 + 50 * age;
                }
                else 
                { inheritedMoney -= 12000; }
                age++;
            }

            if (inheritedMoney >= 0) { Console.WriteLine($"Yes! He will live a carefree life and will have {inheritedMoney:f2} dollars left. "); }
                else Console.WriteLine($"He will need {Math.Abs(inheritedMoney):f2} dollars to survive.");
            }
        }
    }
