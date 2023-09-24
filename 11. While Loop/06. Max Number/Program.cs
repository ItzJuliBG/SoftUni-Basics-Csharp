using System;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double maxNum = double.MinValue;

            double doubleInput = 0;

            while (input != "Stop")
            {
                doubleInput = double.Parse(input);
                if (doubleInput > maxNum)
                {
                    maxNum = doubleInput;
                }





                input = Console.ReadLine();
            }
            Console.WriteLine(maxNum);
        }
    }
}
