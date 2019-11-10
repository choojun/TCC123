using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_DataTypeStructConstructor
{
    struct Vector
    {
        //Constructor
        public Vector(int a, int b)
        {
            //Initialize Fields
            x = a;
            y = b;
        }
        //Fields
        public int x;
        public int y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize Vector, by passing 5,10 value to its constructor
            Vector coordinates = new Vector(5, 10);

            Console.WriteLine("x = {0}", coordinates.x);
            Console.WriteLine("y = {0}", coordinates.y);
        }
    }
}
