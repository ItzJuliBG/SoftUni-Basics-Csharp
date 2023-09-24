using System;

namespace _05._Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (city == "Sofia")
            {
                if (item == "coffee")
                {
                    Console.WriteLine(0.5 * quantity);
                }
                if (item == "water")
                {
                    Console.WriteLine(0.8 * quantity);
                }
                if (item == "beer")
                {
                    Console.WriteLine(1.2 * quantity);
                }
                if (item == "sweets")
                {
                    Console.WriteLine(1.45 * quantity);
                }
                if (item == "peanuts")
                {
                    Console.WriteLine(1.6 * quantity);
                }

            }

            else if (city == "Plovdiv")
            {
                if (item == "coffee")
                {
                    Console.WriteLine(0.4 * quantity);
                }
                if (item == "water")
                {
                    Console.WriteLine(0.7 * quantity);
                }
                if (item == "beer")
                {
                    Console.WriteLine(1.15 * quantity);
                }
                if (item == "sweets")
                {
                    Console.WriteLine(1.3 * quantity);
                }
                if (item == "peanuts")
                {
                    Console.WriteLine(1.5 * quantity);
                }

            }

            else if (city == "Varna")
            {
                if (item == "coffee")
                {
                    Console.WriteLine(0.45 * quantity);
                }
                if (item == "water")
                {
                    Console.WriteLine(0.7 * quantity);
                }
                if (item == "beer")
                {
                    Console.WriteLine(1.10 * quantity);
                }
                if (item == "sweets")
                {
                    Console.WriteLine(1.35 * quantity);
                }
                if (item == "peanuts")
                {
                    Console.WriteLine(1.55 * quantity);
                }
            }
        }
    }
}
