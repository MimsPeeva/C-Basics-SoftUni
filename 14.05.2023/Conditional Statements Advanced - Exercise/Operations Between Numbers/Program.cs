using System;

namespace Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            string mathOperator = Console.ReadLine();
            double result = 0;
            switch (mathOperator)
            {
                case "+": result = number1 + number2; if (result % 2 == 0) { Console.WriteLine($"{number1} + {number2} = {result} - even");} else Console.WriteLine($"{number1} + {number2} = {result} - odd");break;
                case "-": result = number1 - number2; if (result % 2 == 0) { Console.WriteLine($"{number1} - {number2} = {result} - even"); } else Console.WriteLine($"{number1} - {number2} = {result} - odd"); break;
                case "*": result = number1 * number2; if (result % 2 == 0) { Console.WriteLine($"{number1} * {number2} = {result} - even"); } else Console.WriteLine($"{number1} * {number2} = {result} - odd"); break;
                case "/": if (number2 == 0) { Console.WriteLine($"Cannot divide {number1} by zero"); } else { result = number1*1.0 / number2; Console.WriteLine($"{number1} / {number2} = {result:F2}"); }break;
                case "%": if (number2 == 0) { Console.WriteLine($"Cannot divide {number1} by zero"); } else { result = number1 % number2; Console.WriteLine($"{number1} % {number2} = {result}"); } break;
            }

            
            
        }
    }
}
