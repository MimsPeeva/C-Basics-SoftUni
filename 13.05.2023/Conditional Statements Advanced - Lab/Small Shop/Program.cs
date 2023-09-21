using System;
using System.Net.Http.Headers;

namespace Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double br = double.Parse(Console.ReadLine());
            double price = 0;
            if (product == "coffee")
            {
                if (town == "Sofia")
                { price = br * 0.5;   }
                else if (town == "Plovdiv") { price = br * 0.4; }
                else if (town == "Varna")
                { price = br * 0.45; }
                
            }
         else   if (product == "water")
            {
                if (town == "Sofia")
                { price = br * 0.8; }
                else if (town == "Plovdiv") { price = br * 0.7; }
                else if (town == "Varna")
                { price = br * 0.7; }

            }
            else  if (product == "beer")
            {
                if (town == "Sofia")
                { price = br * 1.2; }
                else if (town == "Plovdiv") { price = br * 1.15; }
                else if (town == "Varna")
                { price = br * 1.1; }

            }
            else if (product == "sweets")
            {
                if (town == "Sofia")
                { price = br * 1.45; }
                else if (town == "Plovdiv") { price = br * 1.3; }
                else if (town == "Varna")
                { price = br * 1.35; }

            }
            else if (product == "peanuts")
            {
                if (town == "Sofia")
                { price = br * 1.6; }
                else if (town == "Plovdiv") { price = br * 1.5; }
                else if (town == "Varna")
                { price = br * 1.55; }
            }
            Console.WriteLine(price);
        }
    }
}
