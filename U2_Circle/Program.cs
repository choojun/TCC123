using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare Integer variable as radius
            int radius;

            // read the radius of a circle
            Console.Write("Please enter the radius: ");
            radius = int.Parse(Console.ReadLine());

            // display circle's diameter
            Console.WriteLine("The diameter is " + (2 * radius));

            // display circle's circumference
            Console.WriteLine("The circumference is " + (2 * Math.PI * radius));

            // display circle's area
            Console.WriteLine("The area is " + (Math.PI * Math.Pow(radius, 2)));
            Console.ReadLine();
        }
    }
}
