using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class StudentApp
    {
        static void Main(string[] args)
        {

            //Student testStudentObject = new Student()
            

            Student firstStudentObject = new Student();
            firstStudentObject.StudentFirstName = AskForStudentName("First");
            firstStudentObject.StudentLastName = AskForStudentName("Last");
            firstStudentObject.StudentNumber = AskForStudentNumber();
            firstStudentObject.Major = AskForMajor(firstStudentObject.StudentFirstName);
            firstStudentObject.Score1 = AskForExamScore(1);
            firstStudentObject.Score2 = AskForExamScore(2);
            firstStudentObject.Score3 = AskForExamScore(3);

            

            Console.Clear();
            Console.WriteLine("First Student");
            Console.WriteLine((firstStudentObject.ToString()));

            Student secondStudentObject = new Student("1138");
            secondStudentObject.Score1 = 99;
            secondStudentObject.Score2 = 88;
            secondStudentObject.Score3 = 97;
            Console.WriteLine("\n\nSecond Student");
            Console.WriteLine("Student Number: " +
                            secondStudentObject.StudentNumber +
                            "\nAverage: {0:F1}",
                            secondStudentObject.CalculateAverage());

            Student thirdStudentObject = new
                                Student("0451", "Randy", "Bozo");
            thirdStudentObject.Major = "Physics";
            thirdStudentObject.Score1 = 90;
            thirdStudentObject.Score2 = 60;
            thirdStudentObject.Score3 = 50;
            Console.WriteLine("\n\nThird Student");
            Console.WriteLine(thirdStudentObject);

            Student aStudentObject = new Student("1234", "Test-O",
                                                "McTest", 44, 93,
                                                89, "CS");
            Console.WriteLine("\n\nLast Student");
            Console.WriteLine("Student Name: " +
                    aStudentObject.StudentFirstName + " " +
                    aStudentObject.StudentLastName +
                    "\nStudent Number: " +
                    aStudentObject.StudentNumber +
                    "\nMajor: " + aStudentObject.Major +
                    "\nExam Score 1: " + aStudentObject.Score1 +
                    "\nExam Score 2: " + aStudentObject.Score2 +
                    "\nExam Score 3: " + aStudentObject.Score3 +
                    "\nExam Average: " +
                    aStudentObject.CalculateAverage().ToString("F1"));


            Console.WriteLine("first student name {0}", firstStudentObject.StudentFirstName);
            Console.ReadKey();
        }//end main


        public static int AskForExamScore(int whichOne)
        {
            string inValue;
            int aScore;
            Console.WriteLine("enter a value for score {0}", whichOne);
            inValue = Console.ReadLine();
            aScore = int.Parse(inValue);
            return aScore;
        }

        public static string AskForStudentName(string whichOne)
        {
            string inValue;
            Console.WriteLine("enter student {0} name: ", whichOne);
            inValue = Console.ReadLine();
            return inValue;
        }

        public static string AskForMajor(string name)
        {
            string inValue;
            Console.WriteLine("enter {0}\'s major: ", name);
            inValue = Console.ReadLine();
            return inValue;
        }

        public static string AskForStudentNumber()
        {
            string inValue;
            Console.WriteLine("enter student number: ");
            inValue = Console.ReadLine();
            return inValue;
        }




    }//end class
}
