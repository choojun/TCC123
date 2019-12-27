using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U3_FormsApp_RadioButton
{
    public partial class frmRadioButton : Form
    {
        public frmRadioButton()
        {
            InitializeComponent();
        }

        private void radVB_CheckedChanged(object sender, EventArgs e)
        {
            if (radVB.Checked)
                txtLang.Text = "Visual Basic";
            else
                txtLang.Text = "";
        }

        private void radCSharp_CheckedChanged(object sender, EventArgs e)
        {
            if (radCSharp.Checked)
                txtLang.Text = "C#";
            else
                txtLang.Text = "";
        }
    }
}
