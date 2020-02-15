using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePicker
{
    class Program
    {
        /// <summary>
        /// Switch statements..
        /// used when you have one variable
        /// to run through many tests
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string stateAbbrev;

            Console.WriteLine("enter the state abbreviation");
            Console.WriteLine("its full name will be displayed");
            Console.WriteLine();

            stateAbbrev = Console.ReadLine().ToUpper();

            switch (stateAbbrev)
            {
                case "ALABAMA":                                                 // multiple cases, one statement
                case "BAMA":
                case "AL": Console.WriteLine("alabama...america's mistake");
                    break;
                case "FL":
                    Console.WriteLine("florida...america's mistake");
                    break;
                case "GA":
                    Console.WriteLine("georgia...america's mistake");
                    break;
                case "IL":
                    Console.WriteLine("illinois...america's mistake");
                    break;
                case "KY":
                    Console.WriteLine("kentucky...america's mistake");
                    break;
                case "MI":
                    Console.WriteLine("michigan...america's mistake");
                    break;
                case "OK":
                    Console.WriteLine("oklahomaaa...america's mistake");
                    break;
                case "TX":
                    Console.WriteLine("texas...america's big mistake");
                    break;
                default:
                    Console.WriteLine("no match");
                    break;
            }// end Switch

            Console.ReadKey();
        }
    }
}
