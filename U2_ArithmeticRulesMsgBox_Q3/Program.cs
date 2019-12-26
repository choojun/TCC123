 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_ArithmeticRulesMsgBox_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Activity 2.7 Question 1
            int num1, num2;
            System.Console.Write("Please enter first number: ");
            num1 = int.Parse(Console.ReadLine());

            System.Console.Write("Please enter second number: ");
            num2 = int.Parse(Console.ReadLine());

            string output = "Sum = " + (num1 + num2) + System.Environment.NewLine
                + "Difference = " + (num1 - num2) + System.Environment.NewLine
                + "Product = " + (num1 * num2) + System.Environment.NewLine
                + "Quotient = " + (num1 / num2) + System.Environment.NewLine;
            MessageBox.Show(output);
        }
    }
}
