using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_LoopStructureForeach_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 11, 22, 33, 44, 2, 3, 5, 6, 9 };
            // LINQ query!
            var subset = from i in numbers where i < 10 select i;
            Console.Write("Values in the subset: ");
            foreach (var i in subset)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            // Hmm...what type is subset?
            Console.WriteLine("subset is a: {0}", subset.GetType().Name);
            Console.WriteLine("subset is defined in: {0}", subset.GetType().Namespace);
        }
    }
}
