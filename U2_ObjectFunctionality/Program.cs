using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_ObjectFunctionality
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next();
            // A C# int is really a shorthand for System.Int32,
            // which inherits the following members from System.Object.
            Console.WriteLine("{0}.GetHashCode() = {1}", randomNumber, randomNumber.GetHashCode());
            Console.WriteLine("{0}.Equals(23) = {1}", randomNumber, randomNumber.Equals(23));
            Console.WriteLine("{0}.ToString() = {1}", randomNumber, randomNumber.ToString());
            Console.WriteLine("{0}.GetType() = {1}", randomNumber, randomNumber.GetType());
            Console.ReadLine();
        }
    }
}
