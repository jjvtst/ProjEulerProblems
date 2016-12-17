using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProjectEuler
{
	/// <summary>
	/// 
	///		TITLE_HERE_TITLE_HERE_
	///
	/// DESCRIPTION_HERE_DESCRIPTION_HERE_DESCRIPTION_HERE_
	/// 
	/// Started:	dd/mm/yyyy
	/// Finished:	dd/mm/yyyy
	/// 
	/// </summary>
	class Problem020
	{
		//char[] BIG_1000_DIGIT_NUMBER = "50".ToCharArray();
		//const int ADJ_DIGIT_COUNT = 13;


		public long Solve()
		{
			GC.Collect();
			System.Threading.Thread.Sleep( 10 );
			var t0 = Stopwatch.StartNew();
			// ===============================

			var retVal = 0;



			// ===============================
			t0.Stop();
			Console.WriteLine( "---Solution NN took {0} ms", t0.Elapsed.TotalMilliseconds );
			// ===============================

			return retVal;
		}
	}
}
