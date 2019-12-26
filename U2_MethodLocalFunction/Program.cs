using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_MethodLocalFunction
{
    class Program
    {
        static int AddWrapper(int x, int y)
        {
            //Do some validation here
            return Add();
            int Add()
            {
                return x + y;
            }
        }
        static void Main(string[] args)
        {
            int total = AddWrapper(3, 4);
            Console.WriteLine("total: {0}", total);
        }
    }
}
