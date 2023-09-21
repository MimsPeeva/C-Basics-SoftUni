using System;

namespace Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n =Console.ReadLine();
            int currentMax = int.MinValue;
            while (n != "Stop")
            { 
              int nextNumber = int.Parse(n);
                               if (nextNumber > currentMax) { currentMax= nextNumber; }
                n = Console.ReadLine();
            }
            Console.WriteLine(currentMax);
        }
    }
}
