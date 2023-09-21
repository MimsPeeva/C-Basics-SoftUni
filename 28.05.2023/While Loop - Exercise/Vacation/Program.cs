using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            int days = 0;
            int spendCount = 0;
            while (availableMoney<moneyNeeded)
            { 
                string type = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());
                days++;
                 if (type == "spend")
                {
                    spendCount++;
                    if (spendCount == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{days}");
                        break;
                    }
                    availableMoney -= sum;
                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }

                }
                else
                {
                    availableMoney += sum;
                    spendCount = 0;
                   
                }
            }
            if (availableMoney >= moneyNeeded)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
        }
    }
}
