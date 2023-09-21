using System;

namespace Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxValue = int.MinValue;
            int minValue = int.MaxValue;
            for (int i =0; i<n;i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > maxValue)
                { maxValue = number; }
                if (number < minValue)
                { minValue = number; }
            }
            Console.WriteLine($"Max number: {maxValue}");
            Console.WriteLine($"Min number: {minValue}");
        }
    }
}
