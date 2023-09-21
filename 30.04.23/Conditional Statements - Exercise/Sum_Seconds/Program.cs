using System;

namespace Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c1 = int.Parse(Console.ReadLine());
            int c2 = int.Parse(Console.ReadLine());
            int c3 = int.Parse(Console.ReadLine());
            int totalTime = c1 + c2 + c3;
            int minutes = totalTime / 60;
            int seconds = totalTime % 60;
            if (seconds < 10)
            { Console.WriteLine(minutes + ":0" + seconds); }
            else { Console.WriteLine(minutes + ":" + seconds); }
        }
    }
}
