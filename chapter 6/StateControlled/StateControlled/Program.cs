using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StateControlled
{
    class Program
    {
        static void Main(string[] args)
        {
            bool moreData = true;
            Random numb = new Random( );
            int s = numb.Next(100);         // returns positive number < 100

            while (moreData)
            {
                Console.Write("{0}  ", s);
                if (MessageBox.Show("do you want another number?",
                                    "State controlled loop window",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question)
                    == DialogResult.No)
                {
                    moreData = false;
                }
                else
                {
                    s = numb.Next(100);
                }
            }//end while
        }//end main method
    }//end class
}//end solution
