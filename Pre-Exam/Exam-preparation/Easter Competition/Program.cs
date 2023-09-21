using System;

namespace Easter_Competition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int backers = int.Parse(Console.ReadLine());
            int winnerPoints = 0;
            string winnerName = "";
            for (int i = 0; i < backers; i++)
            {
                string name = Console.ReadLine();
                string command = Console.ReadLine();
                int backerPoints = 0;
                while (command != "Stop")
                {
                    int points = int.Parse(command);
                    backerPoints+=points;
                    command = Console.ReadLine();
                   
                }
                Console.WriteLine($"{name} has {backerPoints} points.");
                if (backerPoints > winnerPoints)
                { winnerPoints = backerPoints;
                    winnerName = name;
                    Console.WriteLine($"{name} is the new number 1!"); }
                
            }
            Console.WriteLine($"{winnerName} won competition with {winnerPoints} points!");

        }
    }
}
