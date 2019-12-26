using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_MethodPassByRef
{
    class Program
    {
        static void PassByRef(ref int i)
        {
            i = i + 1;
        }
        static void OutMethod(out int i)
        {
            i = 1;
        }
        static void Main(string[] args)
        {
            int j = 0;
            PassByRef(ref j);
            Console.WriteLine(j); //j = 1

            int k;

            OutMethod(out k);
            Console.WriteLine(k); // k = 1
        }
    }
}
