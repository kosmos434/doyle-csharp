using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOfCustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            double value1 = 0,
                value2 = 0,
                answer;
            try
            {
                // could include code to enter new values
                answer = GetResults(value1, value2);
            }
            catch (FloatingPtDivisionException excepObj)
            {
                Console.Error.WriteLine(excepObj.Message);
            }
            catch
            {
                Console.Error.WriteLine("something else happened, dude");
            }
            Console.ReadKey();
        }

        static double GetResults(double value1, double value2)
        {
            if (value2 < 0.0000001)
            {
                FloatingPtDivisionException excepObj = new FloatingPtDivisionException(
                    "exception type: " +
                    "floating point division by zero honk honk");
                throw excepObj;
            }
            return value1 / value2;
        }
    }
}
