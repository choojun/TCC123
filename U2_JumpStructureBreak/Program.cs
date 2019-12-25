using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_JumpStructureBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 11, 22, 33, 44, 55, 66, 77, 88, 99, 101 };
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 33)
                {
                    break;
                }
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("End of Loop");
        }
    }
}
