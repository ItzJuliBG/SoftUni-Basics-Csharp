using System;

namespace _09._Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int num1 = 0;
            int num2 = 0;
            for (int i = 0; i < n; i++)
            {
                int consoleNum = int.Parse(Console.ReadLine());
                num1 += consoleNum;
            }
            for (int i = 0; i < n; i++)
            {
                int consoleNum = int.Parse(Console.ReadLine());
                num2 += consoleNum;
            }
            if (num1 == num2)
            {
                Console.WriteLine($"Yes, sum = {num1}");
            }
            else
            {
                int diff = Math.Abs(num2 - num1);
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
