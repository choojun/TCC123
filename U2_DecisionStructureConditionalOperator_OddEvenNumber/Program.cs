using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_DecisionStructureConditionalOperator_OddEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conditional Operator with (? :)
            int num = 2;
            string result = (num % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine("{0} is {1}", num, result);

            // Null Coalescing Operator with (??)
            string name = null;
            // set username = name, if name is not null.
            // set username = "Wawasan", if name is null.
            string username = name ?? "Wawasan";
            Console.WriteLine("username is {0}", username);
        }
    }
}
