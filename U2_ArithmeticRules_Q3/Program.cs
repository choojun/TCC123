using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_ArithmeticRules_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Activity 2.6 Question 3
            int num1, num2;
            System.Console.Write("Please enter first number: ");
            num1 = int.Parse(Console.ReadLine());

            System.Console.Write("Please enter second number: ");
            num2 = int.Parse(Console.ReadLine());

            System.Console.WriteLine("");
            System.Console.WriteLine("Sum = " + (num1 + num2));
            System.Console.WriteLine("Difference = " + (num1 - num2));
            System.Console.WriteLine("Product = " + (num1 * num2));
            System.Console.WriteLine("Quotient = " + (num1 / num2));
            System.Console.ReadLine();
        }
    }
}
