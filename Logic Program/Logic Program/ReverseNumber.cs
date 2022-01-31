using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Program
{
    class ReverseNumber
    {
        public static void GetReverseNumber()
        {
            int number, reverse = 0, remainder;
            Console.WriteLine("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            while (number != 0)
            {
                remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number /= 10;
            }
            Console.WriteLine("Reversed Number: " + reverse);
        }
    }
}
