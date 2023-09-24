using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double weigth = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());
            double spaceLeft = length * weigth * heigth;

            double inputDouble = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                {
                    Console.WriteLine($"{spaceLeft} Cubic meters left.");
                    break;
                }
                inputDouble = double.Parse(input);
                spaceLeft -= inputDouble;
                if (spaceLeft <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(spaceLeft)} Cubic meters more.");
                    break;
                }

            }
        }
    }
}
