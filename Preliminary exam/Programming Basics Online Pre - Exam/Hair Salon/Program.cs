using System;

namespace Hair_Salon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int purpose = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double sum = 0;
            while (command != "closed")
            {
                string service = command;
                if (service == "haircut")
                {
                    string type = Console.ReadLine();
                    switch (type)
                    {
                        case "mens": sum += 15; break;
                        case "ladies": sum += 20; break;
                        case "kids": sum += 10; break;
                    }
                }
                else if (service == "color")
                {
                    string coloringType = Console.ReadLine();
                    switch(coloringType)
                    { case "touch up":sum += 20;break;
                        case "full color":sum += 30;break;
                    }
                }
                if (sum >= purpose) { break; }
                command = Console.ReadLine();
            }
            if (sum >= purpose) { Console.WriteLine($"You have reached your target for the day!"); }
            else Console.WriteLine($"Target not reached! You need {purpose-sum}lv. more."); Console.WriteLine($"Earned money: {sum}lv.");
        }
    }
}
