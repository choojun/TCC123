using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_SquareRootRound
{
    class Program
    {
        static void Main(string[] args)
        {
            double root = Math.Sqrt(2);
            MessageBox.Show("Square root of 2 (with 2 factional digits) is " + Math.Round(root));
            MessageBox.Show("Square root of 2 (with 2 factional digits) is " + Math.Round(root,2));
            MessageBox.Show("Square root of 2 (with 3 factional digits) is " + Math.Round(root, 3));
            MessageBox.Show("Square root of 2 (with 4 factional digits) is " + Math.Round(root, 4));
        }
    }
}
