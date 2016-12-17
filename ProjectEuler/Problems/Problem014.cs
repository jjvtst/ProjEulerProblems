using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace ProjectEuler
{
	/// <summary>
	///
	///		Longest Collatz sequence
	/// 
	///	  The following iterative sequence is defined for the set of positive integers:
	///	  
	///			n → n/2 (n is even)
	///			n → 3n + 1 (n is odd)
	///	  
	///	  Using the rule above and starting with 13, we generate the following sequence:
	///	  
	///			13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
	///	  
	///	  It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
	///	  
	///	  Which starting number, under one million, produces the longest chain?
	///	  
	///	  NOTE: Once the chain starts the terms are allowed to go above one million.
	/// 
	/// </summary>
	class Problem014
	{
		/// <summary>
		/// 
		/// </summary>
		const bool ENABLE_PARALLEL_PROCESSING = false;

		/// <summary>
		/// Our starting number
		/// </summary>
		const int COLLATZ_STARTING_NUMBER = 1000000 - 1;

		public long Solve()
		{
			// ===============================
			GC.Collect();
			System.Threading.Thread.Sleep( 10 );
			// ===============================

			var retVal = 0;

			// Setup
			int seqMaxCount = 0,
				seqNumber = COLLATZ_STARTING_NUMBER,
				seqCount = 0,
				seqNumberMaxCount = 0;
			long seqCurrNumber = 0;


			var enSeq = Enumerable.Reverse( Enumerable.Range( 1, COLLATZ_STARTING_NUMBER ) );

			// -----------
			var t1 = Stopwatch.StartNew();
			// -----------

			// Check the PM project RF1toRF20upgrader
			if( ENABLE_PARALLEL_PROCESSING )
			{
				//Parallel.
				//const int numThreads = 10;
				//_apmPrimes = new ApmPrimes[ numThreads ];
				//for( int i = 0; i < numThreads; i++ )
				//{
				//	_apmPrimes[ i ] = new ApmPrimes();
				//	_apmPrimes[ i ].BeginGetPrimeNumbers( i == 0 ? 2 : i * 1000000 + 1, ( i + 1 ) * 1000000, GetPrimesCallback, i );
				//}
			}
			else
			{
				do
				{
					seqCurrNumber = seqNumber;
					seqCount = 0;

					while( seqCurrNumber > 0 )
					{
						seqCurrNumber = ( ( seqCurrNumber & 1 ) == 0 ) ? ( seqCurrNumber >> 1 ) : ( 3 * seqCurrNumber + 1 );

						if( seqCurrNumber > 1 )
							seqCount++;
						else
							break;
					}

					if( seqCount > seqMaxCount )
					{
						seqMaxCount = seqCount;
						seqNumberMaxCount = seqNumber;
					}

				} while( --seqNumber > 0 );
			}

			// -----------
			t1.Stop();
			var took = t1.Elapsed.TotalMilliseconds;
			// -----------
			retVal = seqNumberMaxCount;

			// ===============================
			Console.WriteLine( "---Solution N took {0} ms", t1.Elapsed.TotalMilliseconds );
			// ===============================

			return retVal;
		}
	}
}
