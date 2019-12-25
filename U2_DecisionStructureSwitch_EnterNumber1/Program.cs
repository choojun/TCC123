using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_DecisionStructureSwitch_EnterNumber1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter your number");
            int.TryParse(Console.ReadLine(), out number);
            if (number == 1)
                Console.WriteLine("number = 1");
            else
            {
                if (number > 10)
                Console.WriteLine("number > 10");
            }

            Console.WriteLine("Enter your number (try 2)");
            int.TryParse(Console.ReadLine(), out number);
            switch (number)
            {
                case 1:
                    Console.WriteLine("number = 1");
                    break;
                case int i when i > 10:
                    Console.WriteLine("number > 10");
                    break;
            }

            Console.ReadLine();
        }
    }
}
