using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int daysStaying = int.Parse(Console.ReadLine());

            double apartmentPriceDay = 0;
            double studioPriceDay = 0;

            double apartmentTotalPrice = 0;
            double studioTotalPrice = 0;

            if (month == "May" || month == "October")
            {
                apartmentTotalPrice = 65 * daysStaying;
                studioTotalPrice = 50 * daysStaying;
            }
            else if (month == "June" || month == "September")
            {
                apartmentTotalPrice = 68.70 * daysStaying;
                studioTotalPrice = 75.2 * daysStaying;
            }
            else if (month == "July" || month == "August")
            {
                apartmentTotalPrice = 77 * daysStaying;
                studioTotalPrice = 76 * daysStaying;
            }



            if ((month == "May" || month == "October") && daysStaying > 7 && daysStaying <= 14)
            {
                studioTotalPrice = studioTotalPrice * 0.95;
                if (daysStaying > 14)
                {
                    apartmentTotalPrice = apartmentTotalPrice * 0.9;
                }
            }
            else if ((month == "May" || month == "October") && daysStaying > 14)
            {
                studioTotalPrice = studioTotalPrice * 0.7;
                if (daysStaying > 14)
                {
                    apartmentTotalPrice = apartmentTotalPrice * 0.9;
                }
            }
            else if ((month == "June" || month == "September") && daysStaying > 14)
            {
                studioTotalPrice = studioTotalPrice * 0.8;
                if (daysStaying > 14)
                {
                    apartmentTotalPrice = apartmentTotalPrice * 0.9;
                }
            }
            else if (daysStaying > 14)
            {
                if (daysStaying > 14)
                {
                    apartmentTotalPrice = apartmentTotalPrice * 0.9;
                }
            }
            Console.WriteLine($"Apartment: {apartmentTotalPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioTotalPrice:f2} lv.");

        }
    }
}
