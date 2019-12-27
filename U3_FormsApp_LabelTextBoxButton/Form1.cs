using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U3_FormsApp_LabelTextBoxButton
{
    public partial class frmLabelTextBoxButton : Form
    {
        public frmLabelTextBoxButton()
        {
            InitializeComponent();
        }

        private void btnDisplayPassword_Click(object sender, EventArgs e)
        {
            // Display the text of user input
            lblDisplayPassword.Text = txtInputPassword.Text;
        }
    }
}
