using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    delegate string ReturnsSimpleString();
    class DelegateExample
    {
        static void Main(string[] args)
        {
            int age = 18;
            ReturnsSimpleString saying1 =
                new ReturnsSimpleString(AHeading);
            ReturnsSimpleString saying2 =
                new ReturnsSimpleString((age + 10).ToString);
            ReturnsSimpleString saying3 =
                new ReturnsSimpleString(EndStatement);
            MessageBox.Show(saying1() +
                saying2() + saying3());
        }

        // method that returns a string
        static string AHeading()
        {
            return "Your age will be ";
        }

        // another method that returns a string
        static string EndStatement()
        {
            return " in 10 years";
        }
    }
}
