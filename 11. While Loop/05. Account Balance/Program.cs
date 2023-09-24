using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double numFromInput = 0.0;
            //         double idk = double.Parse(input);
            double numFromInputOnTime = 0;
            while (input != "NoMoreMoney")

            {
                numFromInputOnTime = double.Parse(input);





                if (numFromInputOnTime < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }


                else
                {
                    numFromInput += double.Parse(input);

                    Console.WriteLine($"Increase: {numFromInputOnTime:f2}");
                    input = Console.ReadLine();
                }


            }
            Console.WriteLine($"Total: {numFromInput:f2}");
        }
    }
}
