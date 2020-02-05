using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateInvestment
{
    class RealEstateInvestment
    {
        // Fields
        private int yearBuilt;
        private string streetAddress;
        private double purchasePrice;
        private double monthlyExpense;
        private double incomeFromRent;

        // Constructors
        //public RealEstateInvestment() { }             // default constructor not used (read only fields here)
        public RealEstateInvestment(string address, int year, double price) // three param ctor
        {
            streetAddress = address;
            yearBuilt = year;
            purchasePrice = price;
        }
        public RealEstateInvestment(string address, double price)    // two param ctor, address first
        {
            streetAddress = address;
            purchasePrice = price;
        }
        public RealEstateInvestment(double price, string address)    // two param, price first
        {
            purchasePrice = price;
            streetAddress = address;
        }
        public RealEstateInvestment(int year, double price, string address) // three params, year first
        {
            yearBuilt = year;
            purchasePrice = price;
            streetAddress = address;
        }

        // Properties
        public int YearBuilt            // read only
        {
            get
            {
                return yearBuilt;
            }
        }

        public string StreetAddress     // read only
        {
            get
            {
                return streetAddress;
            }
        }

        public double MonthlyExpense
        {
            get
            {
                return monthlyExpense;
            }
            set
            {
                monthlyExpense = value;
            }
        }

        public double IncomeFromRent
        {
            get
            {
                return incomeFromRent;
            }
            set
            {
                incomeFromRent = value;
            }
        }

        public double PurchasePrice     // read only
        {
            get
            {
                return purchasePrice;
            }
        }

        // Methods
        public double DetermineMonthlyEarnings()
        {
            return incomeFromRent - monthlyExpense;
        }

        public override string ToString()
        {
            return "Location " + streetAddress +
                "\nPurchase Price: " +
                purchasePrice.ToString("C") +
                "\nMonthly Income: " +
                monthlyExpense.ToString("C") +
                "\nMonthly Earnings: " +
                DetermineMonthlyEarnings().ToString("C");
        }
    }// end Class
} // end Namespace
