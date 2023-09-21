using System;

namespace Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int years = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int birthday = 1; birthday <= years; birthday++)
            {
                if (birthday % 2 == 0)
                {
                    sum += birthday * 5 -1;
                }
                else { sum += toyPrice; } 
            }
          
            if (sum >= price)
            { Console.WriteLine($"Yes! {sum-price:f2}"); }
            else { Console.WriteLine($"No! {price-sum:f2}"); }
           
        }
    }
}
