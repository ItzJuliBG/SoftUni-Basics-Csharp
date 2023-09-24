using System;

namespace _07._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numCR = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < numCR; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                sum += currentNum;
            }
            Console.WriteLine(sum);
        }
    }
}
