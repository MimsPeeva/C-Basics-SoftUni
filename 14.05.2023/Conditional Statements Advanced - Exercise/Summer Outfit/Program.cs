using System;

namespace Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            if (10 <= degrees && degrees <= 18)
            {
                switch (type)
                {
                    case "Morning": Console.WriteLine($"It's {degrees} degrees, get your Sweatshirt and Sneakers.");break;
                    case "Afternoon": Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins."); break;
                    case "Evening": Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins."); break;
                }
            }
            else if (18 < degrees && degrees <= 24)
            {
                switch (type)
                {
                    case "Morning": Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins."); break;
                    case "Afternoon": Console.WriteLine($"It's {degrees} degrees, get your T-Shirt and Sandals."); break;
                    case "Evening": Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins."); break;
                }
            }
            else if (degrees >= 25)
            {
                switch (type)
                {
                    case "Morning": Console.WriteLine($"It's {degrees} degrees, get your T-Shirt and Sandals."); break;
                    case "Afternoon": Console.WriteLine($"It's {degrees} degrees, get your Swim Suit and Barefoot."); break;
                    case "Evening": Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins."); break;
                }
            }
        }
    }
}
