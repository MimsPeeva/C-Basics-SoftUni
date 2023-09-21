using System;
using System.Diagnostics;

namespace Report_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;


namespace Report_System
    {
        class Program
        {
            static void Main(string[] args)
            {
                double money = double.Parse(Console.ReadLine());
                string product = Console.ReadLine();
                int count = 1;
                double cs = 0;
                double cc = 0;
                int csPeople = 0;
                int ccPeople = 0;
                while (product != "End")
                {
                    int price = int.Parse(product);
                    if (count % 2 == 1)
                    {
                        if (price > 100)
                            Console.WriteLine("Error in transaction!");
                        else
                        {
                            Console.WriteLine("Product sold!");
                            cs += price;
                            csPeople++;
                        }


                    }
                    else if (count % 2 == 0)
                    {
                        if (price < 10)
                            Console.WriteLine("Error in transaction!");
                        else
                        {
                            Console.WriteLine("Product sold!");
                            cc += price;
                            ccPeople++;
                        }
                    }
                    if (cs + cc >= money)
                    {
                        Console.WriteLine($"Average CS: {cs / csPeople:f2}");
                        Console.WriteLine($"Average CC: {cc / ccPeople:f2}");
                        return;
                    }
                    count++;
                    product = Console.ReadLine();
                }
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
   