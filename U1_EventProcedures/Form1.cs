using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U105_EventProcedures
{
    public partial class frmEvent : Form
    {
        public frmEvent()
        {
            InitializeComponent();
        }

        private void txtOne_TextChanged(object sender, EventArgs e)
        {
            txtOne.ForeColor = Color.Blue;
        }

        private void txtTwo_TextChanged(object sender, EventArgs e)
        {
            txtTwo.ForeColor = Color.Red;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            txtOne.ForeColor = Color.Green;
            //txtOne.Font.Bold = false;
            txtTwo.ForeColor = Color.Green;
        }
    }
}
