using System;

namespace Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
           
            int grade=1;
            int poorNoteCount = 0;
            double average = 0;
            double sum = 0;
            while (grade<=12)
            {
                double currentNote = double.Parse(Console.ReadLine());
                if (currentNote < 4) 
                { 
                    poorNoteCount += 1;
                    if (poorNoteCount > 1)
                    {  break; }
                    grade--;
                }
                sum += currentNote;
                grade++;
                average = sum / 12.0;

            }
            if (poorNoteCount > 1)
            { Console.WriteLine($"{name} has been excluded at {grade} grade"); }
            else
            {
                Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
            }
        }
    }
}
