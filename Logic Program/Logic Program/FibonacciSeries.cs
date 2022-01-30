using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Program
{
    class FibonacciSeries
    {
        public static void GetFibonacciSeries()
        {
            int first = 0, second = 1, fibonacci, i, number;
            Console.Write("Enter the number of elements: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write(first + " " + second + " ");     
            for (i = 2; i < number; ++i)     
            {
                fibonacci = first + second;
                Console.Write(fibonacci + " ");
                first = second;
                second = fibonacci;
            }
        }
    }
}
