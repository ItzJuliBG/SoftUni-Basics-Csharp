using System;

namespace _10._Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;
            //int maxNum = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    int conEntered = int.Parse(Console.ReadLine());
            //    sum += conEntered;

            //    if (conEntered > maxNum)
            //    {
            //        maxNum = conEntered;
            //    }
            //}
            //if ((sum / 2) == maxNum)
            //{
            //    Console.WriteLine("Yes");
            //    Console.WriteLine($"Sum = {maxNum}");
            //}
            //else
            //{
            //    int diff = Math.Abs(maxNum - (sum - maxNum));
            //    Console.WriteLine("No");
            //    Console.WriteLine($"Diff = {diff}");
            //}

            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double even = 0;
            double odd = 0;
            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                sum += num;
                if (i % 2 == 0)
                {
                    even += num;
                }
                else
                {
                    odd += num;
                }
            }
            if (even == odd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {odd}");
            }
            else
            {
                double diff = Math.Abs(even - odd);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
