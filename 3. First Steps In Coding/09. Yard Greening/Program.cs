using System;

namespace _09._Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kvM = double.Parse(Console.ReadLine());
            double cenaKvM = kvM * 7.61;

            double discount = cenaKvM * 0.18;
            double krainaCena = cenaKvM - discount;
            Console.WriteLine($"The final price is: {krainaCena} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
