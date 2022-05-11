using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTesting
{
    internal class MonthlyPayment
    {
        internal static void PaymentCalculation()
        {
            //Taking input from the user for calculation
            Console.Write("Enter the principal loan amount: ");
            double P = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the year: ");
            double Y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the rate of interest: ");
            double R = Convert.ToInt32(Console.ReadLine());

            //The following formulas have been provided in the problem statement for calculation
            double n = 12 * Y;
            double r = R / (12 * 100);
            double z1 = Math.Pow(1 + r, -n);
            //The following is the formula for calculating the payment on th enasis of provided input
            double payment = (P * r) / (1 -z1);

            Console.WriteLine("The derived monthly payment is : {0}",payment);
        }
    }
}
