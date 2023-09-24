using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int gpuCount = int.Parse(Console.ReadLine());
            int cpuCount = int.Parse(Console.ReadLine());
            int ramCount = int.Parse(Console.ReadLine());

            double gpuPrice = 250 * gpuCount;
            double cpuPrice = cpuCount * (gpuPrice * 0.35);
            double ramPrice = ramCount * (gpuPrice * 0.1);
            double totalPrice = ramPrice + cpuPrice + gpuPrice;

            if (gpuCount > cpuCount)
            {
                totalPrice = totalPrice * 0.85;
            }
            if (budget >= totalPrice)
            {
                double left = budget - totalPrice;
                Console.WriteLine($"You have {left:f2} leva left!");
            }
            else
            {
                double need = Math.Abs(budget - totalPrice);
                Console.WriteLine($"Not enough money! You need {need:f2} leva more!");
            }
        }
    }
}
