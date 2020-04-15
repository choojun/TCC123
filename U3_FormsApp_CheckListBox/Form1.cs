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

        private void chkLstProgramming_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Remove all items
            lstProgramming.Items.Clear();

            // Add selected items from CheckedListBox to ListBox
            foreach (string itemChecked in chkLstProgramming.CheckedItems)
            {
                if (!lstProgramming.Items.Contains(itemChecked))
                    lstProgramming.Items.Add(itemChecked);
            }

            lblMessage.Text = "Added items: " + chkLstProgramming.CheckedItems.Count;
        }
    }
}
