using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_DataTypeStruct
{
    struct Vector
    {
        //Fields
        public int x;
        public int y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vector coordinates = new Vector();
            coordinates.x = 5;
            coordinates.y = 10;
            Console.WriteLine("x = {0}", coordinates.x);
            Console.WriteLine("y = {0}", coordinates.y);
        }
    }
}
