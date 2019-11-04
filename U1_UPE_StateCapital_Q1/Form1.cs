using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U1_UPE_StateCapital_Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPerak_Click(object sender, EventArgs e)
        {
            lblCapital.Text = "Ipoh";
        }

        private void btnPenang_Click(object sender, EventArgs e)
        {
            lblCapital.Text = "George Town";
        }

        private void btnJohor_Click(object sender, EventArgs e)
        {
            lblCapital.Text = "Johor Bahru";
        }

        private void btnSelangor_Click(object sender, EventArgs e)
        {
            lblCapital.Text = "Shah Alam";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
