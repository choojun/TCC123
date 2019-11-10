using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_DataTypeStructConstructorThis
{
    struct Vector
    {
        //Constructor
        public Vector(int x, int y)
        {
            //Initialize Fields
            this.x = x;
            this.y = y;
        }
        //Fields
        public int x;
        public int y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vector coordinates = new Vector(5, 10);
            Console.WriteLine("x = {0}", coordinates.x);
            Console.WriteLine("y = {0}", coordinates.y);
        }
    }
}
