using System;
using System.Transactions;

namespace Sleepy_Tom_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int restDays = int.Parse(Console.ReadLine());
            int daysInYear = 365;
            int norm = 30000;
            int workDays = daysInYear - restDays;
            int sumMin = workDays * 63 + restDays * 127;
            int difference = Math.Abs(norm - sumMin);
            int moreH = Math.Abs(difference/ 60);
            double moreM = Math.Abs(difference% 60);
            
            int lessH = Math.Abs(difference/ 60);
            double lessM = Math.Abs(difference%60);
            if (sumMin >= norm)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{moreH} hours and {moreM} minutes more for play");
            }
            else
            {
                Console.WriteLine($"Tom sleeps well");
                Console.WriteLine($"{lessH} hours and {Math.Round(lessM)} minutes less for play");
            }
            
          
        }
    }
}
