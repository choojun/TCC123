using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_DecisionStructureIfElse_Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "Wawasan";
            if (username == "Wawasan")
            {
                Console.WriteLine("Login Successful");
            }
            else
            {
                Console.WriteLine("Inavlid username, please try again");
            }
        }
    }
}
