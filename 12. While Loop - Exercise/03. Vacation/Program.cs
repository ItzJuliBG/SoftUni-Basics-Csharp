using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double availableMoneyInput = double.Parse(Console.ReadLine());
            double availableMoney = availableMoneyInput;
            int timesInRowSpend = 0;
            int days = 0;
            bool idk = false;
            while (availableMoney < neededMoney)
            {
                string spendOrSave = Console.ReadLine();
                days++;
                if (spendOrSave == "spend")
                {
                    double spent = double.Parse(Console.ReadLine());
                    availableMoney -= spent;
                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                    timesInRowSpend++;
                }
                if (timesInRowSpend >= 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(days);
                    idk = true;
                    break;

                }
                if (spendOrSave == "save")
                {
                    double saved = double.Parse(Console.ReadLine());
                    availableMoney += saved;
                    timesInRowSpend = 0;
                }

            }
            if (idk == false)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
            //Console.WriteLine(days);
            //Console.WriteLine(timesInRowSpend);

        }
    }
}
