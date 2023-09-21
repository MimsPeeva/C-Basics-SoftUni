using System;
using System.Diagnostics.Tracing;
using System.IO;

namespace Transport_Price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            if (time == "day")
            {
                if (n < 20)
                {
                    double taxi = 0.7 + n * 0.79;
                    Console.WriteLine($"{taxi:f2}");
                }
                else if (n >= 20 && n<100)
                {
                    double taxi = 0.7 + n * 0.79;
                    double bus = n * 0.09;
                    if (taxi < bus) Console.WriteLine($"{taxi:f2}");
                    else Console.WriteLine($"{bus:f2}");
                }
                else if (n >= 100)
                {
                    double taxi = 0.7 + n * 0.79;
                    double bus = n * 0.09;
                    double train = n * 0.06;
                    if (taxi < bus && taxi < train) { Console.WriteLine($"{taxi:f2}"); }
                    else if (bus < taxi && bus < train) { Console.WriteLine($"{bus:f2}"); }
                    else if (train<taxi && train<bus)Console.WriteLine($"{train:f2}");
                }
            }
            else if (time == "night")
            {
                if (n < 20)
                {
                    double taxi = 0.7 + n * 0.90;
                    Console.WriteLine($"{taxi:f2}");
                }
                else if (n >= 20 && n<100)
                {
                    double taxi = 0.7 + n * 0.90;
                    double bus = n * 0.09;
                    if (taxi < bus) Console.WriteLine($"{taxi:f2}");
                    else Console.WriteLine($"{bus:f2}");
                }
                else if (n >= 100)
                {
                    double taxi = 0.7 + n * 0.90;
                    double bus = n * 0.09;
                    double train = n * 0.06;
                    Console.WriteLine(taxi);
                    Console.WriteLine(bus);
                    Console.WriteLine(train);
                    if (taxi < bus && taxi < train) { Console.WriteLine($"{taxi:f2}"); }
                    else if (bus < taxi && bus < train) { Console.WriteLine($"{bus:f2}"); }
                    else if (train < taxi && train < bus) Console.WriteLine($"{train:f2}");
                }
            }
           
        }
    }
}
