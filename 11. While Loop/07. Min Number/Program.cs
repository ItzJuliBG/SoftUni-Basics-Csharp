using System;

namespace _07._Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double minNum = double.MaxValue;

            double doubleInput = 0;

            while (input != "Stop")
            {
                doubleInput = double.Parse(input);
                if (doubleInput < minNum)
                {
                    minNum = doubleInput;
                }





                input = Console.ReadLine();
            }
            Console.WriteLine(minNum);
        }
    }
}
