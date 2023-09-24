using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ticketType = Console.ReadLine();
            int cols = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            int totalCowsRows = cols * rows;

            switch (ticketType)
            {
                case "Premiere":
                    Console.WriteLine($"{12 * totalCowsRows:f2} leva");
                    break;
                case "Normal":
                    Console.WriteLine($"{7.5 * totalCowsRows:f2} leva");
                    break;
                case "Discount":
                    Console.WriteLine($"{5 * totalCowsRows:f2} leva");
                    break;
            }
        }
    }
}
