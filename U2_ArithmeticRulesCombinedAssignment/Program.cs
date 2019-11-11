using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_ArithmeticRulesCombinedAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 25;
            System.Console.WriteLine("When x = " + x);
            x += 5; // x = x+5;
            System.Console.WriteLine("x += 5 , the result: " + x);
            x -= 5; // x = x-5;
            System.Console.WriteLine("x -= 5 , the result: " + x);
            x *= 5; // x = x*5;
            System.Console.WriteLine("x *= 5 , the result: " + x);
            x /= 5; // x = x/5;
            System.Console.WriteLine("x /= 5 , the result: " + x);
            x %= 5; // x = x%5;
            System.Console.WriteLine("x %= 5 , the result: " + x);
            System.Console.WriteLine();

            x = 5;
            int y = 5;
            System.Console.WriteLine("When x = {0} and y = {1}", x, y);
            y = x++; // post-increment, i.e. x = x+1;
            System.Console.WriteLine("y = x++ , the result: y = {0} and x = {1}", y , x);
            x = 5;
            y = 5;
            y = x--; // post-decrement, i.e. x = x-1;
            System.Console.WriteLine("y = x-- , the result: y = {0} and x = {1}", y, x);
            x = 5;
            y = 5;
            y = ++x; // pre-increment
            System.Console.WriteLine("y = ++x , the result: y = {0} and x = {1}", y, x);
            x = 5;
            y = 5;
            y = --x; // pre-decrement
            System.Console.WriteLine("y = --x , the result: y = {0} and x = {1}", y, x);

            System.Console.ReadLine();
        }
    }
}
