﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_DecisionStructureSwitch_OddEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number");
            int number;
            int.TryParse(Console.ReadLine(), out number);
            switch (number % 2)
            {
                case 0:
                    Console.WriteLine("{0} is an even number", number);
                    break;
                case 1:
                    Console.WriteLine("{0} is an odd number", number);
                    break;
            }
            Console.ReadLine();
        }
    }
}
