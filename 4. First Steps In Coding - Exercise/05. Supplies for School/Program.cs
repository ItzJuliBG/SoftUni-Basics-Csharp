using System;

namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double himikali = double.Parse(Console.ReadLine()) * 5.8;
            double markeri = double.Parse(Console.ReadLine()) * 7.2;
            double preparat = double.Parse(Console.ReadLine()) * 1.2;
            double discount = double.Parse(Console.ReadLine()) / 100;
            double sum = (himikali + markeri + preparat) - ((himikali + markeri + preparat) * discount);
            Console.WriteLine(sum);
        }
    }
}
