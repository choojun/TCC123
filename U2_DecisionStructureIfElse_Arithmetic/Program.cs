using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_DecisionStructureIfElse_Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            int y = 2;
            int z = 1;
            if (x + y < z)
                y = 9;
            else
                y = x * z;

            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
