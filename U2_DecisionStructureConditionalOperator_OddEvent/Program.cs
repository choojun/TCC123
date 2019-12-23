using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_DecisionStructureConditionalOperator_OddEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 2;
            string result = (num % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine("{0} is { 1}", num, result);
        }
    }
}
