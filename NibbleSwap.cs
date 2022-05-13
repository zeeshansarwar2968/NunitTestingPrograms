using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTesting
{
    public class NibbleSwap
    {
        public static void NSwap()
        {
            //Taking in input parameters from the users and calling the logic function to compute the logic
            Console.Write("Enter input for conversion of binary:");
            int input = Convert.ToInt32(Console.ReadLine());

            //calling ToBinaryLogic method to convert the input to binary
            string binary = ToBinaryLogic(input);
            Console.WriteLine("Binary value:" + binary);
            
            // Swapping the nibbles and printing the output
            string string1 = binary.Substring(0, binary.Length / 2);
            string string2 = binary.Substring(binary.Length / 2, binary.Length - (binary.Length / 2));
            Console.WriteLine(string1);
            Console.WriteLine(string2);
            Console.WriteLine(Convert.ToInt32(string2 + string1));

            //calling ToDecimalLogic method to convert the swapped value to decimal
            double newBinary = ToDecimalLogic(Convert.ToInt32(string2 + string1));
            Console.WriteLine("After Swapping nibble the new value: " + newBinary);
        }
        //Creating a separate method/function to host the conversion logic from decimal to binary and the return type for this method is string
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

        //Creating a separate method/function to host the conversion logic from binary to decimal and the return type for this method is double
        public static double ToDecimalLogic(int input)
        {
            double decimalValue = 0;
            int count = 0;
            while (input > 0)
            {
                int power = input % 10;
                decimalValue += Math.Pow(2, count) * power;
                input = input / 10;
                count++;
            }

            return decimalValue;
        }
    }
}