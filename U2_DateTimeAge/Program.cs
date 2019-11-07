using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_DateTimeAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int year, month, day;
            Console.Write("Enter year of your birthday (in integer): ");
            year = int.Parse(Console.ReadLine());

            Console.Write("Enter month of your birthday (in integer): ");
            month = int.Parse(Console.ReadLine());

            Console.Write("Enter day of your birthday (in integer): ");
            day = int.Parse(Console.ReadLine());

            DateTime today = DateTime.Now;
            DateTime birthday = new DateTime(year, month, day);
            double age = (today - birthday).TotalDays / 365;
            Console.WriteLine("You are " + age + " years old");
            Console.ReadLine();
        }
    }
}
