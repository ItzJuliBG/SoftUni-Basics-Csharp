using System;

namespace _08._Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numCount = int.Parse(Console.ReadLine());

            int minNum = int.MaxValue;
            int maxNum = int.MinValue;

            for (int i = 1; i <= numCount; i++)
            {
                int enteredNum = int.Parse(Console.ReadLine());
                if (enteredNum < minNum)
                {
                    minNum = enteredNum;
                }
                if (enteredNum > maxNum)
                {
                    maxNum = enteredNum;
                }
            }
            Console.WriteLine($"Max number: {maxNum}");
            Console.WriteLine($"Min number: {minNum}");
        }
    }
}
