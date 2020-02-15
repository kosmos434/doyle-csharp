using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusCalculatorApp
{
    class BonusCalculatorApp
    {
        static void Main(string[] args)
        {
            string inValue;
            decimal salesForYear;
            decimal bonusAmount = 0M;

            Console.WriteLine("are you getting a bonus this year?");
            Console.WriteLine();
            Console.WriteLine("to determine if you are");
            Console.WriteLine("enter your gross sales figure " );

            inValue = Console.ReadLine();
            salesForYear = Convert.ToDecimal(inValue);
            if (salesForYear > 50000.00M)
            {
                Console.WriteLine();
                Console.WriteLine("you got a bonus... nice");
                bonusAmount = 1000.00M;
            }
            Console.WriteLine("bonus for the year: {0:C}", bonusAmount);
            Console.ReadLine();
        }
    }
}
