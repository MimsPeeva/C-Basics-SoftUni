using System;

namespace Skeleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int minutes = int.Parse(Console.ReadLine());
           int seconds = int.Parse(Console.ReadLine());    
            double lengh = double.Parse(Console.ReadLine());
           int sec100m = int.Parse(Console.ReadLine());
            int control = minutes * 60 + seconds;
            double timedown = (lengh / 120)*2.5;
            double timeMarin = (lengh/100)*sec100m - timedown;
            if (timeMarin <= control)
            { Console.WriteLine($"Marin Bangiev won an Olympic quota!"); Console.WriteLine($"His time is {timeMarin:f3}."); }
            else Console.WriteLine($"No, Marin failed! He was {Math.Abs(control-timeMarin):f3} second slower.");
        }
    }
}
