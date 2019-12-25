using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_LoopStructureDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            string userIsDone = "";
            do
            {
                Console.WriteLine("In do-while loop");
                Console.Write("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            } while (userIsDone.ToLower() != "yes"); // Note the semicolon!
        }
    }
}
