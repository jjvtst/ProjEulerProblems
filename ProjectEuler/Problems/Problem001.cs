using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
	/// <summary>
	/// Multiples of 3 and 5
	/// 
	/// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.
	/// The sum of these multiples is 23.
	/// Find the sum of all the multiples of 3 or 5 below 1000.
	/// </summary>
	class Problem001
	{
		public int Solve()
		{
			DateTime startTime = DateTime.Now;

			int sum = 0;
			int seed = 1000;

			for( int i = seed; --seed >= 0; )
			{
				if( ( ( seed % 3 ) == 0 ) || ( ( seed % 5 ) == 0 ) )
				{
					sum += seed;
				}
			}

			DateTime stopTime = DateTime.Now;
			Console.WriteLine( "---Solution 1 took {0} ms", ( stopTime - startTime ).Milliseconds );

			return sum;
		}
	}
}
