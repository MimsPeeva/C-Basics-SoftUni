﻿using System;

namespace Fruit_or_Vegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            switch (word)
            { case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                Console.WriteLine("fruit");break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    Console.WriteLine("vegetable"); break;
                default:Console.WriteLine("unknown"); break;
            }
            
            
        }
    }
}
