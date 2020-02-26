using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;     //namespace for Windows Forms class <--must be imported

namespace SquaredValues
{
    class SquaredValues
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string result = "\tn        Squared\n";
            while (counter < 50)
            {
                counter++;
                result += " \t"       //notice the use of += to build the string for the MessageBox
                        + counter
                        + " \t"
                        + Math.Pow(counter, 2)
                        + "\n";
            }//end while
            //MessageBox is overloaded to hell
            //body, title, buttons, icon
            MessageBox.Show(result, "1 - 50 and their squares", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }
    }
}
