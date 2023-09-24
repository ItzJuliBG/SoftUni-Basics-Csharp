using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double travelPrice = double.Parse(Console.ReadLine());
            int puzzleCount = int.Parse(Console.ReadLine());
            int dollCount = int.Parse(Console.ReadLine());
            int bearCount = int.Parse(Console.ReadLine());
            int minionCount = int.Parse(Console.ReadLine());
            int truckCount = int.Parse(Console.ReadLine());
            int totalCount = puzzleCount + dollCount + bearCount + minionCount + truckCount;

            double totalPuzzle = puzzleCount * 2.6;
            double totalDoll = dollCount * 3;
            double totalBear = bearCount * 4.1;
            double totalMinion = minionCount * 8.2;
            double totalTruck = truckCount * 2;
            // 52+75+123+410+20

            double totalPrice = totalPuzzle + totalDoll + totalBear + totalMinion + totalTruck;

            if (totalCount >= 50)
            {
                totalPrice = totalPrice * 0.75;
            }

            totalPrice = totalPrice * 0.9;

            if (totalPrice >= travelPrice)
            {
                double left = totalPrice - travelPrice;
                Console.WriteLine($"Yes! {left:f2} lv left.");
            }
            else
            {
                double need = Math.Abs(totalPrice - travelPrice);
                Console.WriteLine($"Not enough money! {need:f2} lv needed.");
            }
        }
    }
}
