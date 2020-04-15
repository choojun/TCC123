using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U3_FormsApp_MenuStrip
{
    public partial class frmMenuStrip : Form
    {
        public frmMenuStrip()
        {
            InitializeComponent();
        }

        private void mnuPictureSizeLarge_Click(object sender, EventArgs e)
        {
            // Set the values for a Large Picture
            picWou.Height = 157;
            picWou.Width = 232;
            mnuPictureSizeSmall.Checked = false;
            mnuPictureSizeLarge.Checked = true;
        }

        private void mnuPictureSizeSmall_Click(object sender, EventArgs e)
        {
            // Set the values for a small Picture
            picWou.Height = 57;
            picWou.Width = 132;
            mnuPictureSizeLarge.Checked = false;
            mnuPictureSizeSmall.Checked = true;
        }

        private void mnuPictureVisible_Click(object sender, EventArgs e)
        {
            // change the visible property of the picture
            // and the state of the check mark
            picWou.Visible = ! picWou.Visible;
            mnuPictureVisible.Checked = !mnuPictureVisible.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
