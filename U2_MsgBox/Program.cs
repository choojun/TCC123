using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_MsgBox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Self-test Question 2
            int y, z;
            y = 4;
            z = 5;
            MessageBox.Show(y + "", "Y");
            MessageBox.Show((y + y) + "", "(y + y)");
            MessageBox.Show("y + z");
        }
    }
}
