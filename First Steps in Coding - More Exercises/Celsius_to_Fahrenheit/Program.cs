﻿using System;

namespace Celsius_to_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = celsius * 9 / 5 + 32;
            Console.WriteLine($"{fahrenheit:f2}");
        }
    }
}
