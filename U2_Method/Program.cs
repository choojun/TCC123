using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_Method
{
    class Program
    {
        static int SumMe(int a, int b)
        {
            int add = a + b;
            return add;
        }
        static int MultiplyMe(int a, int b = 2)
        {
            int multiply = a * b;
            return multiply;
        }
        static void Main(string[] args)
        {
            int number1 = 3;
            int number2 = 6;
            int total1 = SumMe(number1, number2);
            Console.WriteLine("total1: {0}", total1);

            // Named Argument
            int total2 = SumMe(b: 5, a: 10);
            Console.WriteLine("total2: {0}", total2);

            // Optional Argument
            int total3 = MultiplyMe(7); // a = 7, b = 2
            Console.WriteLine("total3: {0}", total3);
            int total4 = MultiplyMe(7, 3); // a = 7, b = 3
            Console.WriteLine("total4: {0}", total4);
        }
    }
}
