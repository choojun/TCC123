using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dteDateOfBirth = new System.DateTime(2006, 9, 22);
            DateTime dteMerdekaDay = new DateTime(1957, 8, 31);
            Console.WriteLine("My birthday is " + dteDateOfBirth);
            Console.WriteLine();

            DateTime dteDate;
            dteDate = DateTime.Now;
            Console.WriteLine("Today is " + dteDate);
            Console.WriteLine();

            DateTime dteDate1 = dteDate;
            DateTime dteDate2 = dteDate;
            DateTime dteDate3 = dteDate;
            DateTime dteDate4 = dteDate;
            DateTime dteDate5 = dteDate;
            // To add 5 months
            dteDate1 = dteDate1.AddMonths(5);
            Console.WriteLine("5 months later:\t new date is " + dteDate1);
            // To add 2 years
            dteDate2 = dteDate2.AddYears(2);
            Console.WriteLine("2 years later:\t new date is " + dteDate2);
            // To add 2 minutes
            dteDate3 = dteDate3.AddMinutes(2);
            Console.WriteLine("2 mins later:\t new date is " + dteDate3);
            // To add 2 days
            dteDate4 = dteDate4.AddDays(2);
            Console.WriteLine("2 days later:\t new date is " + dteDate4);
            // To add 2 hours
            dteDate5 = dteDate5.AddHours(2);
            Console.WriteLine("2 hours later:\t new date is " + dteDate5);
            Console.WriteLine();

            // Returns the number of days - after 5 months
            Console.WriteLine("5 months later:\t" + (dteDate1 - dteDate).TotalDays + " days, "
                + (dteDate1 - dteDate).TotalHours + " hours");
            // Return the number of days - after 2 years
            Console.WriteLine("2 years later:\t" +  (dteDate2 - dteDate).TotalDays + " days, "
                + (dteDate2 - dteDate).TotalHours + " hours");
            // Return the number of days - after 2 minutes
            Console.WriteLine("2 mins later:\t" + (dteDate3 - dteDate).TotalDays + " days, "
                + (dteDate3 - dteDate).TotalSeconds + " seconds");
            // Return the number of days - after 2 days
            Console.WriteLine("2 days later:\t" + (dteDate4 - dteDate).TotalDays + " days, "
                + (dteDate4 - dteDate).TotalSeconds + " seconds");
            // Return the number of days - after 2 hours
            Console.WriteLine("2 hours later:\t" + (dteDate5 - dteDate).TotalDays + " days, "
                + (dteDate5 - dteDate).TotalMilliseconds + " milliseconds");
            Console.ReadLine();
        }
    }
}
