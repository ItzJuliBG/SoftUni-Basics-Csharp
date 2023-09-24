using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermanCount = int.Parse(Console.ReadLine());

            double boatRent = 0;

            if (season == "Spring")
            {
                boatRent = 3000;
                if (fishermanCount <= 6)
                {
                    boatRent = boatRent * 0.9;
                }
                else if (fishermanCount >= 7 && fishermanCount <= 11)
                {
                    boatRent = boatRent * 0.85;
                }
                else if (fishermanCount >= 12)
                {
                    boatRent = boatRent * 0.75;
                }

            }
            else if (season == "Summer" || season == "Autumn")
            {
                boatRent = 4200;
                if (fishermanCount <= 6)
                {
                    boatRent = boatRent * 0.9;
                }
                else if (fishermanCount >= 7 && fishermanCount <= 11)
                {
                    boatRent = boatRent * 0.85;
                }
                else if (fishermanCount >= 12)
                {
                    boatRent = boatRent * 0.75;
                }
            }
            else if (season == "Winter")
            {
                boatRent = 2600;
                if (fishermanCount <= 6)
                {
                    boatRent = boatRent * 0.9;
                }
                else if (fishermanCount >= 7 && fishermanCount <= 11)
                {
                    boatRent = boatRent * 0.85;
                }
                else if (fishermanCount >= 12)
                {
                    boatRent = boatRent * 0.75;
                }
            }
            if (season == "Spring" || season == "Summer" || season == "Winter")
            {
                if (fishermanCount % 2 == 0)
                {
                    boatRent = boatRent * 0.95;
                }
            }
            if (budget >= boatRent)
            {
                double left = budget - boatRent;
                Console.WriteLine($"Yes! You have {left:f2} leva left.");
            }
            else
            {
                double need = boatRent - budget;
                Console.WriteLine($"Not enough money! You need {need:f2} leva.");
            }
        }
    }
}
