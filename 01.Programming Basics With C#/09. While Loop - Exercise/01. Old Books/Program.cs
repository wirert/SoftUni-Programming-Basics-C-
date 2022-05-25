using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string searchBook = Console.ReadLine();
            bool isFound = false;
            int numBooks = 0;
            string currBook;
            while ((currBook = Console.ReadLine()) != "No More Books" )
            {
                
                if (currBook == searchBook)
                {
                    isFound = true;
                    break;
                }
                numBooks++;
            }
            if (isFound)
            {
                Console.WriteLine($"You checked {numBooks} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {numBooks} books.");
            }
        }
    }
}
