using System;

namespace Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double sumStudio = 0;
            double sumApartament = 0;
            if (month == "May" || month == "October")
            {
                sumStudio = 50;
                sumApartament = 65;
            }
            else if (month == "June" || month == "September")
            {
                sumStudio = 75.20;
                sumApartament = 68.7;
            }
            else if (month == "July" || month == "August")
            {
                sumStudio = 76;
                sumApartament = 77;
            }
            double totalPriceStudio = quantity * sumStudio;
            double totalPriceApartament = quantity * sumApartament;
            if (quantity > 14 && (month == "May" || month == "October"))
            {
                totalPriceStudio = totalPriceStudio - totalPriceStudio * 0.3;
            }
            else if (quantity > 7 && (month == "May" || month == "October"))
            {
                totalPriceStudio = totalPriceStudio - totalPriceStudio * 0.05;
            }
            else if (quantity > 14 && (month == "June" || month == "September"))
            {
                totalPriceStudio = totalPriceStudio - totalPriceStudio * 0.2;
            }
            if (quantity > 14 )
            {
                totalPriceApartament = totalPriceApartament- totalPriceApartament * 0.1;
            }
            Console.WriteLine($"Apartment: {totalPriceApartament:f2} lv.");
            Console.WriteLine($"Studio: {totalPriceStudio:f2} lv. ");
        }
    }
}
