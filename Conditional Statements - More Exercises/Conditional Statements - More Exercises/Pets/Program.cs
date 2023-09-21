using System;

namespace Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int leftFood = int.Parse(Console.ReadLine());
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double turtleFood = double.Parse(Console.ReadLine());
            turtleFood = turtleFood*0.001;
            double necessaryFood = (dogFood + catFood + turtleFood)*days;
            double difference = Math.Abs(necessaryFood - leftFood);
            if (necessaryFood <= leftFood)
            {
                Console.WriteLine($"{Math.Floor(difference)} kilos of food left.");
            }
            else Console.WriteLine($"{Math.Ceiling(difference)} more kilos of food are needed.");
        }
    }
}
