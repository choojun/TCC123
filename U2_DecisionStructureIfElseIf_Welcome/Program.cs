using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_DecisionStructureIfElseIf_Welcome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter p, i or k: ");
            string city = Console.ReadLine();
            if (city == "p")
                Console.WriteLine("Welcome to Penang");
            else if (city == "i")
                Console.WriteLine("Welcome to Ipoh");
            else if (city == "k")
                Console.WriteLine("Welcome to Kedah");
            Console.ReadLine();
        }
    }
}
