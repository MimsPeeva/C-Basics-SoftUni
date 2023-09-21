using System;

namespace Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double sum1= 0;
            double sum2 = 0;
            double sum3= 0;
            double sum4 = 0;
            double sum5 = 0;
            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (numbers <= 5) { sum1 += numbers; }
                else if (numbers >= 6 && numbers <= 12) { sum2 += numbers; }
                else if (numbers >= 13 && numbers <= 25) { sum3 += numbers; }
                else if (numbers >= 26 && numbers <= 40) { sum4 += numbers; }
                else if (numbers >= 41) { sum5 += numbers; }
            }
            sum = sum1 + sum2 + sum3 + sum4 + sum5;
            double p1 =sum1 / sum * 100;
            double p2 = sum2 / sum * 100;
            double p3 = sum3/sum* 100;
            double p4 = sum4 / sum * 100;
            double p5 = sum5 /sum * 100;
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
