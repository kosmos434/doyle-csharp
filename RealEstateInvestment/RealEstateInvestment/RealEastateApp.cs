using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateInvestment
{
    class RealEastateApp
    {
        static void Main(string[] args)
        {
            const double RENTAL_AMOUNT = 1000.00;

            RealEstateInvestment invest1 = new
                RealEstateInvestment(2004, 150000, "69th Street");
            Console.WriteLine("\tFirst investment");
            invest1.MonthlyExpense = GetExpenses();
            invest1.IncomeFromRent = RENTAL_AMOUNT;
            Console.WriteLine();
            Console.WriteLine("Property Location: {0}",
                invest1.StreetAddress);
            Console.WriteLine("Earnings for the Month {0:C}", +
                invest1.DetermineMonthlyEarnings());
            RealEstateInvestment invest2 = new
                RealEstateInvestment("72 Westchester Ln.", 229000);

            invest2.MonthlyExpense = 900;
            invest2.IncomeFromRent = 1500.00;

            Console.WriteLine("\n\n\tSecond Investment");
            Console.WriteLine(invest2);

            Console.ReadKey();
        }// end Main

        public static double GetExpenses()
        {
            double insurance;
            double taxes;
            double utilities;
            string inValue;     // temporary value

            Console.WriteLine("Yearly insurance: ");
            inValue = Console.ReadLine();
            insurance = double.Parse(inValue);
            Console.WriteLine("Yearly tax: ");
            inValue = Console.ReadLine();
            taxes = double.Parse(inValue);
            Console.WriteLine("Monthly utilities: ");
            inValue = Console.ReadLine();
            utilities = double.Parse(inValue);
            return (insurance / 12 + taxes / 12 + utilities);
        }
    }// end Class
}// end Namespade
