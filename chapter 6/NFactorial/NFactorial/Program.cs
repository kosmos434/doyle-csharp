using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            string moreData;
            int n;

            DisplayInformation();

            do
            {
                n = InputN();
                CalculateNFactorialIteratively(n, out result);
                //Console.WriteLine("the result is {0}", result);
                DisplayNFactorial(n, result);
                moreData = PromptForMoreCalculations();
            }
            while (moreData == "y" || moreData == "Y");
            Console.ReadKey();
        }//end main

        public static void DisplayInformation()
        {
            Console.WriteLine("n! represents the product of the first n integers");
        }

        public static void CalculateNFactorialIteratively(int n, out int result)
        {
            result = 1;
            for(int i = n; i > 0; i--)
            {
                result *= i;
            }
        }

        public static int InputN()      //input validation
        {
            string inValue;
            int n;

            Console.Write("\nEnter the number to use to compute n! ");
            inValue = Console.ReadLine();
            if (!int.TryParse(inValue, out n))
                Console.WriteLine("Invalid input --> 0 recorded for n");
            return n;
        }

        public static void DisplayNFactorial(int n, int result)
        {
            Console.WriteLine("{0}! is {1}.", n, result);
        }

        public static string PromptForMoreCalculations()
        {
            string moreData;
            Console.WriteLine("\nDo you want another factorial?");
            Console.WriteLine("Enter 'y' for another, any other character to stop");
            moreData = Console.ReadLine();
            return moreData;
        }
    }//end class
}//end solution
