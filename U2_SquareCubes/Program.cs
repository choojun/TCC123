using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_SquareCubes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Self-test Question 4

            //display header for table
            Console.WriteLine("number \t square \t cube");

            // dispaly table with necessary values and spacing
            Console.WriteLine("  1    \t   " + Math.Pow(1,2) + " \t\t   " + Math.Pow(1,3));
            Console.WriteLine("  2    \t   " + Math.Pow(2,2) + " \t\t   " + Math.Pow(2,3));
            Console.WriteLine("  3    \t   " + Math.Pow(3,2) + " \t\t   " + Math.Pow(3,3));
            Console.WriteLine("  4    \t   " + Math.Pow(4,2) + " \t\t   " + Math.Pow(4,3));
            Console.ReadLine();
        }
    }
}
