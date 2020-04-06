using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubForm
{
    public partial class ClubForm : Form
    {
        public ClubForm()
        {
            InitializeComponent();
        }

        private void lstBxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            string result = " ";
            foreach(string activity in lstBxEvents.SelectedItems)
            {
                result += activity + " ";
            }
            this.txtBxResult.Text = result;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstBxEvents.Items.Add(txtBxAddNew.Text);
            txtBxAddNew.Clear();
        }
    }
}
