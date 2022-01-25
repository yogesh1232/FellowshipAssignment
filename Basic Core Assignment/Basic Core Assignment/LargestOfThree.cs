using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Assignment
{
    class LargestOfThree
    {
        public static void GetLargest()
        {
            int number1;
            Console.WriteLine("Enter First Numner" );
            number1 = Convert.ToInt32(Console.ReadLine());
            int number2;
            Console.WriteLine("Enter First Numner");
            number2 = Convert.ToInt32(Console.ReadLine());
            int number3;
            Console.WriteLine("Enter First Numner");
            number3 = Convert.ToInt32(Console.ReadLine());
            if (number1 > number2 && number1 > number3)
                Console.WriteLine("a is Greater");
            else if (number2 > number3 && number2 > number1)
                Console.WriteLine("b is Greater");
            else
                Console.WriteLine("c is Greater");

        }
    }
}
