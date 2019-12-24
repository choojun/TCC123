using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_DecisionStructureIfElse_OddEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int number;
            Console.WriteLine("Enter a number");
            input = Console.ReadLine();
            //Checking whether we can parse the string as an integer
            if (int.TryParse(input, out number))
            {
                Console.WriteLine("You have entered {0}", input);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            if (number % 2 == 0)
            {
                Console.WriteLine("{0} is an Even Number", number);
            }
            else
            {
                Console.WriteLine("{0} is an Odd Number", number);
            }
        }
    }
}
