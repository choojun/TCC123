using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_DecisionStructureIf_CGPAStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your current CGPA: ");
            double cgpa;
            double.TryParse(Console.ReadLine(), out cgpa);
            // Clear() is used to erase the whole console 
            Console.Clear();

            if (cgpa >= 3.67)
                Console.WriteLine("A distinction ");
            Console.WriteLine("Student in WOU!");
            Console.ReadLine();
        }
    }
}
