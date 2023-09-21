using System;
using System.Runtime;
using System.Runtime.Intrinsics.X86;

namespace Animal_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string annimal = Console.ReadLine();
            switch(annimal)
            {
                case"dog": Console.WriteLine("mammal"); break;
                case "crocodile": case "tortoise": case "snake": Console.WriteLine("reptile"); break;
                    default: Console.WriteLine("unknown");break;
            }
           
        }
    }
}
