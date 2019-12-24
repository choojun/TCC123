using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_DecisionStructureIfElse_LargerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, largerNumber;

            Console.Write("Please enter first number: ");
            string num1 = Console.ReadLine();
            // Method int.TryParse converts a string to int
            int.TryParse(num1, out number1);

            Console.Write("Please enter second number: ");
            // You may locate the received string (from Console.Read)
            // into the method int.TryParse directly
            int.TryParse(Console.ReadLine(), out number2);

            // The condition to compare the two numbers to finds the larger
            if (number1 > number2)
                largerNumber = number1;
            else
                largerNumber = number2;

            // Display the larger number
            Console.WriteLine("The larger number is: " + largerNumber);
            Console.ReadLine();
        }
    }
}
