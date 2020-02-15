using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp
{
    class TicketApp
    {

        static void Main(string[] args)
        {
            string studentNumber;
            char classif;
            int speedLimit,
                speed;

            studentNumber = InputStudentNumber();
            speedLimit = InputSpeed("Speed Limit");
            speed = InputSpeed("Ticketed Speed");
            classif = InputYearInSchool();

            Ticket studentTicket = new Ticket(studentNumber, classif, speedLimit, speed);

            Console.Clear();
            Console.WriteLine(studentTicket);
            Console.ReadKey();
        }

        // helper methods
        public static string InputStudentNumber()
        {
            string sNumber;
            Console.Write("enter student number ");
            sNumber = Console.ReadLine();
            return sNumber;
        }

        public static int InputSpeed(string whichSpeed)
        {
            string inValue;
            int speed;

            Console.Write("enter the {0}: ", whichSpeed);
            inValue = Console.ReadLine();
            if (int.TryParse(inValue, out speed) == false)
                Console.WriteLine("invalid entry entered for {0} - 0 was recorded", whichSpeed);
            return speed;
        }

        public static char InputYearInSchool()
        {
            string inValue;
            char yrInSchool;
            Console.WriteLine("enter your year: ");
            Console.WriteLine("\tfreshmen (enter 1)");
            Console.WriteLine("\tsoph (enter 2)");
            Console.WriteLine("\tjunior (enter 3)");
            Console.WriteLine("\tsenior (enter 4)");
            Console.WriteLine();
            inValue = Console.ReadLine();
            yrInSchool = Convert.ToChar(inValue);
            return yrInSchool;
        }
    }
}
