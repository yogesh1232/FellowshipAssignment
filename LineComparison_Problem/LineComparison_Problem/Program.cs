using LineComparison_Problem;

namespace LineComparisonProblem
{
    class Program
    {
        // variables
        static double distance1, distance2;
        /// <summary>
        /// used CompareTo method to check the line is greater,less or both are equals.
        /// </summary>
        public static void CheckLine()
        {
            LineComparison lineComparison1 = new LineComparison(1.2, 2.3, 4.5, 3.2);
            distance1 = lineComparison1.Length();
            LineComparison lineComparison2 = new LineComparison(1.0, 2.5, 3.5, 1.2);
            distance2 = lineComparison2.Length();
            if (distance1.CompareTo(distance2) > 0)
                Console.WriteLine("The length of first line is greater than second line.");
            else if (distance1.CompareTo(distance2) < 0)
                Console.WriteLine("The length of first line is less than second line.");
            else
                Console.WriteLine("Both the lines are equal.");
        }
        static void Main(string[] args)
        {
            Program.CheckLine();
        }
    }
}