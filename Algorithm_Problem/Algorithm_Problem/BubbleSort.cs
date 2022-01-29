using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Problem
{
    public class BubbleSort
    {
        public void bubbleSort(int[] arr1)
        {
            int n = arr1.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr1[j] > arr1[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j + 1] = temp;
                    }
                }
            }
        }
        /* Prints the array */
        public void printArray1(int[] arr1)
        {
            int n = arr1.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr1[i] + " ");
            Console.WriteLine();
        }
    }
}
