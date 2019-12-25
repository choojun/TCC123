using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_JumpStructureGoto
{
    class Program
    {
        static void Main(string[] args)
        {
            char character = 'e';
            switch (character)
            {
                case 'a':
                    {
                        Console.WriteLine("Character is a vowel.");
                        break;
                    }
                case 'e':
                    {
                        goto case 'a';
                    }
                case 'i':
                    {
                        goto case 'a';
                    }
                case 'o':
                    {
                        goto case 'a';
                    }
                case 'u':
                    {
                        goto case 'a';
                    }
                case 'y':
                    {
                        Console.WriteLine("Character is sometimes a vowel.");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Character is a consonant");
                        break;
                    }
            }



            int[] numbers = new int[] { 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 9)
                    goto Control;
            }
            Console.WriteLine("End of Loop");

        Control:
            Console.WriteLine("The number is 9");
        }
    }
}
