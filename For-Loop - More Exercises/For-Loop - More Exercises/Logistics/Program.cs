using System;

namespace Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numberOfLoads = int.Parse(Console.ReadLine());
            double sumMicrobus = 0;
            double sumTrucks = 0;
            double sumTrain = 0;
            int sumTonsBus=0;
            int sumTonsTrucks=0;
            int sumTonsTrain = 0;
            double sum = 0;
            double sumTons = 0;
            for (int i = 1; i <= numberOfLoads; i++)
            {
                int tons = int.Parse(Console.ReadLine());
                if (tons >=1&&tons<= 3)
                {
                    sumTonsBus += tons;
                    sumMicrobus += tons * 200;
                    
                }
                else if (tons >= 4 && tons <= 11)
                { sumTrucks += tons * 175; sumTonsTrucks += tons; }
                else { sumTrain += tons * 120; sumTonsTrain += tons; }
                 sum = sumTrain + sumMicrobus + sumTrucks;
                 sumTons = sumTonsBus + sumTonsTrain + sumTonsTrucks;
               
            }
           
            Console.WriteLine($"{sum/sumTons:f2}");
            Console.WriteLine($"{sumTonsBus/sumTons*100:f2}%");
            Console.WriteLine($"{sumTonsTrucks / sumTons * 100:f2}%");
            Console.WriteLine($"{sumTonsTrain / sumTons * 100:f2}%");
        }
    }
}
