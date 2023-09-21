using System;

namespace Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();
            int sumPrimeNumbers = 0;
            int sumNotPrimeNumbers = 0;
            while (input != "stop")
            { 
              int n = int.Parse(input);
                if (n < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine(); continue;
                }
                bool isPrrime = true;
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        isPrrime = false;
                        break;
                    }
                }
                if (isPrrime) { sumPrimeNumbers += n; }
                else { sumNotPrimeNumbers += n; }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrimeNumbers}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNotPrimeNumbers}");
        }
    }
}
