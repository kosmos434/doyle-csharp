using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeRead
{
    class Program
    {
        static void Main(string[] args)
        {
            string inValue = "";    //initialized to null
            int sum = 0,
                intValue;
            Console.WriteLine("this program will let you enter");
            Console.WriteLine("value after value. To stop, enter -99");
            Console.WriteLine("\nenter value -99 to exit");
            inValue = Console.ReadLine();       //priming the read!!
            while (inValue != "-99") {
                if (int.TryParse(inValue, out intValue) == false)
                    Console.WriteLine("invalid input - 0 stored in intValue");
                sum += intValue;
                Console.WriteLine("enter value -99 to exit");
                inValue = Console.ReadLine();
            }//end while
            Console.WriteLine("total for all values entered: {0}", sum);
            Console.ReadKey();
        }//end main method 
    }//end class
}//end solution
