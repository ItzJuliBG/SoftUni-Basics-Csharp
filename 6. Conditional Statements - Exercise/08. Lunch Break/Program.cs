using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            double movieLenght = double.Parse(Console.ReadLine());
            double restLenght = double.Parse(Console.ReadLine());
            double lunch = restLenght * 0.125;
            double otdih = restLenght * 0.25;
            double totalTimeNeeded = lunch + otdih + movieLenght;

            if (totalTimeNeeded <= restLenght)
            {
                double left = restLenght - totalTimeNeeded;
                Console.WriteLine($"You have enough time to watch {movie} and left with {Math.Ceiling(left)} minutes free time.");
            }
            else
            {
                double need = Math.Abs(totalTimeNeeded - restLenght);
                need = Math.Ceiling(need);
                Console.WriteLine($"You don't have enough time to watch {movie}, you need {need} more minutes.");
            }

        }
    }
}
