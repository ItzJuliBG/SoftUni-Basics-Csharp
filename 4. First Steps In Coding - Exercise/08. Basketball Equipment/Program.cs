using System;

namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cenaNaTrenirovka = double.Parse(Console.ReadLine());

            double cenaNaKecove = cenaNaTrenirovka * 0.6;
            double cenaNaEkip = cenaNaKecove * 0.8;
            double cenaNaTopka = cenaNaEkip * 0.25;
            double cenaNaAksesoari = cenaNaTopka * 0.20;
            double obshto = cenaNaTrenirovka + cenaNaKecove + cenaNaEkip + cenaNaTopka + cenaNaAksesoari;
            Console.WriteLine(obshto);
        }
    }
}
