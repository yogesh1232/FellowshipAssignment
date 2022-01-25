using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Assignment
{
    class VowelConsonant
    {
        public static void GetVowel()
        {
            char ch;

            Console.WriteLine("Enter any character: ");
            ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                Console.WriteLine(ch + " is Vowel.");
            else 
                Console.WriteLine(ch + " is Consonant.");
            
            Console.ReadLine();
        }
    }
}
