using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanApplication
{
    class LoanApp
    {
        static void Main(string[] args)
        {
            int years;
            double loanAmount;
            double interestRate;
            string inValue;
            char anotherLoan = 'N';

            do
            {
                GetInputValues(out loanAmount, out interestRate, out years);

                Loan ln = new Loan(loanAmount, interestRate, years);
                Console.WriteLine();

                Console.Clear();
                Console.WriteLine(ln);
                Console.WriteLine();

                Console.WriteLine(ln.ReturnAmortizationSchedule());
                Console.WriteLine("Payment amount {0:C}", ln.PaymentAmount);
                Console.WriteLine("Interest paid over life of loan: {0:C}", ln.TotalInterestPaid);
                Console.Write("Do another calculation? (Y or N)");
                inValue = Console.ReadLine();
                anotherLoan = Convert.ToChar(inValue);
            } while ((anotherLoan == 'Y') || (anotherLoan == 'y'));

        }//end main

        // prompts user for loan data
        public static void GetInputValues(out double loanAmount, out double interestRate,
                                            out int years)
        {
            Console.Clear();
            loanAmount = GetLoanAmount();
            interestRate = GetInterestRate();
            years = GetYears();
        }

        public static double GetLoanAmount()
        {
            string sValue;
            double loanAmount;

            Console.Write("please enter the loan amount: ");
            sValue = Console.ReadLine();
            while (double.TryParse(sValue, out loanAmount) == false)
            {
                Console.WriteLine("Invalid data entered for loan amount");
                Console.Write("\nPlease re-enter the loan amount: ");
                sValue = Console.ReadLine();
            }
            return loanAmount;
        }


        public static double GetInterestRate()
        {
            string sValue;
            double interestRate;

            Console.Write("Please enter interest rate (as a decimal value - ie .06: ");
            sValue = Console.ReadLine();
            while (double.TryParse(sValue, out interestRate) == false)
            {
                Console.Write("\nInvalid data entered for loan amount");
                Console.Write("\nPlease re-enter the interest rate: ");
                sValue = Console.ReadLine();
            }
            return interestRate;
        }

        public static int GetYears()
        {
            string sValue;
            int years;

            Console.Write("Please oh please enter the number of years for the loan: ");
            sValue = Console.ReadLine();
            while (int.TryParse(sValue, out years) == false)
            {
                Console.Write("\nInvalid year entered for years");
                Console.Write("\nPlease re-enter the years: ");
                sValue = Console.ReadLine();
            }
            return years;
        }

    }//end class
}//end solution
