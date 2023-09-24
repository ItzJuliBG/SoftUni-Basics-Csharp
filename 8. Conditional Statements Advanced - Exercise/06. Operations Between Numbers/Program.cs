using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());

            double totalNum = 0;

            string status = string.Empty;

            //odd or even if
            if (operation == '+')
            {
                totalNum = num1 + num2;
                if (totalNum % 2 == 0)
                {
                    status = "even";
                    Console.WriteLine($"{num1} + {num2} = {totalNum} - {status}");
                }
                else
                {
                    status = "odd";
                    Console.WriteLine($"{num1} + {num2} = {totalNum} - {status}");
                }
            }
            else if (operation == '-')
            {
                totalNum = num1 - num2;
                if (totalNum % 2 == 0)
                {
                    status = "even";
                    Console.WriteLine($"{num1} - {num2} = {totalNum} - {status}");
                }
                else
                {
                    status = "odd";
                    Console.WriteLine($"{num1} - {num2} = {totalNum} - {status}");
                }

            }
            else if (operation == '*')
            {
                totalNum = num1 * num2;
                if (totalNum % 2 == 0)
                {
                    status = "even";
                    Console.WriteLine($"{num1} * {num2} = {totalNum} - {status}");
                }
                else
                {
                    status = "odd";
                    Console.WriteLine($"{num1} * {num2} = {totalNum} - {status}");
                }
            }
            //--------------------------
            if ((operation == '/' || operation == '%') && num2 == 0)
            {
                Console.WriteLine($"Cannot divide {num1} by zero");

            }
            else if (operation == '/')
            {
                totalNum = num1 / num2;
                Console.WriteLine($"{num1} / {num2} = {totalNum:f2}");
            }
            else if (operation == '%')
            {
                totalNum = num1 % num2;
                Console.WriteLine($"{num1} % {num2} = {totalNum}");
            }
        }
    }
}
