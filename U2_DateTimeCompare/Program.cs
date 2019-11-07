using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_DateTimeCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            // assign today's date
            DateTime todayDate = DateTime.Now;
            Console.WriteLine(todayDate);
            // add two months
            DateTime newDate = todayDate.AddMonths(2);
            Console.WriteLine("Interval days after 2 months: " + (newDate - todayDate).TotalDays);
            Console.ReadLine();
        }
    }
}
