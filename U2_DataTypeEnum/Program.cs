using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_DataTypeEnum
{
    enum Status
    {
        //list of named constants
        Alive,
        Injured,
        Dead
    }
    class Program
    {
        static void Main(string[] args)
        {
            Status basketballPlayer = Status.Alive;
            switch (basketballPlayer)
            {
                case Status.Alive:
                    //Do Alive Code
                    Console.WriteLine("Status basketballPlayer: {0} {1}", 
                        (int)basketballPlayer, basketballPlayer);
                    break;
                case Status.Injured:
                    //DO Injured Code
                    Console.WriteLine("Status basketballPlayer: {0} {1}", 
                        (int)basketballPlayer, basketballPlayer);
                    break;
                case Status.Dead:
                    //Do Dead Code
                    Console.WriteLine("Status basketballPlayer: {0} {1}", 
                        (int)basketballPlayer, basketballPlayer);
                    break;
            }
            Console.ReadLine();
        }
    }
}

