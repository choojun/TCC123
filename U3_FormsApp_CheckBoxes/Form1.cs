using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U3_FormsApp_CheckBoxes
{
    public partial class frmCheckBoxes : Form
    {
        public frmCheckBoxes()
        {
            InitializeComponent();
        }

        double total = 0.0;
        private void chkOrange_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOrange.Checked)
                total += 1.0;
            else
                total -= 1.0;
            txtTotal.Text = total.ToString();
        }

        private void chkApple_CheckedChanged(object sender, EventArgs e)
        {
            if (chkApple.Checked)
                total += 0.6;
            else
                total -= 0.6;
            txtTotal.Text = total.ToString();
        }

        private void chkGrape_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGrape.Checked)
                total += 8.0;
            else
                total -= 8.0;
            txtTotal.Text = total.ToString();
        }

        private void chkPearl_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPearl.Checked)
                total += 2.0;
            else
                total -= 2.0;
            txtTotal.Text = total.ToString();
        }
    }
}
