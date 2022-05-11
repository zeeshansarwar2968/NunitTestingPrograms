using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTesting
{
    internal class TemperatureConversion
    {
        internal static void CalculateTemperature()
        {
            //Taking input from the user for calculation
            Console.WriteLine("Available Conversion Choices");
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");
            Console.Write("Please Choose Conversion Option : ");

            int option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                Console.Write("Enter temperature in degC : ");
                double celsius = Convert.ToDouble(Console.ReadLine());

                //Formula to convert deg Celsius to Fahrenheit
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine("Temperature in degree Fahrenheit is : " + fahrenheit + " degree Fahrenheit");
            }
            else if (option == 2)
            {
                Console.Write("Enter temperature in degF : ");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());

                //Formula to convert deg Fahrenheit to Celsius
                double celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine("Temperature in degree Celsius is : " + celsius + " degree Celsius");
            }

            else
            {
                Console.Write("Invalid Selection. Please Choose from the available options");

            }
        }
    }
}
