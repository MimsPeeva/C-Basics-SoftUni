using System;

namespace Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            if (minutes < 45)
            { minutes = minutes + 15; }
            else if (hour == 23)
            { hour = 0;
                minutes = (minutes + 15) % 60;
            }
            else
            {
                hour = hour + 1;
                minutes = (minutes + 15) % 60;
            }
            if (minutes < 10)
            { Console.WriteLine(hour + ":0" + minutes); }
            else { Console.WriteLine(hour + ":" + minutes); }
        }
    }
}
