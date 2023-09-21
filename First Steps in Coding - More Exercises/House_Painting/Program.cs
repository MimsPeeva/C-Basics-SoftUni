using System;

namespace House_Painting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double consumptionOfGreenPaintPerLiter = 3.4;
            double consumptionOfRedPaintPerLiter = 4.3;
            double walls = 2 * (x * x) + 2 * (x * y) - (2 * 1.2 + 2*1.5*1.5);
            double roof = 2 * (x * y) + 2 * (x * h / 2);
            double wallpainting = walls / consumptionOfGreenPaintPerLiter;
            double roofpainting = roof / consumptionOfRedPaintPerLiter;
            Console.WriteLine($"{wallpainting:f2}");
            Console.WriteLine($"{roofpainting:f2}");
        }
    }
}
