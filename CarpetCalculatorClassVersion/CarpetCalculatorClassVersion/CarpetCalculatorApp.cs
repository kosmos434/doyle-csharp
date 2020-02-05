using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCalculatorClassVersion
{
    class CarpetCalculatorApp
    {
        static void Main(string[] args)
        {
            CarpetCalculator berber = new CarpetCalculator(17.95);
            double roomWidth;
            double roomLength;

                DisplayInstructions();
                // call GetDimension() to get the length
                roomLength = GetDimension("Length");

                // call again to get the width
                roomWidth = GetDimension("Width");

                berber.SetNoOfSqYards(roomLength, roomWidth);
                berber.PricePerSqYard = 25.99;
                Console.Clear();
                Console.Write(berber);

                Console.ReadLine();

        }//end main

        public static void DisplayInstructions()
        {
            Console.WriteLine("This program will"
                + " determine how much "
                + "carpet to purchase.");
            Console.WriteLine();
            Console.WriteLine("You will be asked to "
                + "enter the size of the "
                + "room and the price of the");
            Console.WriteLine("carpet, in price per "
                + "square yds.");
            Console.WriteLine();
        }


        public static double GetDimension(string side)
        {
            string inputValue;  //local variables
            int feet,           //needed only
                inches;         //by this method
            Console.Write("\nEnter the {0} in feet: ", side);
            inputValue = Console.ReadLine();
            feet = int.Parse(inputValue);

            Console.Write("\nEnter the {0} in inches: ", side);
            inputValue = Console.ReadLine();
            inches = int.Parse(inputValue);
            // note: cast required here to avoid integer division
            return (feet + (double) inches / 12);
        }


    }//end class
}
