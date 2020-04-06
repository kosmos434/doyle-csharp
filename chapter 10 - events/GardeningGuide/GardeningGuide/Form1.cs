using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardeningGuide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtBxResultFlowers.Text = comboBox1.Text;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.txtBxResultFlowers.Text = comboBox1.Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtBxResultTrees.Text = " ";
            foreach(int i in listBox1.SelectedIndices)
            {
                this.txtBxResultTrees.Text +=
                    this.listBox1.Items[i] + " ";
            }
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gardening for the win");
        }

        private void menuFont_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = lblOutput.Font;
            if(fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                lblOutput.Font = fontDialog1.Font;
            }
        }

        private void menuColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = lblOutput.ForeColor;
            if(colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                lblOutput.ForeColor = colorDialog1.Color;
            }
        }
    }
}
