using System;

namespace Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double bonus;
            if (number <= 100)
            { bonus = 5; }
            else if (number > 1000)
            { bonus = number * 0.1; }
            else 
            { bonus = 0.2 * number; }
            if (number % 2 == 0)
            {
                bonus = bonus + 1;
            }
            else if (number % 10 == 5)
            { bonus = bonus + 2; }
            double sum = number + bonus;
                Console.WriteLine(bonus);
            Console.WriteLine(sum);
        }
    }
}
