using System;
using System.Transactions;

namespace Computer_Firm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int computers = int.Parse(Console.ReadLine());
            double sales = 0;
            double average = 0;
            int PossibleSales = 0;
            double cs = 0;
            int rating = 0;
            for (int i = 0; i < computers; i++)
            {
                
                double countSales = 0;
                int number = int.Parse(Console.ReadLine());
                if (number % 10 == 2)
                {
                    rating += 2;
                    PossibleSales = number / 10;
                    sales += 0 * PossibleSales;
                    countSales += sales;
                }
                else if (number % 10 == 3)
                {
                    rating += 3;
                    PossibleSales = number /10;
                    sales += PossibleSales * 0.5;
                    countSales += sales;
                }
                else if (number % 10 == 4)
                {
                    rating += 4;
                    PossibleSales = number / 10;
                    sales += PossibleSales * 0.7;
                    countSales += sales*1;
                }
                else if (number % 10 == 5)
                {
                    rating += 5;
                    PossibleSales = number / 10;
                    sales += PossibleSales * 0.85;
                    countSales += sales;
                }
                else if (number % 10 == 6)
                {
                    rating += 6;
                    PossibleSales = number / 10;
                    sales += PossibleSales ;
                    countSales += sales;
                }
                 average = (double)rating /computers;
                cs = countSales;

               
                
            }
            Console.WriteLine($"{cs:f2}");
            Console.WriteLine($"{average:f2}");
        }
    }
}
