using System;

namespace Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int nextN = int.Parse(Console.ReadLine());
            int sum = nextN;
            while (true)
            {
                if (sum >= n)
                { break; }
                nextN = int.Parse(Console.ReadLine());
                sum += nextN;
              
            }
            Console.WriteLine(sum);
        }
    }
}
