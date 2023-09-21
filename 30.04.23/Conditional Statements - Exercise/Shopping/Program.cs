using System;

namespace Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCardsNumber = int.Parse(Console.ReadLine());
            int processorsNumber = int.Parse(Console.ReadLine());
            int ramMemoryNumber = int.Parse(Console.ReadLine());
            double videoCardsPrice = 250;
            double sumForVideoCards = videoCardsPrice * videoCardsNumber;
            double processorPrice = 0.35 * sumForVideoCards;
            double sumForProcessors = processorPrice * processorsNumber;
            double ramMemoryPrice  = 0.1 * sumForVideoCards;
            double sumForRamMemory = ramMemoryPrice * ramMemoryNumber;
            double sum = sumForProcessors + sumForVideoCards + sumForRamMemory;
            if (videoCardsNumber >= processorsNumber)
            {
                sum = sum - 0.15 * sum;
            }
            if (budget >= sum)
            {
                Console.WriteLine($"You have {(budget - sum):f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(sum-budget):f2} leva more!");
            }
           
        }
    }
}
