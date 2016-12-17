using System;
using System.Collections.Generic;

namespace ProjectEuler
{
	/// <summary>
	/// Summation of primes
	/// 
	/// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
	/// 
	/// Find the sum of all the primes below two million.
	/// </summary>
	class Problem010
	{
		const long PRIME_MAX_VALUE = 2000000;
		//char[] BIG_1000_DIGIT_NUMBER = "50".ToCharArray();


		public long Solve()
		{
			DateTime startTime = DateTime.Now;
			// ===============================

			long retVal = 0;

			long[] primesLst = Helper.GetPrimes( PRIME_MAX_VALUE );

			// Skip the last value...
			for( int i = primesLst.Length - 1; --i >= 0; )
			{
				retVal += primesLst[ i ];
			}

			// ===============================
			DateTime stopTime = DateTime.Now;
			Console.WriteLine( "---Solution 10 took {0} ms", ( stopTime - startTime ).Milliseconds );
			// ===============================

			return retVal;
		}
	}
}
