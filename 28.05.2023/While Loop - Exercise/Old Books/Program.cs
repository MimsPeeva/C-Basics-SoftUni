using System;

namespace Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string searchingBook = Console.ReadLine();
            int count = 0;
            string booksName = string.Empty;
            while (booksName!="No More Books")
            {
                booksName = Console.ReadLine();
                if (searchingBook == booksName)
                {
                    Console.WriteLine($"You checked {count} books and found it.");
                    break;
                }
               count++;
            }
          
            if(booksName=="No More Books")
            {
                count--;
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }
        }
    }
}
