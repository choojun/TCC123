using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U1_UPE_ButtonClick_Q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            txtBox.Text = "Hello World";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnB_Click(object sender, EventArgs e)
        {
            txtBox.BackColor = Color.Blue;
            txtBox.Text = "Hello World";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtBox.Text = "Hello World";
            txtBox.Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBox.Text = "";
            txtBox.BackColor = Color.White;
            txtBox.Visible = true;
            this.Text = "";
            this.ForeColor = Color.Black;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            this.Text = "Hello World";
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            txtBox.Text = "Wawasan Open University";
            txtBox.ForeColor = Color.Green;
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Red;
        }
    }
}
