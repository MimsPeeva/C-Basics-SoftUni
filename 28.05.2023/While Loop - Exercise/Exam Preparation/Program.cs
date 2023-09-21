using System;

namespace Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberUnsatisfactoryGrades = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            string lastExercise = string.Empty;
            double sum = 0;
            double average=0;
            int count = 0;
            int countUnsatisfactoryGrades = 0;
            int evaluation;
            while (name != "Enough")
            {
                lastExercise = name;
                evaluation = int.Parse(Console.ReadLine());
               
                if (evaluation <= 4)
                {
                    countUnsatisfactoryGrades++;
                    if (countUnsatisfactoryGrades == numberUnsatisfactoryGrades)
                    { Console.WriteLine($"You need a break, {countUnsatisfactoryGrades} poor grades."); break; }
                }
               
                 
                sum += evaluation;
                count++;
                name = Console.ReadLine();
                average = sum / count;
                
            }
            if (name == "Enough")
            {
                Console.WriteLine($"Average score: {average:f2}");
                Console.WriteLine($"Number of problems: {count}");
                Console.WriteLine($"Last problem: {lastExercise}");
                
            }
        }
    }
}
