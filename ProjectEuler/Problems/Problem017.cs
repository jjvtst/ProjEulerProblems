using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProjectEuler
{
	/// <summary>
	/// 
	///		Number letter counts
	///
	/// If the numbers 1 to 5 are written out in words:
	/// one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
	/// 
	/// If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words,
	/// how many letters would be used?
	/// 
	/// NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two)
	/// contains 23 letters and 115 (one hundred and fifteen) contains 20 letters.
	/// The use of "and" when writing out numbers is in compliance with British usage
	/// 
	/// Started:	29/11/2016
	/// Finished:	dd/mm/yyyy
	/// 
	/// </summary>
	class Problem017
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
			char[] spc = { ' ', '-' };

			// 1 - 1000
			for( int i = 1; i <= 1000; i++ )
			{
				string numberInWords = Helper.IntegerToWritten( i );

				// Get the whole string length
				int letterCount = numberInWords.Length;

				// Substract any spaces or hyphens found
				int lastStrIndx = 0;
				for( lastStrIndx = 0, letterCount++; lastStrIndx >= 0; letterCount-- )
				{
					lastStrIndx = numberInWords.IndexOfAny( spc, lastStrIndx + 1 );
				}

				// Add to the total
				retVal += letterCount;
			}

			// ===============================
			t0.Stop();
			Console.WriteLine( "---Solution 17 took {0} ms", t0.Elapsed.TotalMilliseconds );
			// ===============================

			return retVal;
		}
	}
}
