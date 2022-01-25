using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Assignment
{
    class PowerOfTwo
    {
        public static void GetpowerOfTwo()
        {
            int bNum, pwr;
            int result;

            Console.WriteLine(" Input the base  value : ");
            bNum = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Input the exponent : ");
            pwr = Convert.ToInt32(Console.ReadLine());

            result = CalcuOfPower(bNum, pwr);//called the function CalcuOfPower

            Console.WriteLine(" The value of {0} to the power of {1} is : {2} " , bNum, pwr, result);
        }

        public static int CalcuOfPower(int x, int y)
        {
            if (y == 0)
                return 1;
            else
                return x * CalcuOfPower(x, y - 1);
        }
    }
}