using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U3_FormsApp_NumericUpDown
{
    public partial class frmNumericUpDown : Form
    {
        public frmNumericUpDown()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // declare variables to hold user input
            double principal; // hold principal
            double rate; // hold interest rate
            int year; // hold number of years
            double amount; // hold amount
            double repayment; // hold monthly repayment 

            // retrieve user input
            double.TryParse(txtPrincipal.Text, out principal);
            double.TryParse(txtRate.Text, out rate);
            int.TryParse(nudYear.Value.ToString(), out year);

            string newLine = Environment.NewLine;
            // output header
            txtDisplay.Text = "Year Payment \t Monthly" + newLine;

            // calculate amount after each year and append to output
            for (int yearCounter = 1; yearCounter <= year; yearCounter++)
            {
                amount = principal * Math.Pow(1 + rate / 100, yearCounter);
                repayment = amount / (12 * yearCounter);
                txtDisplay.Text += (yearCounter 
                    + ": RM" + String.Format("{0:N2}", amount) 
                    + "\t RM" + String.Format("{0:N2}", repayment) 
                    + newLine);
            }
        }
    }
}
