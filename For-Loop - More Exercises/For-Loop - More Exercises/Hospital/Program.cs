using System;

namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int targetPatients = 0;
            int untargetPatients = 0;
            for (int i = 1; i <= days; i++)
            {
              
                int doctors = 7;
                
                if (i % 3 == 0)
                {
                    if (untargetPatients > targetPatients)
                    { doctors++; }
                }
                int patients = int.Parse((Console.ReadLine()));
                targetPatients += doctors;
                if (patients > doctors)
                { 
                    untargetPatients += patients - doctors;
                }
               
            }
            Console.WriteLine($"Treated patients: {targetPatients}.");
            Console.WriteLine($"Untreated patients: {untargetPatients}.");
        }
    }
}
