using System;

namespace Excursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int sleeps = int.Parse(Console.ReadLine());
            int cards = int.Parse(Console.ReadLine());
            int bilets = int.Parse(Console.ReadLine());
            int sumNights = sleeps * 20;
            double sumCards = cards * 1.6;
            int sumBilets = bilets * 6;
            double sumPerson = sumCards + sumNights + sumBilets;
            double sumAll = sumPerson * people;
            double sumAfterPreparation = sumAll + 0.25 * sumAll;
            Console.WriteLine($"{sumAfterPreparation:f2}");
        }
    }
}
