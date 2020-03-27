using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows0
{
    public class Form1 : Form
    {
        public Form1()
        {
            Text = "simple windows application, blank in fact";
        }
        public static void Main()
        {
            Form1 winForm = new Form1();
            Application.Run(winForm);
        }
    }
}
