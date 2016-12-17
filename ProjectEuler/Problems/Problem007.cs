using System;
using System.Collections.Generic;

namespace ProjectEuler
{
	/// <summary>
	/// 10001st prime
	/// 
	/// By listing the first six prime numbers: 2, 3, 5, 7, 11,
	/// and 13, we can see that the 6th prime is 13.
	/// 
	/// What is the 10 001st prime number?
	/// </summary>
	class Problem007
	{
		const int TARGET_PRIME_NUMBER_INDEX = 10001;

		public long Solve()
		{
			DateTime startTime = DateTime.Now;

			long tvar = Helper.GetPrime( TARGET_PRIME_NUMBER_INDEX );

			// ===============================
			DateTime stopTime = DateTime.Now;
			Console.WriteLine( "---Solution 7 took {0} ms", ( stopTime - startTime ).Milliseconds );

			return tvar;
		}
	}
}
