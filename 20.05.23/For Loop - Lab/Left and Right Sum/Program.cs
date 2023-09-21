using System;

namespace Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < n; i++)
            {
                int newNumber = int.Parse(Console.ReadLine());
                leftSum = leftSum + newNumber;
            }
            for (int j = 0; j < n; j++)
            {
                int number = int.Parse((Console.ReadLine()));
                rightSum = rightSum + number;
            }
            if (leftSum == rightSum)
                { Console.WriteLine($"Yes, sum = {leftSum}"); }
                else Console.WriteLine($" No, diff = {Math.Abs(leftSum-rightSum)} ");
            }
        }
    }
