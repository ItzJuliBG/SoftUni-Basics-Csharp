using System;

namespace _02._Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            //  int bonus = ;
            double points1 = 0;
            if (points <= 100)
            {
                points1 = 5;
            }
            else if (points > 100 && points <= 1000)
            {
                points1 = (points * 0.2);
            }
            else if (points > 1000)
            {
                points1 = (points * 0.1);
            }
            double points2 = 0;
            if (points % 2 == 0)
            {
                points2 = 1;
            }
            else if (points % 5 == 0)
            {
                points2 = 2;
            }
            else
            {
                points2 = 0;
            }
            Console.WriteLine(points1 + points2);
            Console.WriteLine(points + points1 + points2);
        }
    }
}
