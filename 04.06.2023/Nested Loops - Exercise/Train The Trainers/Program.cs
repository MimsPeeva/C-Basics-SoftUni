using System;
using System.Diagnostics;

namespace Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int jury = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double average=0;
           int count = 0;
            double totalAverage = 0;
            while (input != "Finish")
            {
                count++;
                for (int i = 0; i < jury; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    
                    average+= grade;
                   
                }
                average = average/ jury;
                Console.WriteLine($"{input} - {average:f2}.");
                totalAverage += average;
                average = 0;
                input = Console.ReadLine();
               
            }
            totalAverage = totalAverage / count;
            Console.WriteLine($"Student's final assessment is {totalAverage:f2}.");
        }
    }
}
