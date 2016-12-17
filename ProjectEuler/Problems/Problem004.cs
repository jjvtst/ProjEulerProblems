using System;
using System.Collections.Generic;

namespace ProjectEuler
{
	/// <summary>
	/// Largest palindrome product
	/// 
	/// A palindromic number reads the same both ways. The largest palindrome
	/// made from the product of two 2-digit numbers is 9009 = 91 × 99.
	///
	/// Find the largest palindrome made from the product of two 3-digit numbers.
	/// </summary>
	class Problem004
	{
		const int DIGIT_COUNT = 3;

		public int Solve()
		{
			DateTime startTime = DateTime.Now;
			// ===============================
			int numA = 0, tmpA = 0,
				numB = 0, tmpB = 0,
				maxVal = 0, minVal = 0,
				mulRes = 0, maxMulRes = 0,
				numUsed = 2, largestPalindrome = 0;


			// Initial values: 2 digit - 99, 3 digit - 999, ...
			maxVal = ( (int)Math.Pow( 10, DIGIT_COUNT ) ) - 1;
			minVal = (int)Math.Pow( 10, DIGIT_COUNT - 1 );
			maxMulRes = maxVal * maxVal;

			tmpA = tmpB = minVal;

			do
			{
				mulRes = tmpA * tmpB;

				++tmpA;
				if( tmpA > maxVal )
				{
					tmpA = minVal;
					++tmpB;
					if( tmpB > maxVal )
					{
						break;
					}
				}

				if( isPalindrome( mulRes ) )
				{
					largestPalindrome = mulRes;
				}

			} while( mulRes < maxMulRes );


			// ===============================
			DateTime stopTime = DateTime.Now;
			Console.WriteLine( "---Solution 4 took {0} ms", ( stopTime - startTime ).Milliseconds );

			return largestPalindrome;
		}


		bool isPalindrome( int num )
		{
			char[] numAsCharArray = num.ToString().ToCharArray();
			int aLen = numAsCharArray.Length,
				fi = 0,
				li = aLen - 1,
				loopCnt = 0,
				matches = 0;

			while( fi <= li )
			{
				bool para = false;

				if( numAsCharArray[ fi ] == numAsCharArray[ li ] )
					++matches;

				++loopCnt;

				// early exit...
				if( matches != loopCnt )
					break;

				++fi;
				--li;
			}

			return matches == loopCnt;
		}


		int ReverseInt( int num )
		{
			int result = 0;
			while( num > 0 )
			{
				result = result * 10 + num % 10;
				num /= 10;
			}
			return result;
		}
	}
}
