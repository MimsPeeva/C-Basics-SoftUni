using System;
using System.Data.Common;
using System.Reflection.Metadata;

namespace Circle_Area_and_Perimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double calculatedparameter = 2 * Math.PI * r;
            double calculatedarea = Math.PI * r * r;
            Console.WriteLine($"{calculatedarea:f2}");
            Console.WriteLine($"{calculatedparameter:f2}");
        }
    }
}
