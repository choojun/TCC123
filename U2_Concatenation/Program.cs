using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringOne, stringTwo, stringOutput;
            stringOne = "Welcome";
            stringTwo = " Visual Programming";
            stringOutput = stringOne + stringTwo;

            MessageBox.Show("The string is : " + stringOne + " " + stringTwo, 
                "Concatenation");
        }
    }
}
