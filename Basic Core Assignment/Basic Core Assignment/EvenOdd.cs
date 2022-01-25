using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Assignment
{
    class EvenOdd
    {
        public static void GetEvenOdd()
        {
            int number;
            Console.WriteLine("Enter a Number");
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
                Console.WriteLine(number + "Number Is Even");
            else
                Console.WriteLine(number + "Number Is Odd");
        }
    }
}
