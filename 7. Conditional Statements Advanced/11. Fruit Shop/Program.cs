using System;

namespace _11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double fruitprice = 0;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana")
                {
                    fruitprice = 2.5;
                    Console.WriteLine($"{fruitprice * quantity:f2}");
                }
                else if (fruit == "apple")
                {
                    fruitprice = 1.2;
                    Console.WriteLine($"{fruitprice * quantity:f2}");
                }
                else if (fruit == "orange")
                {
                    fruitprice = 0.85;
                    Console.WriteLine($"{fruitprice * quantity:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    fruitprice = 1.45;
                    Console.WriteLine($"{fruitprice * quantity:f2}");
                }
                else if (fruit == "kiwi")
                {
                    fruitprice = 2.7;
                    Console.WriteLine($"{fruitprice * quantity:f2}");
                }
                else if (fruit == "pineapple")
                {
                    fruitprice = 5.5;
                    Console.WriteLine($"{fruitprice * quantity:f2}");
                }
                else if (fruit == "grapes")
                {
                    fruitprice = 3.85;
                    Console.WriteLine($"{fruitprice * quantity:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    fruitprice = 2.7;
                    Console.WriteLine($"{fruitprice * quantity:f2}");
                }
                else if (fruit == "apple")
                {
                    fruitprice = 1.25;
                    Console.WriteLine($"{fruitprice * quantity:f2}");
                }
                else if (fruit == "orange")
                {
                    fruitprice = 0.90;
                    Console.WriteLine($"{fruitprice * quantity:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    fruitprice = 1.60;
                    Console.WriteLine($"{fruitprice * quantity:f2}");
                }
                else if (fruit == "kiwi")
                {
                    fruitprice = 3;
                    Console.WriteLine($"{fruitprice * quantity:f2}");
                }
                else if (fruit == "pineapple")
                {
                    fruitprice = 5.6;
                    Console.WriteLine($"{fruitprice * quantity:f2}");
                }
                else if (fruit == "grapes")
                {
                    fruitprice = 4.2;
                    Console.WriteLine($"{fruitprice * quantity:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            //  Console.WriteLine($"{fruitprice * quantity:f2}");
        }
    }
}
