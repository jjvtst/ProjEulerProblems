using System;
using System.Collections.Generic;

namespace ProjectEuler
{
	/// <summary>
	/// Special Pythagorean triplet
	/// 
	/// A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
	/// 
	/// a^2 + b^2 = c^2
	/// For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
	/// 
	/// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
	/// Find the product abc.
	/// </summary>
	class Problem009
	{
		const int SUM_A_B_C_RES = 1000;
		const int RETRIES_COUNT = 100;

		/// <summary>
		/// Implemented using the method from: http://www.mathsisfun.com/numbers/pythagorean-triples.html
		/// (Scroll to "Constructing Pythagorean Triples")
		/// </summary>
		/// <returns></returns>
		public long Solve()
		{
			DateTime startTime = DateTime.Now;
			// ===============================

			// The abc product
			long retVal = 0;

			// m < n
			int m, n,
				dNM = 0;
			int sum_Of_a_b_c;
			int a, b, c;
			int retryCounter = 0;

			// Outside loop where we increase the m - n difference by one at a time
			do
			{
				++retryCounter;

				m = n = sum_Of_a_b_c =
				a = b = c = 0;
				++dNM;

				//
				do
				{
					// 1 inc
					++m;
					n = m + dNM; // n = m + 1, so m < n ...

					int nSqr = n * n;
					int mSqr = m * m;
					// a = n^2 - m^2
					a = nSqr - mSqr;

					// b = 2nm
					b = 2 * n * m;

					// c = n^2 + m^2
					c = nSqr + mSqr;

					sum_Of_a_b_c = a + b + c;

				} while( sum_Of_a_b_c < SUM_A_B_C_RES );

				if( sum_Of_a_b_c == SUM_A_B_C_RES )
				{
					retVal = a * b * c;
					break;
				}
				else
				{
					// ...
					retVal = -1;
				}


			} while( retryCounter < RETRIES_COUNT );


			// ===============================
			DateTime stopTime = DateTime.Now;
			Console.WriteLine( "---Solution 9 took {0} ms", ( stopTime - startTime ).Milliseconds );
			// ===============================

			return retVal;
		}
	}
}
