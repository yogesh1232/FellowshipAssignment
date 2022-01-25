// See https://aka.ms/new-console-template for more information
using Find_Maximum_Number;

Console.WriteLine("Find the Maximum Number : ");
int output = MaximumNumberCheck.MaximumIntegerNumber(143, 141, 136);
Console.WriteLine(output);
double doubleoutput = MaximumNumberCheck.MaximumfloatNumber(10.66, 18.71, 36.42);
Console.WriteLine(doubleoutput);
string strigoutput = MaximumNumberCheck.MaximumStringNumber("Nitish", "nitish", "vishal");
Console.WriteLine(strigoutput);
int[] intArray = { 102, 356, 306, 421, 825 };
GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
generic.PrintMaxValue();
double[] doubleArray = { 92.2, 38.6, 56.42, 82.5, 10.61 };
GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
genericDouble.PrintMaxValue();
string[] stringArray = { "data", "notepad", "window", "server", "cloud" };
GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
genericString.PrintMaxValue();
Console.ReadKey();