using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inch_to_cm
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter inch:");
            double inch = int.Parse(Console.ReadLine());
            double cm = inch * 2.54;

        }
    }
}
