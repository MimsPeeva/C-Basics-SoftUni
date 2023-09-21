using System;

namespace School_Camp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string typeGroup = Console.ReadLine();
            int participants = int.Parse(Console.ReadLine());
            int quantityNights = int.Parse(Console.ReadLine());
            double sum = 0;
            string sport = string.Empty;
            if (season == "Winter")
            {
                if (typeGroup == "girls") { sum = quantityNights * participants * 9.6; sport = "Gymnastics"; }
                else if (typeGroup == "boys") { sum = quantityNights * participants * 9.6; sport = "Judo"; }
                else if (typeGroup == "mixed") { sum = quantityNights * participants * 10; sport = "Ski"; }
            }
            else if (season == "Spring")
            {
                if (typeGroup == "girls") { sum = quantityNights * participants * 7.2; sport = "Athletics"; }
                else if (typeGroup == "boys") { sum = quantityNights * participants * 7.2; sport = "Tennis"; }
                else if (typeGroup == "mixed") { sum = quantityNights * participants * 9.5; sport = "Cycling"; }
            }
            else if (season == "Summer")
            {
                if (typeGroup == "girls") { sum = quantityNights * participants * 15; sport = "Volleyball"; }
                else if (typeGroup == "boys") { sum = quantityNights * participants * 15; sport = "Football"; }
                else if (typeGroup == "mixed") { sum = quantityNights * participants * 20; sport = "Swimming"; }
            }
            if (participants >= 50)
            { sum = sum - sum * 0.5; }
            else if (participants >= 20) { sum = sum - sum * 0.15; }
            else if (participants >= 10) { sum = sum - sum * 0.05; }
            Console.WriteLine($"{sport} {sum:f2} lv.");
        }
    }
}
