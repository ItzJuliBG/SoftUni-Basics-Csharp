using System;

namespace _07._Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int broiNaProekti = int.Parse(Console.ReadLine());
            int neobhotimiChasove = broiNaProekti * 3;
            Console.WriteLine($"The architect {name} will need {neobhotimiChasove} hours to complete {broiNaProekti} project/s.");
        }
    }
}
