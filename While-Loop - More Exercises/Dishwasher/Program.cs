using System;

namespace Dishwasher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bottles = int.Parse(Console.ReadLine());
            int maxPreparation = 750 * bottles;
            string input = Console.ReadLine();
            int count = 0;
            int pots = 0;
            int dishes = 0;
            while(input!="End")
            {
                count++;
                int quantity = int.Parse(input);
               
                if (count % 3 == 0)
                { pots += quantity; maxPreparation -= 15 * quantity; }
                else
                {
                    dishes += quantity;
                    maxPreparation -= quantity * 5;
                }
                if (maxPreparation<0) { Console.WriteLine($"Not enough detergent, {Math.Abs(maxPreparation)} ml. more necessary!"); break; }
                input = Console.ReadLine();
            }
            if (maxPreparation >= 0)
            {
                Console.WriteLine("Detergent was enough!");
                   Console.WriteLine($"{dishes} dishes and {pots} pots were washed.");
                 Console.WriteLine($"Leftover detergent {maxPreparation} ml.");}
        }
        }
}
