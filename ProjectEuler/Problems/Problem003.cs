using System;
using System.Collections.Generic;

namespace ProjectEuler
{
	/// <summary>
	/// Largest prime factor
	/// 
	/// The prime factors of 13195 are 5, 7, 13 and 29.
	///
	///	What is the largest prime factor of the number 600851475143 ?
	/// </summary>
	class Problem003
	{
		const long REF_NUMBER = 600851475143;

		public long Solve()
		{
			DateTime startTime = DateTime.Now;
			// ===============================
			long _dividend = REF_NUMBER,
				_divisor = 2;

			List<long> primeFactors = new List<long>();

			long loopCnt = 0;

			while( _dividend >= _divisor )
			{
				// Check if we can divide
				if( ( _dividend % _divisor ) == 0 )
				{
					// Set the dividend to the division's result
					_dividend = _dividend / _divisor;

					// Store the divisor
					primeFactors.Add( _divisor );
				}

				// Inc divisor
				_divisor++;
				loopCnt++;
			}

			// ===============================
			DateTime stopTime = DateTime.Now;
			Console.WriteLine( "---Solution 3 took {0} ms", ( stopTime - startTime ).Milliseconds );
			// ===============================

			return primeFactors[ primeFactors.Count - 1 ];
		}

		long factorial( long n )
		{
			if( n <= 1 )
				return 1;
			return n * factorial( n - 1 );
		}

	}
}
