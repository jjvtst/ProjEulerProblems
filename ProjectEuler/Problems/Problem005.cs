using System;
using System.Collections.Generic;

namespace ProjectEuler
{
	/// <summary>
	/// Smallest multiple
	/// 
	/// 2520 is the smallest number that can be divided by
	/// each of the numbers from 1 to 10 without any remainder.
	/// 
	/// What is the smallest positive number that is evenly divisible by
	/// all of the numbers from 1 to 20?
	/// </summary>
	class Problem005
	{
		const int DIVISOR_RANGE_START = 1;
		const int DIVISOR_RANGE_END = 20;
		const int DIVISOR_COUNT = DIVISOR_RANGE_START + ( DIVISOR_RANGE_END - DIVISOR_RANGE_START );

		public int Solve()
		{
			DateTime startTime = DateTime.Now;
			//
			// Brute force
			//
			int smallestMultiple = DIVISOR_RANGE_START + ( DIVISOR_RANGE_END - DIVISOR_RANGE_START );
			int matches = 0;

			--smallestMultiple;

			do
			{
				++smallestMultiple;
				matches = 0;

				for( int i = DIVISOR_RANGE_START; i <= DIVISOR_RANGE_END; i++ )
				{
					if( ( smallestMultiple % i ) == 0 )
						++matches;
				}

			} while( DIVISOR_COUNT != matches );

			// ===============================
			DateTime stopTime = DateTime.Now;
			Console.WriteLine( "---Solution 5 took {0} ms", ( stopTime - startTime ).Milliseconds );

			return smallestMultiple;
		}
	}
}
