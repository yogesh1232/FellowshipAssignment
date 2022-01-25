using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Assignment
{
	class QuotientRemainder
	{
		public static void GetQuotientRemainder()
		{
			int Firstnumber, Secondnumber, quotient, remainder;
			Console.Write("Enter first number:");
			Firstnumber = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter second number:");
			Secondnumber = Convert.ToInt32(Console.ReadLine());

			quotient = Firstnumber / Secondnumber;
			remainder = Firstnumber % Secondnumber;

			Console.WriteLine("Quotient is:" + quotient);
			Console.WriteLine("Remainder is:" + remainder);

		}
	}
}