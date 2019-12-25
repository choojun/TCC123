using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_LoopStructureForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carTypes = { "Saga", "Persona", "X70", "Iris" };
            foreach (string c in carTypes)
                Console.WriteLine(c);

            int[] myInts = { 11, 22, 33, 44 };
            foreach (int i in myInts)
                Console.WriteLine(i);
        }
    }
}
