using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_DecisionStructureIfElseIf_LargerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter first number: ");
            int.TryParse(Console.ReadLine(), out num1);

            Console.Write("Enter second number: ");
            int.TryParse(Console.ReadLine(), out num2);

            if (num1 > num2)
                Console.WriteLine("First number is larger than the second number");
            else if (num2 > num1)
                Console.WriteLine("Second number is larger than the first number");
            else if (num2 == num1)
                Console.WriteLine("These two numbers are equal");
            Console.ReadLine();
        }
    }
}
