using System;

namespace _07._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double num = double.Parse(Console.ReadLine());

            if (figure == "square")
            {
                Console.WriteLine($"{num * num:f2}");
            }
            else if (figure == "rectangle")
            {
                double num2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"{num * num2:f3}");
            }
            else if (figure == "circle")
            {
                //double num3 = Math.Pow(2, num);
                //Console.WriteLine(Math.PI * num3);

                double sum = (num * num) * Math.PI;
                Console.WriteLine($"{sum:f3}");
            }
            else if (figure == "triangle")
            {
                double num4 = double.Parse(Console.ReadLine());
                Console.WriteLine($"{((num4 * num) / 2):f3}");
            }
        }
    }
}
