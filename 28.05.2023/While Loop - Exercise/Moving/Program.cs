using System;

namespace Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
           int l = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int roomV = w * l * h;
            string input = Console.ReadLine();
            while (input != "Done")
            {
               
                roomV -= int.Parse(input);
                if (roomV < 0) { break; }
               input = Console.ReadLine();
            }
            if (roomV >= 0)
            { Console.WriteLine($"{roomV} Cubic meters left."); }
            else { Console.WriteLine($"No more free space! You need {Math.Abs(roomV)} Cubic meters more."); }
        }
    }
}
