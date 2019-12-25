using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_DecisionStructureSwitch_PatternMatching1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 [Integer (5)], 2 [String (\"Hi\")], 3 [Decimal (2.5)]");
            Console.Write("Please choose an option: ");
            string userChoice = Console.ReadLine();
            object choice;
            //This is a standard constant pattern switch statement to set up the example
            switch (userChoice)
            {
                case "1":
                    choice = 5;
                    break;
                case "2":
                    choice = "Hi";
                    break;
                case "3":
                    choice = 2.5;
                    break;
                default:
                    choice = 5;
                    break;
            }
            //This is new the pattern matching switch statement
            switch (choice)
            {
                case int i:
                    Console.WriteLine("Your choice is an integer {0}.", i);
                    break;
                case string s:
                    Console.WriteLine("Your choice is a string {0}.", s);
                    break;
                case double d:
                    Console.WriteLine("Your choice is a double {0}.", d);
                    break;
                default:
                    Console.WriteLine("Your choice is something else");
                    break;
            }
            Console.WriteLine();
        }
    }
}
