using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_DecisionStructureIfElseIf_MarksAndGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your marks: ");
            double marks;
            double.TryParse(Console.ReadLine(), out marks);

            if (marks >= 80)
                Console.WriteLine("A");
            else if (marks >= 70)
                Console.WriteLine("B");
            else if (marks >= 60)
                Console.WriteLine("C");
            else if (marks >= 50)
                Console.WriteLine("D");
            else
                Console.WriteLine("F");
            Console.ReadLine();
        }
    }
}
