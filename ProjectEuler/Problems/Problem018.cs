using System;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Math;

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
	class Problem018
	{
		//char[] BIG_1000_DIGIT_NUMBER = "50".ToCharArray();
		//const int ADJ_DIGIT_COUNT = 13;

		//	75
		//	95 64
		//	17 47 82
		//	18 35 87 10
		//	20 04 82 47 65
		//	19 01 23 75 03 34
		//	88 02 77 73 07 63 67
		//	99 65 04 28 06 16 70 92
		//	41 41 26 56 83 40 80 70 33
		//	41 48 72 33 47 32 37 16 94 29
		//	53 71 44 65 25 43 91 52 97 51 14
		//	70 11 33 28 77 73 17 78 39 68 17 57
		//	91 71 52 38 17 14 91 43 58 50 27 29 48
		//	63 66 04 68 89 53 67 30 73 16 69 87 40 31
		//	04 62 98 27 23 09 70 98 73 93 38 53 60 04 23


		public long Solve()
		{
			GC.Collect();
			System.Threading.Thread.Sleep( 10 );
			var t0 = Stopwatch.StartNew();
			// ===============================

			var retVal = 0;


			//// Unsorted array of positive ints
			//int[] nums = new int[] { 1, 2, 3, 12, 4, 7, 10, 8, 23, 5 };

			//// Sum of two numbers in the above array, in this case, of the last two
			//const int TNUM = 28;

			//bool found = false;
			//int loopCount = 0;      // Worst case: (n^2 - n) / 2
			//int i=0, j=0;

			//for(int alen = nums.Length; (i < alen) && !found; i++)
			//{
			//	int targetNum = TNUM - nums[i];

			//	for(j = i + 1; j < alen; j++)
			//	{
			//		loopCount++;

			//		if(nums[ j ] == targetNum)
			//		{
			//			found = true;
			//			break;
			//		}
			//	}
			//}

			//int r1 = nums[i-1];
			//int r2 = nums[j];


			// ===============================
			t0.Stop();
			Console.WriteLine( "---Solution NN took {0} ms", t0.Elapsed.TotalMilliseconds );
			// ===============================

			return retVal;
		}
	}
}
