using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTesting
{
    internal class DayofWeek
    {
        public static void CalculateDay()
        {
            //Taking input from the user for calculation
            Console.Write("Please enter the month : ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the day : ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the year : ");
            int year = Convert.ToInt32(Console.ReadLine());

            //We will use the following formulas for calculation of the day as derived from the Gregorian calendar
            int year0 = year - (14 - month) / 12;
            int x = year0 + (year0 / 4) - (year0 / 100) + (year0 / 400);
            int month0 = month + 12 * ((14 - month) / 12) - 2;
            int day0 = (day + x + 31 * month0 / 12) % 7;

            // We have created an array with 0 = Sunday to 6 = Saturday and we will use day0 calculated value to access and find the day
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            Console.WriteLine("Day of the week is : " + days[day0]);
        }
    }
}
