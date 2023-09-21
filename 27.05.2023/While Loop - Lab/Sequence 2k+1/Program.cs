using System;

namespace Sequence_2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nextNumber =1;
            while (nextNumber<=n)
            {
                Console.WriteLine(nextNumber);
                nextNumber = nextNumber * 2 + 1;
                if (nextNumber > n) { break; }

            }
           
           
           
        }
    }
}
