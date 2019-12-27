using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U3_FormsApp_ComboBox
{
    public partial class frmComboBox : Form
    {
        public frmComboBox()
        {
            InitializeComponent();
        }

        private void btnDisplayName_Click(object sender, EventArgs e)
        {
            // display the title and full name in text box.
            txtDisplayName.Text = cboTitle.Text + " " + txtName.Text;
        }
    }
}
