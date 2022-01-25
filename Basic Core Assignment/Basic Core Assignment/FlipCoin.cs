using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Assignment
{
    class FlipCoin
    {
        public static void GetHeadTail()
        {
            int headsCount = 0, tailsCount = 0;
            Console.WriteLine("Enter the no of turns");
            int numberOfTurns = Convert.ToInt32(Console.ReadLine());
            if (numberOfTurns > 0)
            {
                for (int i = 0; i < numberOfTurns; i++)
                {
                    Random random = new Random();
                    double coin = random.NextDouble();
                    if (coin > 0.5)
                    {
                        headsCount++;
                    }
                    else
                    {
                        tailsCount++;
                    }
                }
                Console.WriteLine("Heads:" + headsCount + "and" + "Tails:" + tailsCount);
                double headPercentage = (((double)headsCount / numberOfTurns) * 100);
                double tailPercentage = (((double)tailsCount / numberOfTurns) * 100);
                Console.WriteLine("Head Percentage is: " + headPercentage + "%");
                Console.WriteLine("Tail Percentage is: " + tailPercentage + "%");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Please enter the valid input");
                Console.ReadKey();
            }
        }
    }
    
}


