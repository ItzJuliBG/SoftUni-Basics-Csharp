using System;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double budgetUsed = 0;
            if (season == "summer")
            {
                if (budget <= 100)
                {
                    budgetUsed = budget * 0.3;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {budgetUsed:f2}");
                }
                else if (budget > 100 && budget <= 1000)
                {
                    budgetUsed = budget * 0.4;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {budgetUsed:f2}");
                }
                else if (budget > 1000)
                {
                    budgetUsed = budget * 0.9;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine($"Hotel - {budgetUsed:f2}");
                }

            }
            else if (season == "winter")
            {
                if (budget <= 100)
                {
                    budgetUsed = budget * 0.7;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {budgetUsed:f2}");
                }
                else if (budget > 100 && budget <= 1000)
                {
                    budgetUsed = budget * 0.8;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {budgetUsed:f2}");
                }
                else if (budget > 1000)
                {
                    budgetUsed = budget * 0.9;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine($"Hotel - {budgetUsed:f2}");
                }
            }
        }
    }
}
