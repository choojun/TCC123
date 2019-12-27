using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U3_FormsApp_GroupBoxPanel
{
    public partial class frmGroupBoxPanel : Form
    {
        public frmGroupBoxPanel()
        {
            InitializeComponent();
        }

        private void btnVB_Click(object sender, EventArgs e)
        {
            // change text in label
            lblMessage.Text = "Visual Basic pressed"; 
        }

        private void btnCSharp_Click(object sender, EventArgs e)
        {
            // change text in label
            lblMessage.Text = "C# pressed"; 
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            // change text in label
            lblMessage.Text = "Left pressed"; 
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            // change text in label
            lblMessage.Text = "Right pressed";  
        }
    }
}
