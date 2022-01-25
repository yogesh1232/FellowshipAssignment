using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Assignment
{
    class Harmonic
    {
        public static void GetNumber()
        {
            int i, number;
            double s = 0.0;

            Console.Write("Calculate the harmonic series and their sum:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the number of terms : ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n");
            for (i = 1; i <= number; i++)
            {
                Console.Write("1/{0} + ", i);
                s += 1 / (float)i;
            }
            Console.Write("\nSum of Series upto {0} terms : {1} \n", number, s);
        }
    }
}
