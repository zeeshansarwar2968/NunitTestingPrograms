using System;

namespace NunitTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t Programs for N-Unit Testing");
            Console.WriteLine("");
            Console.WriteLine("1. Find the day of the week");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t Press 0 to exit the program");
            Console.WriteLine("");

            int flag = 0;
            while (flag == 0)
            {
                Console.Write("\nPlease Enter Your Option to choose the program to execute : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        flag = 1;
                        break;
                    case 1:
                        DayofWeek.CalculateDay();
                        break;
                    default:
                        Console.WriteLine("Please Enter from the given choice");
                        break;

                }
            }
        }
    }
}
