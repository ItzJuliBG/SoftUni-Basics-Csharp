using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingNum = int.Parse(Console.ReadLine());
            int input = int.Parse(Console.ReadLine());
            int sum = 0;
            sum += input;
            while (sum < startingNum)
            {
                input = int.Parse(Console.ReadLine());
                sum += input;

            }
            Console.WriteLine(sum);
        }
    }
}
