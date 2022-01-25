﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Maximum_Number
{
	class GenericMaximum<T> where T : IComparable
	{
		public T[] value;
		public GenericMaximum(T[] value)
		{
			this.value = value;
		}
		public T[] Sort(T[] values)
		{
			Array.Sort(values);
			return values;
		}
		public T MaxValue(params T[] values)
		{
			var sorted_values = Sort(values);
			return sorted_values[sorted_values.Length - 1];
		}
		public T MaxMethod()
		{
			var max = MaxValue(this.value);
			return max;
		}
		public void PrintMaxValue()
		{
			var max = MaxValue(this.value);
			Console.WriteLine("Maxmimum value is :" + max);
		}
	}
}
