﻿using System;

namespace Password_Guess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = "s3cr3t!P@ssw0rd";
            if (a == b)
            { Console.WriteLine("Welcome"); }
            else
            { Console.WriteLine("Wrong password!"); }
        }
    }
}
