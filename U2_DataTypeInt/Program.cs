using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_DataTypeInt
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables used in addition calculation
            int num1, num2, sum;

            // prompt the user to enter first number
            System.Console.Write("Please enter first number: ");
            num1 = int.Parse(System.Console.ReadLine());

            // prompt the user to enter second number
            System.Console.Write("Please enter second number: ");
            num2 = int.Parse(System.Console.ReadLine());

            sum = num1 + num2; // add the numbers

            // display the sum
            System.Console.WriteLine("The sum is " + sum);
        }
    }
}
