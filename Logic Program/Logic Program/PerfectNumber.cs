using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Program
{
    class PerfectNumber
    {
        public static void GetPerfectNumber()
        {  
            int number, sum = 0, n;
            Console.WriteLine("Enter the Number :");
            number = Convert.ToInt32(Console.ReadLine());
            n = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine(number  + "is a perfect number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(number + "is not a perfect number");
                Console.ReadLine();
            }
        }
    }
}
