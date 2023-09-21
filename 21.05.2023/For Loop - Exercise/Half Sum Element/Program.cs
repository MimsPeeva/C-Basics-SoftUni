using System;

namespace Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxValue = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > maxValue)
                { maxValue = num; }
            }
                int sumWithoutMax = sum - maxValue;
            if (sumWithoutMax == maxValue)
            {
                Console.WriteLine("Yes"); Console.WriteLine("Sum = " + maxValue);
            }
            else
            {
                int diff = Math.Abs(sumWithoutMax - maxValue);
                Console.WriteLine("No"); Console.WriteLine("Diff = " + diff);
            }
        }
    }
}
