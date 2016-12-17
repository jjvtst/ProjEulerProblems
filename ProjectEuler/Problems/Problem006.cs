using System;
using System.Collections.Generic;

namespace ProjectEuler
{
	/// <summary>
	/// Sum square difference
	/// 
	/// The sum of the squares of the first ten natural numbers is,
	/// 
	/// 12 + 22 + ... + 102 = 385
	/// The square of the sum of the first ten natural numbers is,
	/// 
	/// (1 + 2 + ... + 10)2 = 552 = 3025
	/// Hence the difference between the sum of the squares of the first
	/// ten natural numbers and the square of the sum is 3025 − 385 = 2640.
	/// 
	/// Find the difference between the sum of the squares of the first one hundred
	/// natural numbers and the square of the sum
	/// 
	/// </summary>
	class Problem006
	{
		const int NUMBERS_RANGE_START = 1;
		const int NUMBERS_RANGE_END = 100;
		const int NUMBERS_COUNT = NUMBERS_RANGE_START + ( NUMBERS_RANGE_END - NUMBERS_RANGE_START );

		public int Solve()
		{
			DateTime startTime = DateTime.Now;
			int sumOfSquares = 0;
			int squareOfSum = 0;

			for( int i = NUMBERS_RANGE_START; i <= NUMBERS_RANGE_END; i++ )
			{
				sumOfSquares += i * i;
				squareOfSum += i;
			}
			squareOfSum = squareOfSum * squareOfSum;

			// ===============================
			DateTime stopTime = DateTime.Now;
			Console.WriteLine( "---Solution 6 took {0} ms", ( stopTime - startTime ).Milliseconds );

			return squareOfSum - sumOfSquares;
		}
	}
}
