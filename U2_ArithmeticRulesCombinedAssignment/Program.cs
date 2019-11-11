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
            System.Console.WriteLine();

            bool b;
            b = (2 == 3); // equal to (false)
            System.Console.WriteLine("b = (2 == 3) , the result: b = " + b);
            b = (2 != 3); // not equal to (true)
            System.Console.WriteLine("b = (2 != 3) , the result: b = " + b);
            b = (2 > 3); // greater than (false)
            System.Console.WriteLine("b = (2 > 3) , the result: b = " + b);
            b = (2 < 3); // less than (true)
            System.Console.WriteLine("b = (2 < 3) , the result: b = " + b);
            b = (2 >= 3); // greater than or equal to (false)
            System.Console.WriteLine("b = (2 >= 3) , the result: b = " + b);
            b = (2 <= 3); // less than or equal to (true)
            System.Console.WriteLine("b = (2 <= 3) , the result: b = " + b);
            System.Console.WriteLine();

            x = 5 & 4; // and (0b101 & 0b100 = 0b100 = 4)
            System.Console.WriteLine("x = 5 & 4 , the result: x = " + x);
            x = 5 | 4; // or (0b101 | 0b100 = 0b101 = 5)
            System.Console.WriteLine("x = 5 | 4 , the result: x = " + x);
            x = 5 ^ 4; // xor (0b101 ^ 0b100 = 0b001 = 1)
            System.Console.WriteLine("x = 5 ^ 4 , the result: x = " + x);
            x = 4 << 1; // left shift (0b100 << 1 = 0b1000 = 8)
            System.Console.WriteLine("x = 5 << 4 , the result: x = " + x);
            x = 4 >> 1; // right shift (0b100 >> 1 = 0b10 = 2)
            System.Console.WriteLine("x = 5 >> 4 , the result: x = " + x);
            x = ~4; // invert (~0b00000100 = 0b11111011 = -5)
            System.Console.WriteLine("x = ~4 , the result: x = " + x);

            System.Console.ReadLine();
        }
    }
}
