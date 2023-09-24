using System;

namespace _09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double duljina = double.Parse(Console.ReadLine());
            double shirochina = double.Parse(Console.ReadLine());
            double visochina = double.Parse(Console.ReadLine());

            double obemAkvarium = duljina * shirochina * visochina;

            double obemLitri = obemAkvarium / 1000;
            double zaetoProstranstvo = double.Parse(Console.ReadLine()) / 100;
            double nujniLitri = obemLitri * (1 - zaetoProstranstvo);
            Console.WriteLine(nujniLitri);
        }
    }
}
