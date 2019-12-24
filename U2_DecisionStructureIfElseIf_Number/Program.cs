using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_DecisionStructureIfElseIf_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            int number;
            int.TryParse(Console.ReadLine(), out number);
            if (number < 0)
                Console.WriteLine("Negative Number");
            else
            {
                if (number == 0)
                    Console.WriteLine("Zero Number");
                else
                    Console.WriteLine("Positive Number");
            }
            Console.ReadLine();
        }
    }
}
