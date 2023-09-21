using System;

namespace Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double sum = 0;
            string destination = null;
            string sleepplace = null;
            if (budget <= 100)
            {
                switch (season)
                {
                    case "summer": sum = budget * 0.3; sleepplace = "Camp"; destination = "Bulgaria"; break; 
                     
                    case "winter":sum = budget * 0.7; sleepplace = "Hotel"; destination = "Bulgaria"; break; 
                }
            }
          else  if (budget > 100 && budget <= 1000)
            {
                switch (season)
                {
                    case "summer": sum = budget * 0.4; sleepplace = "Camp"; destination = "Balkans"; break; 
                    case "winter":
                        sum = budget * 0.8; sleepplace = "Hotel"; destination = "Balkans"; break;
                      
                }
            }
            else if (budget > 1000)
            {
                 sum = budget * 0.9;
                 destination = "Europe";
                sleepplace = "Hotel";

            }
            Console.WriteLine($"Somewhere in " + destination); Console.WriteLine($"{sleepplace} - {sum:f2}"); 
           
        }
    }
}
