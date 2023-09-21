using System;

namespace Deer_Of_Santa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodKg = int.Parse(Console.ReadLine());
            double foodFirstKg = double.Parse(Console.ReadLine());
            double foodSecondKg = double.Parse(Console.ReadLine());
            double foodThirdKg = double.Parse(Console.ReadLine());
            double neededFood = days * (foodFirstKg + foodSecondKg + foodThirdKg);
            double diff = Math.Abs(neededFood-foodKg);
            if (foodKg >= neededFood) Console.WriteLine($"{Math.Floor(foodKg - neededFood)} kilos of food left.");
            else Console.WriteLine($"{Math.Ceiling(diff)} more kilos of food are needed.");
        }
    }
}
