using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputValuesLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string inValue = ""; //initialized to null
            Console.Write("This program will let you enter");
            Console.Write(" value after value. To stop it, enter");
            Console.WriteLine(" -99, like the number yeah");

            while(inValue!= "-99")
            {
                Console.WriteLine("Enter -99 to exit");
                inValue = Console.ReadLine();
            }//end while
        }//end main
    }//end class
}//end solution
