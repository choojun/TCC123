using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U1_TextBoxEnable_Q6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            txtBox.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            txtBox.Enabled = true;
            txtBox.Focus();
        }
    }
}
