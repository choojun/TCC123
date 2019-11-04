using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U1_UPE_StateCapital_Q2
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
            lblDescription.Text = "Ipoh is famous for its food";
        }

        private void lblCap_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void btnPenang_Click(object sender, EventArgs e)
        {
            lblCapital.Text = "George Town";
            lblDescription.Text = "Penang is famous for its belacan";
        }

        private void btnJohor_Click(object sender, EventArgs e)
        {
            lblCapital.Text = "Johor Bharu";
            lblDescription.Text = "Johor is fomous for its curry";
        }

        private void btnSelangor_Click(object sender, EventArgs e)
        {
            lblCapital.Text = "Shah Alam";
            lblDescription.Text = "Selangor is famous for its noodle mee";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
