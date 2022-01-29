﻿using Binary_Search_Tree;

Console.WriteLine("\\nHello World!"); //[3,7,9,11,55,67]
BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
binarySearch.Insert(30);
binarySearch.Insert(70);
binarySearch.Insert(22);
binarySearch.Insert(40);
binarySearch.Insert(60);
binarySearch.Insert(95);
binarySearch.Insert(11);
binarySearch.Insert(65);
binarySearch.Insert(3);
binarySearch.Insert(16);
binarySearch.Insert(63);
binarySearch.Insert(67);
binarySearch.Display();
bool result = binarySearch.IfExists(63, binarySearch);
Console.WriteLine(result);
if (result == true)
{
    Console.WriteLine("Key found");
}
else
{
    Console.WriteLine("Key not found");
}
Console.ReadKey();
