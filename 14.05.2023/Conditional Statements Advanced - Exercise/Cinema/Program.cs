using System;

namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeProjection = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double sum = 0;
            switch (typeProjection)
            {
                case "Premiere": sum = r*c*12 ; Console.WriteLine($"{sum:f2}" + " " + "leva"); break;
                case "Normal": sum = r * c*7.5; Console.WriteLine($"{sum:f2}" + " " + "leva"); break;
                case "Discount": sum = r * c*5; Console.WriteLine($"{sum:f2}" +" "+ "leva"); break;
            }
         
        }
    }
}
