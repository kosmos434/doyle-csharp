using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1,
                value2,
                largestOne;

            InputValues(out value1, out value2);
            largestOne = DetermineLargest(value1, value2);
            PrintResults(largestOne);
            Console.ReadKey();
        }// end Main


        public static void InputValues(out int v1, out int v2)
        {
            string inValue;

            Console.Write("enter the first value: ");
            inValue = Console.ReadLine();
            if(int.TryParse(inValue, out v1) == false)
            {
                Console.WriteLine("did not input a valid integer - 0 stored in v1");
            }
            Console.Write("enter the second value ");
            inValue = Console.ReadLine();
            if(int.TryParse(inValue, out v2) == false)
            {
                Console.WriteLine("did not input a valid integer - 0 stored in v2");
            }
        }// end InputValues method

        public static int DetermineLargest(int value1, int value2)
        {
            int largestOne;
            if (value1 > value2)
            {
                largestOne = value1;
            }
            else
            {
                largestOne = value2;
            }
            return largestOne;
        }// end DetermineLargest method

        static void PrintResults(int largestOne)
        {
            Console.WriteLine();
            Console.WriteLine("the largest value entered was {0}", largestOne);
            Console.WriteLine("its square root is {0:f2} I guess", Math.Sqrt(largestOne));
            Console.ReadLine();
        }// end PrintResults

    }// end Class

}// end Namespace
