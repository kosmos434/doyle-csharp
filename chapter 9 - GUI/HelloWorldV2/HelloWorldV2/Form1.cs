using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // toggle!
            label1.Visible = !label1.Visible;

            string saveName;
            saveName = txtBxName.Text;
            txtBxName.Text = "";


            label1.Text = "Hello, " + saveName + ", welcome to a form";

        //    if (label1.Visible)
        //        label1.Visible = false;
        //    else
        //        label1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit( );
        }
    }
}
