using System;

namespace Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine();
            int filmTime = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());
            double timeForLunch = 0.125 * breakTime;
            double timeForRecreation = 0.25 * breakTime;
            double timeLeft = breakTime - (timeForLunch + timeForRecreation);
            if (timeLeft >= filmTime)
            {
                Console.WriteLine($"You have enough time to watch {filmName} and left with {Math.Ceiling(timeLeft - filmTime)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {filmName}, you need {Math.Ceiling(Math.Abs(filmTime-timeLeft))} more minutes.");
            }
        }
    }
}
