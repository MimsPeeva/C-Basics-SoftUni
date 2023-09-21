using System;

namespace Training_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            w = w * 100;
            h = h * 100 - 100;
            double mr = Math.Floor(h / 70);
            double wm = Math.Floor(w / 120);
            double sum = Math.Round(mr * wm - 3);
            Console.WriteLine(sum);

        }
    }
}
