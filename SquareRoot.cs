using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTesting
{
    internal class SquareRoot
    {
        internal static void Sqrt()
        {
            //Take input from the user
            Console.Write("Enter input for Square Roots : ");
            double input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Approx Square-Root using Newton's Method : " + SqrtLogic(input));

        }
        //create a separate function for the calculation logic
        internal static double SqrtLogic(double c)
        {            
            if (c < 0)
            {
                return double.NaN;
            }

            double t = c;

            while (Math.Abs(t - c / t) > double.Epsilon * t)
            {
                t = ((c / t) + t) / 2.0;
            }
            //t = ((c / t) + t) / 2.0;
            return t;
        }
    }
}
