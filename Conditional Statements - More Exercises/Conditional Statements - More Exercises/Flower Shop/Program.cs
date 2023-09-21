using System;

namespace Flower_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfMagnolias = int.Parse(Console.ReadLine());
            int numberOfHyacinths = int.Parse(Console.ReadLine());
            int numberOfRoses = int.Parse(Console.ReadLine());
            int numberOfCacti = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());
            double sum = numberOfMagnolias * 3.25 + numberOfHyacinths * 4 + numberOfRoses * 3.5 + numberOfCacti * 8;
            double sumWithTax = sum - 0.05 * sum;
            if (sumWithTax>=giftPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(sumWithTax-giftPrice)} leva.");
            }
            else
            Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPrice-sumWithTax)} leva.");
        }
    }
}
