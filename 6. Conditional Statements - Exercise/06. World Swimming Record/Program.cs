using System;

namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordVSekundi = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());

            double zabavqneOtVoda = Math.Floor((meters / 15)) * 12.5;
            double negovoVreme = (meters * secondsPerMeter) + zabavqneOtVoda;
            if (recordVSekundi > negovoVreme)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {negovoVreme:f2} seconds.");
            }
            else
            {
                double need = Math.Abs(recordVSekundi - negovoVreme);
                Console.WriteLine($"No, he failed! He was {need:f2} seconds slower.");
            }
        }
    }
}
