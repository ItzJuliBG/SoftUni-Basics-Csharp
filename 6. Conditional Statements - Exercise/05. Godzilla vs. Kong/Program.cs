using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            double statistiCount = double.Parse(Console.ReadLine());
            double outfitPrice = double.Parse(Console.ReadLine()) * statistiCount;
            double decorPrice = movieBudget * 0.1;



            if (statistiCount > 150)
            {
                outfitPrice *= 0.9;
            }
            double totalExpenses = decorPrice + outfitPrice;
            double totalBudgetLeft = movieBudget - totalExpenses;



            if (movieBudget >= totalExpenses)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {totalBudgetLeft:f2} leva left.");
            }
            else
            {
                double need = movieBudget - totalExpenses;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(movieBudget - totalExpenses):f2} leva more.");
            }
        }
    }
}
