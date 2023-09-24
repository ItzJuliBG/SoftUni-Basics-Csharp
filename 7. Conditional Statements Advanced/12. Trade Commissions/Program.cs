using System;

namespace _12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sells = double.Parse(Console.ReadLine());

            if (sells >= 0 && sells <= 500)
            {
                if (city == "Sofia")
                {
                    Console.WriteLine($"{sells * 0.05:f2}");
                }
                else if (city == "Varna")
                {
                    Console.WriteLine($"{sells * 0.045:f2}");
                }
                else if (city == "Plovdiv")
                {
                    Console.WriteLine($"{sells * 0.055:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }

            }
            else if (sells > 500 && sells <= 1000)
            {
                if (city == "Sofia")
                {
                    Console.WriteLine($"{sells * 0.07:f2}");
                }
                else if (city == "Varna")
                {
                    Console.WriteLine($"{sells * 0.075:f2}");
                }
                else if (city == "Plovdiv")
                {
                    Console.WriteLine($"{sells * 0.08:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }

            }
            else if (sells > 1000 && sells <= 10000)
            {
                if (city == "Sofia")
                {
                    Console.WriteLine($"{sells * 0.08:f2}");
                }
                else if (city == "Varna")
                {
                    Console.WriteLine($"{sells * 0.1:f2}");
                }
                else if (city == "Plovdiv")
                {
                    Console.WriteLine($"{sells * 0.12:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }

            }
            else if (sells > 10000)
            {
                if (city == "Sofia")
                {
                    Console.WriteLine($"{sells * 0.12:f2}");
                }
                else if (city == "Varna")
                {
                    Console.WriteLine($"{sells * 0.13:f2}");
                }
                else if (city == "Plovdiv")
                {
                    Console.WriteLine($"{sells * 0.145:f2}");
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
        }
    }
}
