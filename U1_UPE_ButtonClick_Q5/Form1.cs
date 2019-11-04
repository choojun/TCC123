using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U1_UPE_ButtonClick_Q5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblOne_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblOne.Text = "Wawasan Open University";
            txtBox.Enabled = true;
            btnReset.Focus();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            lblOne.Text = "Welcome to WOU!";
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            txtBox.Enabled = false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnTotal.Focus();
        }
    }
}
