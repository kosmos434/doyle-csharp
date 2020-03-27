using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindows
{
    public partial class PeachEmptyForm : Form
    {
        public PeachEmptyForm()
        {
            InitializeComponent();
        }

        private void PeachEmptyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("You are closing this silly window");
        }
    }
}
