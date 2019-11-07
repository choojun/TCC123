using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_ConcatenationName
{
    class Program
    {
        static void Main(string[] args)
        {
            // Activity 2.8 Question 1
            string fname, lname;
            System.Console.Write("Enter first name: ");
            fname = Console.ReadLine();
            System.Console.Write("Enter last name: ");
            lname = Console.ReadLine();

            MessageBox.Show("Your name is : " + fname + " " + lname,
                "Concatenation");
        }
    }
}
