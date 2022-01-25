using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Assignment
{
        class CheckLeapYear
        {
            public static void GetLeapyear()
            {
                int Year = 0;
                Console.WriteLine("Enter Year : ");
                Year = Convert.ToInt32(Console.ReadLine());
                if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
                    Console.WriteLine(Year + " is a Leap Year.");
                else Console.WriteLine(Year + " is Not aLeap Year");

            }
        }
}



