using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U3_FormsApp_DateTimePicker
{
    public partial class frmDateTimePicker : Form
    {
        public frmDateTimePicker()
        {
            InitializeComponent();
        }

            private void dteDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime dropDate = dteDateTimePicker.Value;

            // add an extra day when items are dropped off Friday-Sunday
            if (dropDate.DayOfWeek == DayOfWeek.Saturday)
                lblMessage.Text = dropDate.AddDays(6).ToLongDateString();
            else if (dropDate.DayOfWeek == DayOfWeek.Sunday)
            {
                // estimate days for delivery
                lblMessage.Text = dropDate.AddDays(5).ToLongDateString();
            }
            else
            {
                // otherwise estimate only four days for delivery
                lblMessage.Text = dropDate.AddDays(7).ToLongDateString();
            }
        }

        private void frmDateTimePicker_Load(object sender, EventArgs e)
        {
            dteDateTimePicker.MinDate = DateTime.Today;
            dteDateTimePicker.MaxDate = DateTime.Today.AddMonths(1);
        }
    }
}
