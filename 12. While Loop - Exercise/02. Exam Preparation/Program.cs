using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double badGrade = input;
            string inputs = input.ToString();
            double currentGrade = 0;
            double badGradeCount = 0;
            double averageGrade = 0;
            bool idk = false;
            double gradeCount = 0;

            string examName = string.Empty;



            while (inputs != "Enough")
            {
                //    idk = false;
                string test = Console.ReadLine();
                //    examName = Console.ReadLine();
                if (test == "Enough")
                {
                    break;
                }
                examName = test;
                currentGrade = double.Parse(Console.ReadLine());
                averageGrade += currentGrade;
                gradeCount++;
                if (currentGrade <= 4)
                {
                    badGradeCount++;
                }
                if (badGradeCount >= badGrade)
                {
                    idk = true;
                    Console.WriteLine($"You need a break, {badGradeCount} poor grades.");
                    break;
                }


            }
            if (idk == false)
            {
                Console.WriteLine($"Average score: {averageGrade / gradeCount:f2}");
                Console.WriteLine($"Number of problems: {gradeCount}");
                Console.WriteLine($"Last problem: {examName}");
            }

        }
    }
}
