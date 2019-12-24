using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_DecisionStructureIfElseIf_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            String input = Console.ReadLine();
            int age = 0;
            if (int.TryParse(input, out age))
                Console.WriteLine("You have entered {0}", input);
            else
                Console.WriteLine("Invalid input");

            if (age < 11)
                Console.WriteLine("You're a child!");
            else if (age < 18)
                Console.WriteLine("You're a teenager!");
            else if (age < 50)
                Console.WriteLine("You're an adult!");
            else
                Console.WriteLine("You're an old person");
            Console.ReadLine();
        }
    }
}
