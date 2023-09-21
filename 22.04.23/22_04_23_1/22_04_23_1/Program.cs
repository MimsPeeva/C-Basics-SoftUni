using System;

class Program 
{
    static void Main()
    {
        Console.WriteLine("Enter inch:");
        double inch = int.Parse(Console.ReadLine());
        double cm = inch * 2.54;
        Console.WriteLine(cm);
    }
    }
