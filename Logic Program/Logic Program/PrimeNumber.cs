using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Program
{
    class PrimeNumber
    {
        public static void GetPrimeNumber()
        {
            int n , a = 0;
            Console.WriteLine("Enter a Number:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine( n + "is a Prime Number");
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
            Console.ReadLine();
        }
    }
}
