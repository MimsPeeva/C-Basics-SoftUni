using System;

namespace New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double sum = 0;
            if (type == "Roses")
            {
                if (quantity <= 80)
                { sum = quantity * 5; }
                else
                {
                    sum = quantity * 5;
                    sum = sum - sum * 0.1;
                }
            }
            else if(type =="Dahlias")
            {
                if (quantity <= 90)
                { sum = quantity * 3.8; }
                else
                {
                    sum = quantity * 3.8;
                    sum = sum - sum * 0.15; }
            }
            else if (type == "Tulips")
            {
                if (quantity <= 80)
                { sum = quantity * 2.8; }
                else
                {
                    sum = quantity * 2.8;
                    sum = sum - sum * 0.15; }
            }
             else if(type =="Narcissus")
            {
                if (quantity < 120)
                { sum = quantity * 3; sum = sum + sum * 0.15; }
                else
                {
                    sum = quantity * 3;
                    
                }
            }
            else if (type == "Gladiolus")
            {
                if (quantity < 80)
                { sum = quantity * 2.5; sum = sum + sum * 0.2; }
                else
                {
                    sum = quantity * 2.5;
                    
                }
            }
            if (budget >= sum)
            {
                Console.WriteLine($"Hey, you have a great garden with {quantity} {type} and {(budget - sum):f2} leva left.");
            }
            else Console.WriteLine($"Not enough money, you need {Math.Abs(budget - sum):f2} leva more.");
        }
    }
}
