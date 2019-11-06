using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_CalculateProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Activity 2.5 Question 1
            double revenue, costs, profits;
            revenue = 1000.0;
            costs = 800.0;
            profits = revenue - costs;

            System.Console.WriteLine("Profit of WOU Sdn. Bhd.: " + profits);
            System.Console.ReadLine();
        }
    }
}
