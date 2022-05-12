using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTesting
{
    public class BinaryConversion
    {
        public static void ToBinary()
        {
            //Taking in input parameters from the users and calling the logic function to compute the logic
            Console.WriteLine("Enter input for conversion of binary:");
            int input = Convert.ToInt32(Console.ReadLine());
            string binary = ToBinaryLogic(input);
            Console.WriteLine("Binary value:" + binary);

        }
         //Creating a separate method/function to host the conversion logic abd the return type is string
        public static string ToBinaryLogic(int input)
        {
            string binary = string.Empty;
            while (input > 0)
            {
                int addBinary = input % 2;
                binary = addBinary + string.Empty + binary;
                input = input / 2;
            }

            return binary;
        }
    }
}
