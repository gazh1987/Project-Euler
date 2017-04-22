using System;
using System.Collections.Generic;

namespace EvenFibonacciNumbers_ProjectEuler_Problem2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			double gn = Garynacci();
			Console.WriteLine("The sum of Even valued terms below 4million in fibonnaci sequemce is " + gn);
		}

		static double Garynacci()
		{
			List<double> prev = new List<double>();
			prev.Add(1);
			prev.Add(1);
			int seq = 2;
			double val;
			double sumOfEvenValuedTerms = 0;
				
			while (sumOfEvenValuedTerms <= 4000000)
			{
				val = prev[seq - 1] + prev[seq - 2];
				prev.Add(val);

				if (isEven(val))
				{
					sumOfEvenValuedTerms += val;
					Console.WriteLine("Seq=" + seq + ", Val= " + val + ", " + prev[seq - 1] + " + " + prev[seq - 2]);
				}

				seq++;
			}

			return sumOfEvenValuedTerms;
		}

		static bool isEven(double val)
		{
			return val % 2 == 0;
		}
	}
}
