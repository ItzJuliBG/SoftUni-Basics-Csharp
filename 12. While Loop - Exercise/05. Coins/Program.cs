using System;

namespace _05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inputNum = double.Parse(Console.ReadLine());
            double remainingMoney = inputNum;
            double remainingStotinki = inputNum * 100;
            double dvaLea = 200;
            double edinLev = 100;
            double petdesetStotinki = 50;
            double dvadesetStotinki = 20;
            double desetStotinki = 10;
            double petStotinki = 5;
            double dveStotinki = 2;
            double ednaStotinka = 1;

            int monetiUsed = 0;

            while (remainingStotinki >= 0)
            {
                if (remainingStotinki >= dvaLea)
                {
                    remainingStotinki -= 200;
                    monetiUsed++;
                }
                else if (remainingStotinki >= edinLev)
                {
                    remainingStotinki -= 100;
                    monetiUsed++;
                }
                else if (remainingStotinki >= petdesetStotinki)
                {
                    remainingStotinki -= 50;
                    monetiUsed++;
                }
                else if (remainingStotinki >= dvadesetStotinki)
                {
                    remainingStotinki -= 20;
                    monetiUsed++;
                }
                else if (remainingStotinki >= desetStotinki)
                {
                    remainingStotinki -= 10;
                    monetiUsed++;
                }
                else if (remainingStotinki >= petStotinki)
                {
                    remainingStotinki -= 5;
                    monetiUsed++;
                }
                else if (remainingStotinki >= dveStotinki)
                {
                    remainingStotinki -= 2;
                    monetiUsed++;
                }
                else if (remainingStotinki >= ednaStotinka)
                {
                    remainingStotinki -= 1;
                    monetiUsed++;
                }
                else
                {
                    break;
                }


            }
            Console.WriteLine(monetiUsed);
        }
    }
}
