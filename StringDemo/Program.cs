using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            string address = "pat Lynch";

            // using index to access a specific character
            Console.WriteLine(" ******  access first character  **********");
            Console.WriteLine(address[0]);

            Console.WriteLine(" ******  access all characters  **********");
            for (int i = 0; i < address.Length; i++)
            {
                Console.WriteLine(address[i]);
            }

            Console.WriteLine(" ******  check if string starts with a particular value  **********");
            bool startsWithPat = address.StartsWith("Pat");

            Console.WriteLine(startsWithPat);

            Console.WriteLine(" ******  insert some text to end of string  **********");

            address = address.Insert(address.Length, ",Sligo");

            Console.WriteLine(address);


            Console.WriteLine(" ******  find the first name  **********");
            int firstSpace = address.IndexOf(" ");

            string firstName;
            if (firstSpace == -1)
                firstName = address;
            else
                firstName = address.Substring(0, firstSpace);// pull out all text from first character to where the first space is
            Console.WriteLine(firstName);

            Console.WriteLine(" ******  convert to lower  **********");
            string firstLetter = firstName.Substring(0, 1).ToUpper();

            string others = firstName.Substring(1,firstName.Length-1).ToLower();

            string newName = firstLetter + others;

            Console.WriteLine(newName);

            Console.WriteLine(" ******  split  **********");
            // split
            string[] words = address.Split(' ');  // split the string whereever there is a ',' and place the words into an array
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }

            // padleft
            Console.WriteLine(" ******  padleft  **********");
            newName = newName.PadLeft(10,'#');
            Console.WriteLine(newName);
        }
    }
}
