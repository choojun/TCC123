using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_JumpStructureReturn
{
    class Program
    {
        static int getAge()
        {
            return 26;
        }
        static void Main(string[] args)
        {
            int age = getAge();
            Console.WriteLine("My age is: " + age);
            return;
            Console.WriteLine("This Statement will never executed!");
        }
    }
}
