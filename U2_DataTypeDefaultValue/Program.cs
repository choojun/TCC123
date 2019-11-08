using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_DataTypeDefaultValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Method 1 to create variables:");
            bool b = new bool(); // Set to false.
            int i = new int(); // Set to 0.
            double d = new double(); // Set to 0.
            string s = null;
            DateTime dt = new DateTime(); // Set to 1/1/0001 12:00:00 AM
            Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
            Console.WriteLine("string: >{0}<", s);

            Console.WriteLine("=> Method 2 to create variables:");
            b = default(bool);
            i = default(int);
            d = default(double);
            dt = default(DateTime);
            s = default(string);
            Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
            Console.WriteLine("string: >{0}<", s);
            Console.ReadLine();
        }
    }
}
