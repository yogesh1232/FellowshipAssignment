using System;
using Algorithm_Problem;

namespace Algorithm_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            //InsertionSort
            int[] arr = { 22, 12, 74, 2, 6 };
            Console.WriteLine("Welcome to Insertion sort. Sorted array is: ");
            InsertionSort ob = new InsertionSort();
            ob.sort(arr);

            //Bubble Sort
            int[] arr1 = { 14, 12, 32, 45, 66, 11, 20 };
            BubbleSort obj1 = new BubbleSort();
            obj1.bubbleSort(arr1);
            Console.WriteLine("\nWelcome to Bubble sort. Sorted array is: ");
            obj1.printArray1(arr1);

            // Merge Sort
            int[] arr2 = { 22, 12, 33, 2, 4, 5 };
            Console.WriteLine("\nWelcome to Bubble sort: ");
            Console.WriteLine("Given Array");
            MergeSort ob2 = new MergeSort();
            ob2.printArray2(arr2);

            ob2.sort(arr2, 0, arr2.Length - 1);
            Console.WriteLine("\nSorted array");
            ob2.printArray2(arr2);


            #region Anagram_Detection_Problem

            string firstString, secondString;
            //Gets words from user.  
            Console.WriteLine("Enter first string");
            firstString = Console.ReadLine();
            Console.WriteLine("Enter second string");
            secondString = Console.ReadLine();
            AnagramDetection anagram = new AnagramDetection();
            //Check if words are anagram  
            if (anagram.areAnagram(firstString, secondString) == true)
            {
                Console.WriteLine("Both string are anagram string.");
            }
            else
            {
                Console.WriteLine("Both string are not anagram string.");
            }

            #endregion
        }
    }
}