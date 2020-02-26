using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummedValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int number = 1;
            while (number < 11)
            {
                sum = sum + number;
                number++;
            }//end while
            Console.WriteLine("Sum of values "
                                + "1 through 10"
                                + " is " + sum);
            Console.ReadKey();
        }//end main
    }//end class
}//end solution
