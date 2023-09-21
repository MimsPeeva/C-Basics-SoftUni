using System;

namespace Match_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
                int peopleQuantity = int.Parse(Console.ReadLine());
            double sum = 0;
            if (peopleQuantity >= 50)
            { sum = budget * 0.25; }
            else if (peopleQuantity >= 25 && peopleQuantity <= 49)
            { sum = budget * 0.4; }
            else if (peopleQuantity >= 10 && peopleQuantity <= 24)
            { sum = budget * 0.5; }
            else if (peopleQuantity >= 5 && peopleQuantity <= 9)
            { sum = budget * 0.6; }
            else if (peopleQuantity >= 1 && peopleQuantity < 4)
            { sum = budget * 0.75; }
            if (category == "VIP") { sum = sum + peopleQuantity * 499.99; }
            else if (category == "Normal") { sum = sum + peopleQuantity * 249.99; }
            if (budget >= sum)
            { Console.WriteLine($"Yes! You have {(budget - sum):f2} leva left."); }
            else { Console.WriteLine($"Not enough money! You need {(sum-budget):f2} leva."); }
        }
    }
}
