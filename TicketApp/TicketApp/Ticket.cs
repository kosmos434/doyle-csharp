using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp
{
    class Ticket
    {
        // fields
        private const decimal COST_PER_OVER_5 = 87.50M;
        private string studentNumber;
        private char classif;
        private int speedLimit;
        private int speedTraveling;

        #region ctors
        public Ticket()
        {

        }

        public Ticket(string sNum, char yrInSchool, int speedLmt, int reportedSpeed)
        {
            studentNumber = sNum;
            speedLimit = speedLmt;
            speedTraveling = reportedSpeed;
            classif = yrInSchool;
        }

        public Ticket(string sNum, int speedLmt, int reportedSpeed)
        {
            studentNumber = sNum;
            speedLimit = speedLmt;
            speedTraveling = reportedSpeed = speedLimit;
        }
        #endregion

        #region properties
        public string StudentNumber
        {
            get
            {
                return studentNumber;
            }
            set
            {
                studentNumber = value;
            }
        }

        public char Classif
        {
            get
            {
                return classif;
            }
            set
            {
                classif = value;
            }
        }

        public int SpeedLimt
        {
            get
            {
                return speedLimit;
            }
            set
            {
                speedLimit = value;
            }
        }

        public int Speed
        {
            get
            {
                return speedTraveling;
            }
            set
            {
                speedTraveling = value;
            }
        }
        #endregion

        // methods
        // refactor in else if's
        public decimal SetFine()
        {
            int milesOverSpeedLimit = speedTraveling - speedLimit;
            decimal fine;

            fine = (milesOverSpeedLimit / 5 * COST_PER_OVER_5) + 75.00M;

            if (classif == '4')     // senior
                if (milesOverSpeedLimit > 20)   // senior AND going 20 over limit
                    fine += 200;
                else
                    fine += 50;                 // senior less than 5 over speed limit
            else if (classif == '1')             // freshman
                    if (milesOverSpeedLimit < 20)
                        fine -= 50;                 // discount for not driving maniacally
                    else
                        fine += 100;
                else if (milesOverSpeedLimit > 19)
                    fine += 100;

            return fine;
        }

        public string ReturnNameOfClassification()
        {
            string classificationName;
            switch (classif)
            {
                case '1':
                    classificationName = "Freshman";
                    break;
                case '2':
                    classificationName = "Sophomore";
                    break;
                case '3':
                    classificationName = "Junior";
                    break;
                case '4':
                    classificationName = "Senior";
                    break;
                default:
                    classificationName = "unknown";
                    break;
            }
            return classificationName;
        }

        public override string ToString()
        {
            return "\tTicket app" +
                "\n\nStudent number: " + studentNumber +
                "\nYear: " + ReturnNameOfClassification() +
                "\nSpeed Limit: " + speedLimit +
                "\nReported speed: " + speedTraveling +
                "\n\nFine: " + SetFine().ToString("C");
        }

    }// end Class
}// end Namespace
