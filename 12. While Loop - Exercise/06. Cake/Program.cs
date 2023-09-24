using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double weigth = double.Parse(Console.ReadLine());
            double cakePiecesLeft = length * weigth;

            double inputDouble = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    Console.WriteLine($"{cakePiecesLeft} pieces are left.");
                    break;
                }
                inputDouble = double.Parse(input);
                cakePiecesLeft -= inputDouble;
                if (cakePiecesLeft <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cakePiecesLeft)} pieces more.");
                    break;
                }

            }
        }
    }
}
