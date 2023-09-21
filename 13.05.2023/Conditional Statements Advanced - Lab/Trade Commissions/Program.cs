using System;

namespace Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double pr = double.Parse(Console.ReadLine());
            double commission = 0;
            if (0 <= pr &&pr<= 500)
            {
                switch (town)
                {
                    case "Sofia": commission = pr * 0.05;Console.WriteLine($"{commission:f2}");break;
                    case "Varna": commission = pr * 0.045; Console.WriteLine($"{commission:f2}"); break;
                    case "Plovdiv": commission = pr * 0.055; Console.WriteLine($"{commission:f2}"); break;
                    default: Console.WriteLine("error"); break;
                }
            }
           else if (500 < pr && pr <= 1000)
            {
                switch (town)
                {
                    case "Sofia": commission = pr * 0.07; Console.WriteLine($"{commission:f2}"); break;
                    case "Varna": commission = pr * 0.075; Console.WriteLine($"{commission:f2}"); break;
                    case "Plovdiv": commission = pr * 0.08; Console.WriteLine($"{commission:f2}"); break;
                    default: Console.WriteLine("error"); break;
                }
            }
          else  if (1000 < pr && pr <= 10000)
            {
                switch (town)
                {
                    case "Sofia": commission = pr * 0.08; Console.WriteLine($"{commission:f2}"); break;
                    case "Varna": commission = pr * 0.10; Console.WriteLine($"{commission:f2}"); break;
                    case "Plovdiv": commission = pr * 0.12; Console.WriteLine($"{commission:f2}"); break;
                    default: Console.WriteLine("error"); break;
                }
            }
          else  if ( pr >= 10000)
            {
                switch (town)
                {
                    case "Sofia": commission = pr * 0.12; Console.WriteLine($"{commission:f2}"); break;
                    case "Varna": commission = pr * 0.13; Console.WriteLine($"{commission:f2}"); break;
                    case "Plovdiv": commission = pr * 0.145; Console.WriteLine($"{commission:f2}"); break;
                    default: Console.WriteLine("error"); break;

                }
            }
            else Console.WriteLine("error"); 
        }
    }
}
