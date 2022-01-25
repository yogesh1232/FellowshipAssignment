using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Assignment
{
    class Factors
    {
        public static void GetFactor()
        {
            int num, x;
            Console.WriteLine("Enter the Number ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Factors are : ");
            for (x = 1; x <= num; x++)
            {
                if (num % x == 0)
                {
                    Console.WriteLine(x);
                }
            }
            Console.ReadLine();

        }
    }
}
