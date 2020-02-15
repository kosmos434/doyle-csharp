using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    public class Student
    {
        // data members, data fields, or characteristics
        private string major;
        private int score1;
        private int score2;
        private int score3;
        private string studentFirstName;
        private string studentLastName;
        private string studentNumber;




        // Default constructor
        public Student() { }

        // Constructor with one parameter
        public Student (string sID)
        {
            studentNumber = sID;
        }

        // Constructor with three parameters
        public Student (string sID, string firstName, string lastName)
        {
            studentNumber = sID;
            studentFirstName = firstName;
            studentLastName = lastName;
        }
        // constructor with ALL data members
        public Student (string sID, string firstName, string lastName,
                        int s1, int s2, int s3, string maj)
        {
            studentNumber = sID;
            studentFirstName = firstName;
            studentLastName = lastName;
            score1 = s1;
            score2 = s2;
            score3 = s3;
            major = maj;
        }




        // properties!!
        public string StudentLastName { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentNumber { get; set; }
        public string Major { get; set; }
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public int Score3 { get; set; }



        // methods!!
        public double CalculateAverage()
        {
            return (score1 + score2 + score3) / 3.0;
        }

        public override string ToString()
        {
            return "Name: " +
                    studentFirstName + " " + studentLastName +
                    "\nMajor: " +
                    major +
                    "\nScore Average: " +
                    CalculateAverage().ToString("F2");
        }





    }//end class

    

}//end namespace
