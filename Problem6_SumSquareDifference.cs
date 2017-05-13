using System;

namespace sumAquareDifference_problem6
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int n = 100;
			Console.WriteLine(sqrOfSum(n) - sumOfSqr(n));
		}

		static int sumOfSqr(int n)
		{
			int s = 0;

			for (int i = 1; i <= n; i++)
			{
				s += i* i;
			}

			return s;
		}

		static int sqrOfSum(int n)
		{
			int s = 0;

			for (int i = 1; i <= n; i++)
			{
				s += i;
			}

			return s * s;
		}
	}
}
