using System;

namespace Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int numberEvaluative = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberEvaluative; i++)
            {
                string nameEvaluative = Console.ReadLine();
                double pointsFromE = double.Parse(Console.ReadLine());
                points +=nameEvaluative.Length*pointsFromE/2;
                if (points >= 1250.5)
                { Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {points:f1}!"); break; }
               
            }
             if (points < 1250.5) { Console.WriteLine($"Sorry, {name} you need {1250.5 - points:f1} more!"); }
        }
    }
}
