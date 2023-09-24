using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string neededBook = input;
            string currentBook = string.Empty;
            int bookCount = 0;

            while (true)
            {

                input = Console.ReadLine();
                if (neededBook == input)
                {
                    Console.WriteLine($"You checked {bookCount} books and found it.");
                    break;
                }
                else if (input == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {bookCount} books.");
                    break;
                }
                {

                }
                bookCount++;
            }
        }
    }
}
