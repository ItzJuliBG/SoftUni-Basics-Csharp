using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int num1 = 0;
            int num2 = 0;
            int sumNum = 0;

            int magicNum = int.Parse(Console.ReadLine());
            bool idk = false;
            int count = 0;
            for (num1 = a; num1 <= z; num1++)
            {
                for (num2 = a; num2 <= z; num2++)
                {
                    count++;
                    sumNum = num1 + num2;
                    if (sumNum == magicNum)
                    {
                        idk = true;
                        Console.WriteLine($"Combination N:{count} ({num1} + {num2} = {magicNum})");
                        break;
                    }


                }
                if (idk == true)
                {
                    break;
                }


            }
            if (idk == false)
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNum}");

            }
        }
    }
}
