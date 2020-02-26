using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputEndPointsWithWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int startValue,
                endValue;
            string inValue;
            Console.Write("Enter the beginning value: ");
            inValue = Console.ReadLine();
            if (int.TryParse(inValue, out startValue) == false)
                Console.WriteLine("Invalid input - 0 set for the start value");
            Console.Write("Please enter the last value: ");
            inValue = Console.ReadLine();
            if (int.TryParse(inValue, out endValue) == false)
                Console.WriteLine("Invalid input - 0 set for the end value");
            Console.Write("Sum of values {0} through {1} ", startValue, endValue);
            while (startValue <= endValue)
            {
                sum = sum + startValue;
                startValue++;
            }//end while
            Console.WriteLine("is {0}", sum);
            Console.ReadKey();
        }
    }
}
