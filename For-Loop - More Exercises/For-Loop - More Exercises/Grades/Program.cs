using System;

namespace Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int students = int.Parse(Console.ReadLine());
            int countTwo = 0;
            int countThree = 0;
            int countFour = 0;
            int countFive = 0;
            double sum = 0;
            for (int i = 1; i <= students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 2.00 && grade <= 2.99)
                { countTwo++; }
                else if (grade >= 3.00 && grade <= 3.99)
                { countThree++; }
                else if (grade >= 4.00 && grade <= 4.99)
                { countFour++; }
                else if (grade >= 5.00 )
                { countFive++; }
                 sum += grade;
            }
            Console.WriteLine($"Top students: {(double)countFive/students*100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(double)countFour /students*100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(double)countThree / students * 100:f2}%");
            Console.WriteLine($"Fail: {(double)countTwo /students*100:f2}%");
            Console.WriteLine($"Average: {sum/students:f2}");
        }
    }
}
