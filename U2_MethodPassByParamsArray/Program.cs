using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_MethodPassByParamsArray
{
    class Program
    {
        static int SumMe(params int[] args)
        {
            int add = 0;
            foreach (int item in args)
            {
                add = add + item;
            }
            return add;
        }
        static void Main(string[] args)
        {
            int total = SumMe(2, 4, 6, 8); // total = 20
            Console.WriteLine("total: {0}", total);
        }
    }
}
