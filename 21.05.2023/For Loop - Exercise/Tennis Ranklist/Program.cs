using System;

namespace Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse((Console.ReadLine()));
            int points = int.Parse((Console.ReadLine()));
            double sum = 0;
            double count = 0;
            for (int i = 0; i < n; i++)
            {
                string type = Console.ReadLine();
                if (type == "W")
                {sum += 2000; count++; }
                else if(type=="F")
                { sum += 1200; }
                else if (type == "SF")
                { sum+= 720; }
               
            }
            sum = sum + points;
            double average = (sum-points) / n;
            double percent = count / n*100;
            Console.WriteLine($"Final points: {sum}");
            Console.WriteLine($"Average points: {Math.Floor(average)}");
            Console.WriteLine($"{percent:f2}%");
        }
    }
}
