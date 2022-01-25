using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Assignment
{
    class SwapNumber
     {
        public static void GetSwap()
            {
                int Firstnumber = 5, Secondnumber = 10;
                Console.WriteLine("Before swap a= " + Firstnumber + " b= " + Secondnumber);
                Firstnumber = Firstnumber * Secondnumber; //a=50 (5*10)      
                Secondnumber = Firstnumber / Secondnumber; //b=5 (50/10)      
                Firstnumber = Firstnumber / Secondnumber; //a=10 (50/5)    
                Console.Write("After swap a= " + Firstnumber + " b= " + Secondnumber);
            }
     }
 }

