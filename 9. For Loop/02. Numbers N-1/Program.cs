using System;

namespace _02._Numbers_N_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for (int b = 1; a >= b; a -= 1)
            {
                Console.WriteLine(a);
            }
        }
    }
}
