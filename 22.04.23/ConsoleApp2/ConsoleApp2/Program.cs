using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double kvm = double.Parse(Console.ReadLine());
            double sumwithoutd = 7.61 * kvm;
            double discount = sumwithoutd * 0.18;
            double sum = sumwithoutd - discount;
            Console.WriteLine($"The final price is: {sum} lv.");
            Console.WriteLine( $"The discount is: {discount} lv.");
        }
    }
}
