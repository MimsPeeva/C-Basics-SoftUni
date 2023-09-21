using System;

namespace Painting_Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            string color = Console.ReadLine();
            int lot = int.Parse(Console.ReadLine());
            double sum = 0;
            if (size == "Large")
            {
                switch (color)
                {
                    case "Red": sum += lot * 16; break;
                    case "Green": sum += lot * 12; break;
                    case "Yellow": sum += lot * 9; break;
                }
            }
            else if (size == "Medium")
            {
                switch (color)
                {
                    case "Red": sum += lot * 13; break;
                    case "Green": sum += lot * 9; break;
                    case "Yellow": sum += lot * 7; break;
                }
            }
            else if (size == "Small")
            {
                switch (color)
                {
                    case "Red": sum += lot * 9; break;
                    case "Green": sum += lot * 8; break;
                    case "Yellow": sum += lot * 5; break;
                }
            }
            double sumAfterExpenses = sum - sum * 0.35;
            Console.WriteLine($"{sumAfterExpenses:f2} leva.");
        }
    }
}
