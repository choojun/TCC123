using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_StationeryCost
{
    class Program
    {
        static void Main(string[] args)
        {
            // Activity 2.5 Question 2
            double unitPrice, totalCost;
            int quantity;
            unitPrice = 2.0;
            quantity = 10;
            totalCost = unitPrice * quantity;

            System.Console.WriteLine("Total stationery cost: " + totalCost);
            System.Console.ReadLine();
        }
    }
}
