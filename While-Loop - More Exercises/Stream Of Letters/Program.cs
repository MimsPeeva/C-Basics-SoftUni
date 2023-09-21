using System;
using System.Linq;

namespace Stream_Of_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string word = string.Empty;
            string finalWord = string.Empty;
            int countC = 0;
            int countO = 0;
            int countN = 0;
            while (input != "End")
            {
                char command = char.Parse(input);
                if (command >= 65 && command <= 90 || command >= 97 && command <= 122)
                {
                    if (command == 'c')
                    {
                        countC++;
                        if (countC > 1)
                            word += 'c';
                    }

                    else if (command == 'o')
                    {
                        countO++;
                        if (countO > 1)
                            word += 'o';
                    }


                    else if (command == 'n')
                    {
                        countN++;
                        if (countN > 1)
                            word += 'n';
                    }
                    else
                        word += command;
                    if (countC >= 1 && countN >= 1 && countO >= 1)
                    {
                        finalWord += (word + ' ');
                        word = string.Empty;
                        countC = 0;
                        countO = 0;
                        countN = 0;
                    }

                }
                input = Console.ReadLine();
            }
            Console.WriteLine(finalWord);
        }
        }
    }

