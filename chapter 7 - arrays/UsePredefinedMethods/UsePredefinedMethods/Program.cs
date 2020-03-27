using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsePredefinedMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] waterDepth = { 34, 29, 2, 18.5, 189, 0.4, 429, 3, 18 };
            string outputMsg = "";
            string caption = "System.Array Methods --- Today!";
            double[] w = new double[20];

            // displays the contents of Array waterdepth
            outputMsg += "waterDepth Array \n\n";
            foreach (double wVal in waterDepth)
                outputMsg += wVal + "\n";
            MessageBox.Show(outputMsg, caption);

            // copies 5 values from waterDepth, beginning at
            // index location 2. Places these values in Array w
            // starting at index location 0
            Array.Copy(waterDepth, 2, w, 0, 5);
            //foreach (var item in w)
            //{
            //    Console.WriteLine(item);
            //}

            // sort the Array w in ascending order
            Array.Sort(w);

            // displays the sorted awway
            outputMsg = "Arrya w sorted\n\n";
            foreach (double wVal in w)
            {
                if (wVal > 0)
                    outputMsg += wVal + "\n";
            }
            MessageBox.Show(outputMsg, caption);

            // reverses the elements in Array w
            Array.Reverse(w);

            // displays Array w in descending order now
            outputMsg = "array w reversed \n\n";
            foreach (double wVal in w)
            {
                if (wVal > 0)
                    outputMsg += wVal + "\n";
            }
            MessageBox.Show(outputMsg, caption);
        }
    }
}
