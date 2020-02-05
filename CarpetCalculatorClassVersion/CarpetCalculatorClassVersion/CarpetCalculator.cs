using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCalculatorClassVersion
{
    class CarpetCalculator
    {
        // class variables!!
        private double pricePerSqYard;
        private double noOfSqYards;


        //properties!!
        // property for the pricerPerSqYard data field
        public double PricePerSqYard { get; set; }
        //property for noOfSqYards data field
        public double NoOfSqYards { get; set; }

        // property also associated with
        // pricePerSqYard - works, but does
        // not follow naming convention
        //public double Price
        //{
        //    get
        //    {
        //        return pricePerSqYard;
        //    }
        //    set
        //    {
        //        pricePerSqYard = value;
        //    }
        //}
        



        // constructors!!
        // default constructor
        public CarpetCalculator() { }
        // one argument constructor
        public CarpetCalculator(double price)
        {
            pricePerSqYard = price;
        }
        // two arguments
        public CarpetCalculator(double amountNeeded, double price)
        {
            noOfSqYards = amountNeeded;
            pricePerSqYard = price;
        }


        // methods!!
        public double DetermineTotalCost()
        {
            return (pricePerSqYard * noOfSqYards);
        }
        // one of the overloaded setter methods
        public void SetNoOfSqYards(double length, double width)
        {
            const int SQ_FT_PER_SQ_YARD = 9;
            noOfSqYards = length * width / SQ_FT_PER_SQ_YARD;
        }

        // another overloaded setter method
        public void SetNoOfSqYards(double squareYards)
        {
            noOfSqYards = squareYards;
        }
        // getter method
        public double GetNoOfSqYards()
        {
            return noOfSqYards;
        }
        // ToString override
        public override string ToString()
        {
            return "Price Per Square Yard: " +
                pricePerSqYard.ToString("C") +
                "\nTotal Square Yards: " +
                noOfSqYards.ToString("F1") +
                "\nTotal Price: " +
                DetermineTotalCost().ToString("C");
        }



    }//end class
}
