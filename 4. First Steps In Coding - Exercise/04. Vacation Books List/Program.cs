using System;

namespace _04._Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stranici = int.Parse(Console.ReadLine());
            int straniciNaDen = int.Parse(Console.ReadLine());
            int dni = int.Parse(Console.ReadLine());
            int sum = (stranici / straniciNaDen) / dni;
            Console.WriteLine(sum);
        }
    }
}
