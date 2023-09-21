using System;

namespace Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isBigger = false;
            int counter = 1;
            for (int rows = 1;rows<=n;rows++)
            {
                if (isBigger) { break; }Console.WriteLine();
                for (int cols = 1; cols <= rows; cols++)
                {
                    if (counter > n) { isBigger = true; break; }
                    Console.Write($"{counter + " "}");counter++;
                }
              
            }
        }
    }
}
