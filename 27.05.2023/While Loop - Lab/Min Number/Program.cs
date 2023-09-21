using System;

namespace Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int currentMin = int.MaxValue;
            while (n != "Stop")
            {
                int nextNumber = int.Parse(n);
                if (nextNumber < currentMin) { currentMin = nextNumber; }
                n = Console.ReadLine();
            }
            Console.WriteLine(currentMin);
        }
    }
}
