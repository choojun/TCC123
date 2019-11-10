using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_String
{
    class Program
    {
        static void Main(string[] args)
        {
            // Self-test 2.1 Question 6
            int a = 4;
            int b = 2;
            string c = "Visual";
            string d = "Basic";
            Console.WriteLine(c.Length);
            Console.WriteLine(c.ToLower());
            Console.WriteLine(c.Substring(a, b - 1));
            Console.WriteLine(c.IndexOf(d));
            Console.ReadLine();
        }
    }
}
