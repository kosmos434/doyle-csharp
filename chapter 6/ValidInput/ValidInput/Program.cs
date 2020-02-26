using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidInput
{
    class Program
    {
        static void Main(string[] args)
        {
            int integerValue;
            string inStringValue;

            Console.Write("Enter an integer value: ");
            inStringValue = Console.ReadLine();
            while (int.TryParse(inStringValue, out integerValue) == false)
            {
                Console.WriteLine("Invalid input, dude");
                Console.Write("Please enter a real integer value  ");
                inStringValue = Console.ReadLine();
            }//end while

            Console.WriteLine("Valid value entered: " + integerValue);
            Console.ReadKey();
        }//end main
    }//end class
}//end solution
