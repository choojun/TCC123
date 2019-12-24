using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_DecisionStructureIfElse_EligibleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your age: ");
            double age;
            double.TryParse(Console.ReadLine(), out age);

            if (age >= 21)
                Console.WriteLine("You are eligible to study at WOU");
            else
                Console.WriteLine("You are eligible to study in " + (21 - age) + " years");
            Console.ReadLine();
        }
    }
}
