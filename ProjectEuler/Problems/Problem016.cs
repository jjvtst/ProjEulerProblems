using System;
using System.Diagnostics;
using System.Numerics;

namespace ProjectEuler
{
	/// <summary>
	/// 
	///		Power digit sum
	///		
	///	2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
	///	
	/// What is the sum of the digits of the number 2^1000?
	/// 
	/// Started:	19/12/2015
	/// Finished:	19/12/2015
	/// 
	/// </summary>
	class Problem016
	{
		const int VAL_EXP = 1000;

		public long Solve()
		{
			GC.Collect();
			System.Threading.Thread.Sleep( 10 );
			var t0 = Stopwatch.StartNew();
			// ===============================

			string asStr = BigInteger.Pow( 2, VAL_EXP ).ToString();
			double nSum1 = 0;

			for( int i = 0, aLen = asStr.Length; i < aLen; i++ )
			{
				nSum1 += char.GetNumericValue( asStr, i );
			}

			long retVal = (long)nSum1;

			// ===============================
			t0.Stop();
			Console.WriteLine( "---Solution 16 took {0} ms", t0.Elapsed.TotalMilliseconds );
			// ===============================

			return retVal;
		}
	}
}
