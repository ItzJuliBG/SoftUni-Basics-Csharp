using System;

namespace _08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dogFood = double.Parse(Console.ReadLine()) * 2.5;
            int catFood = int.Parse(Console.ReadLine()) * 4;
            Console.WriteLine($"{dogFood + catFood} lv.");
        }
    }
}
