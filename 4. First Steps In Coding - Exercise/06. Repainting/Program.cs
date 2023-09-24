using System;

namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nailo = double.Parse(Console.ReadLine()) + 2;
            double nailon = nailo * 1.5;

            double bo = double.Parse(Console.ReadLine());
            double boq = (bo + (bo * 0.10)) * 14.5;

            double torbichki = 0.40;

            int razreditel = int.Parse(Console.ReadLine()) * 5;

            double materiali = boq + nailon + torbichki + razreditel;
            int chasove = int.Parse(Console.ReadLine());
            double maistori = (materiali * 0.3) * chasove;
            double obshto = (materiali + maistori);
            Console.WriteLine(obshto);
        }
    }
}
