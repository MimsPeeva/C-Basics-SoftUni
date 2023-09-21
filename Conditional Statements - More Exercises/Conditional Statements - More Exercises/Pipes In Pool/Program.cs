using System;

namespace Pipes_In_Pool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double p1ForHours = p1 * h;
            double p2ForHours = p2 * h;
            double sumP1P2 = p1ForHours + p2ForHours;
            double percentageSum = (sumP1P2 * 100) / v;
            double percentageP1 = (p1ForHours * 100) / sumP1P2;
            double percentageP2 = (p2ForHours * 100) / sumP1P2;
            if (sumP1P2 <= v)
            { Console.WriteLine($"The pool is {percentageSum:f2}% full. Pipe 1: {percentageP1:f2}%. Pipe 2: {percentageP2:f2}%."); }
            else
            { Console.WriteLine($"For {h:f2} hours the pool overflows with {Math.Abs(sumP1P2-v):f2} liters."); }
        }
    }
}
