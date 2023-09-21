using System;

namespace Care_of_Puppy
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            int food = int.Parse(Console.ReadLine()) * 1000;
            string command = Console.ReadLine();
            int sum = 0;
            while (command != "Adopted")
            {
                int gramsEveryMeal = int.Parse(command);
                 
                sum += gramsEveryMeal;
      
                command = Console.ReadLine();
            }
            if (food >= sum) { Console.WriteLine($"Food is enough! Leftovers: {food-sum} grams."); }
            else Console.WriteLine($"Food is not enough. You need {Math.Abs(sum-food)} grams more.");
        }
    }
}
