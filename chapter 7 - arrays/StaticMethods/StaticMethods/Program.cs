using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaticMethods
{
    class Program
    {
        private const string CAPTION = "System.Array Methods yay";
        static void Main(string[] args)
        {
            double[] waterDepth = { 34, 53, 11, 18.5, 190, 0.4, 419, 5, 15 };
            double[] w = new double[20];

            DisplayOutput(waterDepth, "waterDepth Array\n\n");

            // copies values from waterDepth to w
            Array.Copy(waterDepth, 2, w, 0, 5);

            // sorts the arrray normal style
            Array.Sort(w);
            DisplayOutput(w, "Array w sorted normal style\n\n");

            // reverse it
            Array.Reverse(w);
            DisplayOutput(w, "Array is totally reversed\n\n");
        }

        // displays an array in a MessageBox
        public static void DisplayOutput(double[] anArray, string msg)
        {
            foreach (double wVal in anArray)
                if (wVal > 0)
                    msg += wVal + "\n";
                MessageBox.Show(msg, CAPTION);
        }
    }
}
