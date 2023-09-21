using System;

namespace World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double wordRecord = double.Parse(Console.ReadLine());
            double distance= double.Parse(Console.ReadLine());
            double timePerMeter= double.Parse(Console.ReadLine());
            double recordByIvan = distance * timePerMeter;
            double delay = distance/ 15;
            recordByIvan+= Math.Floor(delay)*12.5;
            if (recordByIvan < wordRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {recordByIvan:f2} seconds.");
            }
            else 
            {
               double lack = recordByIvan - wordRecord;
                Console.WriteLine($"No, he failed! He was {lack:f2} seconds slower."); 
            }
        }
    }
}
