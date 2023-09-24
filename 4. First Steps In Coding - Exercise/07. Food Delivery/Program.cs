using System;

namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chickenMenu = double.Parse(Console.ReadLine()) * 10.35;
            double fishMenu = double.Parse(Console.ReadLine()) * 12.40;
            double vegetarianMenu = double.Parse(Console.ReadLine()) * 8.15;
            double totalMenu = chickenMenu + fishMenu + vegetarianMenu;
            double desert = totalMenu * 0.20;
            double deliveryPrice = 2.50;
            double totalPrice = totalMenu + desert + deliveryPrice;
            Console.WriteLine(totalPrice);
        }
    }
}
