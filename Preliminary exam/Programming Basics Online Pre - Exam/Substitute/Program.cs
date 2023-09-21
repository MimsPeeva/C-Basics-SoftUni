using System;
using System.Security.Authentication.ExtendedProtection;

namespace Substitute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int count = 0;
            bool End = false;

            for (int i = K; i <= 8; i++)
            {
                for (int j = 9; j >= L; j--)
                {
                    for (int q = M; q <= 8; q++)
                    {
                        for (int s = 9; s >= N; s--)
                        {
                            bool isValid = i % 2 == 0 && q % 2 == 0 && j % 2 ==1 && s % 2 ==1;

                            int firstNumber = i * 10 + j;
                            int secondNumber = q * 10 + s;

                            if (isValid && firstNumber == secondNumber)
                            {
                                Console.WriteLine($"Cannot change the same player.");
                            }
                            else if (isValid && firstNumber != secondNumber)
                            {
                                Console.WriteLine($"{i}{j} - {q}{s}");
                                count++;
                            }
                            if (count >= 6)
                            {
                                End = true;
                            }
                            if (End)
                            {
                                break;
                            }
                        }
                        if (End)
                        {
                            break;
                        }
                    }
                    if (End)
                    {
                        break;
                    }
                }
                if (End)
                {
                    break;
                }
            }

        }


    }
}
