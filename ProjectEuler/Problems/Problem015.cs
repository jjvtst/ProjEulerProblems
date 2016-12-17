using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProjectEuler
{
	/// <summary>
	/// 
	///		Lattice paths
	///		
	///	Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down,
	///	there are exactly 6 routes to the bottom right corner.
	///	
	/// How many such routes are there through a 20×20 grid?
	/// 
	/// Started:	15/12/2015 
	/// Finished:	***PUT ON HOLD, NEED TO LEARN ON GRAPHS AND COMBINATORICS***
	/// 
	/// </summary>
	class Problem015
	{
		const int ROW_SIZE = 2;
		const int COL_SIZE = 2;
		const byte NO_PATH = 0;
		const byte CAN_RIGHT = 0x1;
		const byte CAN_DOWN = 0x2;

		//byte[,] mGrid = new byte[ ROW_SIZE, COL_SIZE ];

		public int Solve()
		{
			GC.Collect();
			System.Threading.Thread.Sleep( 10 );
			var t0 = Stopwatch.StartNew();
			// ===============================

			var retVal = 0;

			// Init with well known paths
			int pathsCount = 0;	// ( COL_SIZE + 1) * ( ROW_SIZE - 1 ) + 1;

			for( int i = 0; i < ROW_SIZE; i++ )
			{
				for( int j = COL_SIZE; --j >=0; )
				{
					//++pathsCount;
				}
			}

			// ===============================
			t0.Stop();
			Console.WriteLine( "---Solution 15 took {0} ms", t0.Elapsed.TotalMilliseconds );
			// ===============================

			return retVal;
		}
	}
}
