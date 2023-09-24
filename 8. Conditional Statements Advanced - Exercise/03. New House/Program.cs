using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            double quantityFlower = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double rozaPrice = 5 * quantityFlower;
            double daliaPrice = 3.8 * quantityFlower;
            double lalePrice = 2.8 * quantityFlower;
            double narcisPrice = 3 * quantityFlower;
            double gladiolaPrice = 2.5 * quantityFlower;

            double flowerprice = 0;

            if (flowerType == "Roses" && quantityFlower > 80)
            {

                rozaPrice = rozaPrice * 0.9;
                flowerprice = rozaPrice;
            }
            else if (flowerType == "Dahlias" && quantityFlower > 90)
            {
                daliaPrice = daliaPrice * 0.85;
                flowerprice = daliaPrice;
            }
            else if (flowerType == "Tulips" && quantityFlower > 80)
            {
                lalePrice = lalePrice * 0.85;
                flowerprice = lalePrice;
            }
            else if (flowerType == "Narcissus" && quantityFlower < 120)
            {
                narcisPrice = narcisPrice * 1.15;
                flowerprice = narcisPrice;
            }
            else if (flowerType == "Gladiolus" == quantityFlower < 80)
            {
                gladiolaPrice = gladiolaPrice * 1.2;
                flowerprice = gladiolaPrice;
            }




            if (flowerType == "Roses" && quantityFlower <= 80)
            {


                flowerprice = rozaPrice;
            }
            else if (flowerType == "Dahlias" && quantityFlower <= 90)
            {

                flowerprice = daliaPrice;
            }
            else if (flowerType == "Tulips" && quantityFlower <= 80)
            {

                flowerprice = lalePrice;
            }
            else if (flowerType == "Narcissus" && quantityFlower >= 120)
            {

                flowerprice = narcisPrice;
            }
            else if (flowerType == "Gladiolus" == quantityFlower >= 80)
            {

                flowerprice = gladiolaPrice;
            }

            double flowerPriceTotal = flowerprice;
            if (flowerPriceTotal <= budget)
            {
                double left = budget - flowerprice;
                Console.WriteLine($"Hey, you have a great garden with {quantityFlower} {flowerType} and {left:f2} leva left.");
            }
            else if (budget <= flowerPriceTotal)
            {
                double need = flowerprice - budget;
                Console.WriteLine($"Not enough money, you need {Math.Abs(need):f2} leva more.");
            }
        }
    }
}
