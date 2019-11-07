using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_LengthMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringOne = "Hello World";

            // return the length of a string
            System.Console.WriteLine("The length of stringOne is "
                + stringOne.Length + " characters");
            // return the first 5 characters
            System.Console.WriteLine("The first 5 characters are "
                + stringOne.Substring(0, 5));
            // Find the index location of l
            System.Console.WriteLine("The first 'l' located at index "
                + stringOne.IndexOf("l"));
            // Replace the 'Hello' to 'Goodbye'
            System.Console.WriteLine("The Hello replaced by "
                + stringOne.Replace("Hello", "Goodbye"));
            // Convert 'Hello World' to uppercase
            System.Console.WriteLine("The Hello World in uppercase "
                + stringOne.ToUpper());
            // Convert 'Hello World' to lowercase
            System.Console.WriteLine("The Hello World in lowercase "
                + stringOne.ToLower());
            // Determines whether a string contains a specific substring
            Console.WriteLine("stringOne contains the letter r?: {0}",
                stringOne.Contains("r"));
            System.Console.ReadLine();
        }
    }
}
