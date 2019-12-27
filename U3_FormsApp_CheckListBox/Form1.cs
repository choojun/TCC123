using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U3_FormsApp_CheckListBox
{
    public partial class fromCheckListBox : Form
    {
        public fromCheckListBox()
        {
            InitializeComponent();
        }

        private void chkLstSubject1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Remove all items from chkLstSubject2
            lstSubject.Items.Clear();

            // Add selected items from chkLstSubject1 to chkLstSubject2
            foreach (string itemChecked in chkLstSubject1.CheckedItems)
            {
                if (!lstSubject.Items.Contains(itemChecked))
                    lstSubject.Items.Add(itemChecked);
            }

            lblMessage.Text = "Added items: " + chkLstSubject1.CheckedItems.Count;
        }
    }
}
