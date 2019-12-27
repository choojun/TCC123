using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U3_FormsApp_ListBox
{
    public partial class frmListBox : Form
    {
        public frmListBox()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Key in items in the txtSubject to the lstSubject then clear textSubject
            lstSubject.Items.Add(txtSubject.Text);
            txtSubject.Clear();
            txtSubject.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Remove an item from lstSubject if the item is selected
            // If an item is selected, remove that item
            if (lstSubject.SelectedIndex != -1)
                lstSubject.Items.RemoveAt(lstSubject.SelectedIndex);

            txtSubject.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all the items in lstSubject
            lstSubject.Items.Clear();
            txtSubject.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Terminate the application
            Application.Exit();
        }
    }
}
