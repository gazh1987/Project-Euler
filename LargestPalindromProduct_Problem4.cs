using System;

namespace LargestPalindromeProduct
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			double highestPalindrome = 0;
			double prod = 0;

			for (int i = 100; i <= 1000; i++)
			{
				for (int j = 100; j <= 1000; j++)
				{
					prod = i * j;
					if (isPalindrome(prod))
					{
						if (prod > highestPalindrome)
						{
							highestPalindrome = prod;
						}
					}
				}
			}

			Console.WriteLine("Highest Palindrome is " + highestPalindrome);
		}

		static bool isPalindrome(double num)
		{
			string numString = num.ToString();
			var numArray = numString.ToCharArray();

			for (int i = 0; i <= numArray.Length / 2 - 1; i++)
			{
				if (!isEqual(numArray[i], numArray[numArray.Length - 1 - i]))
				{
					return false;
				}
			}

			return true;
		}

		static bool isEqual(char a, char b)
		{
			return a == b;
		}
	}
}
