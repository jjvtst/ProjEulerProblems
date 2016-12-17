
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProjectEuler
{
	/// <summary>
	/// 
	/// https://projecteuler.net/archives
	/// 
	/// </summary>
	class Program
	{
		static int Main( string[] args )
		{
			// ===================================
			int zeSolutionInt;
			long zeSolutionLong;
			// ===================================

			/********************************************************************
			
			// NEW C# 6 FEATURES (nameof, property default value, etc.)

			// Check http://developer.telerik.com/featured/essential-c-6-features-you-need-to-know/ for a good list w/examples

			// property initializer inlined
			public int X { get; } = 5;
			public int Y { get; }

			// nameof()
			Console.WriteLine( "Using nameof variable int x: {0}", nameof( x ) );
			Console.WriteLine( "Using nameof property X:     {0}", nameof( X ) );
			Console.WriteLine( "Using nameof method Solve(): {0}", nameof( Solve ) );

			// String interpolation
			string firstName = "Michael";
			string lastName = "Crump";
			WriteLine( $"{firstName} {lastName} is my name!" );

			// null dot operator
			json?["x"]?.Type == JTokenType.Integer

			*********************************************************************/
			#region PAST PROBLEMS

			// 1 - Multiples of 3 and 5
			//zeSolutionInt = ( new Problem1() ).Solve();
			//Console.WriteLine( "Solution 1: " + zeSolutionInt );

			//// 2 - Even Fibonacci numbers
			//zeSolutionInt = ( new Problem2() ).Solve();
			//Console.WriteLine( "Solution 2: " + zeSolutionInt );

			//// 3 - Largest prime factor
			//zeSolutionLong = ( new Problem3() ).Solve();
			//Console.WriteLine( "Solution 3: " + zeSolutionLong );

			//// 4 - Largest palindrome product
			//zeSolutionInt = ( new Problem4() ).Solve();
			//Console.WriteLine( "Solution 4: " + zeSolutionInt );

			//// 5 - Smallest multiple
			//zeSolutionInt = ( new Problem5() ).Solve();
			//Console.WriteLine( "Solution 5: " + zeSolutionInt );

			//// 6 - Sum square difference
			//zeSolutionInt = ( new Problem6() ).Solve();
			//Console.WriteLine( "Solution 6: " + zeSolutionInt );

			//// 7 - 10001st prime
			//zeSolutionLong = ( new Problem7() ).Solve();
			//Console.WriteLine( "Solution 7: " + zeSolutionLong );

			//// 8 - Largest product in a series
			//zeSolutionLong = ( new Problem8() ).Solve();
			//Console.WriteLine( "Solution 8: " + zeSolutionLong );

			// 9 - Special Pythagorean triplet
			//zeSolutionLong = ( new Problem9() ).Solve();
			//Console.WriteLine( "Solution 9: " + zeSolutionLong );

			// 10 - Summation of primes	
			//zeSolutionLong = ( new Problem10() ).Solve();
			//Console.WriteLine( "Solution 10: " + zeSolutionLong );

			// 11 - Largest product in a grid	
			//zeSolutionLong = ( new Problem11() ).Solve();
			//Console.WriteLine( "Solution 11: " + zeSolutionLong );

			// 12 - Highly divisible triangular number	
			//zeSolutionLong = ( new Problem12() ).Solve();
			//Console.WriteLine( "Solution 12: " + zeSolutionLong );

			// 13 - Large sum
			//char[] asCharArray = ( new Problem13() ).Solve();
			//string sol13 = asCharArray[ 0 ] + "";
			//for( int i = 1, aLen = asCharArray.Length; i < aLen; i++ )
			//	sol13 += "," + asCharArray[ i ];
			//Console.WriteLine( "Solution 13: " + sol13 );

			// 14 - Longest Collatz sequence
			//zeSolutionLong = ( new Problem14() ).Solve();
			//Console.WriteLine( "Solution 14: " + zeSolutionLong );

			// 15 - Lattice paths	
			//zeSolutionLong = ( new Problem15() ).Solve();
			//Console.WriteLine( "Solution 15: " + zeSolutionLong );

			// 16 - Power digit sum	
			//zeSolutionLong = ( new Problem016() ).Solve();
			//Console.WriteLine( "Solution 16: " + zeSolutionLong );

			// 17 - Number letter counts	
			//zeSolutionLong = ( new Problem017() ).Solve();
			//Console.WriteLine( "Solution 17: " + zeSolutionLong );

			#endregion

			// 18 - Maximum path sum I	
						zeSolutionLong = ( new Problem018() ).Solve();
						Console.WriteLine( "Solution 18: " + zeSolutionLong );

			// 19 - Counting Sundays	
			//			zeSolutionLong = ( new Problem019() ).Solve();
			//			Console.WriteLine( "Solution 19: " + zeSolutionLong );

			// 20 - Factorial digit sum	
			//			zeSolutionLong = ( new Problem020() ).Solve();
			//			Console.WriteLine( "Solution 20: " + zeSolutionLong );

			// 21 - Amicable numbers	

			// 22 - Names scores	

			// 23 - Non-abundant sums	

			// 24 - Lexicographic permutations	

			// 25 - 1000-digit Fibonacci number	

			// 26 - Reciprocal cycles	

			// 27 - Quadratic primes	

			// 28 - Number spiral diagonals	

			// 29 - Distinct powers	

			// 30 - Digit fifth powers	

			// 31 - Coin sums	

			// 32 - Pandigital products	

			// 33 - Digit cancelling fractions	

			// 34 - Digit factorials	

			// 35 - Circular primes	

			// 36 - Double-base palindromes	

			// 37 - Truncatable primes	

			// 38 - Pandigital multiples	

			// 39 - Integer right triangles	

			// 40 - Champernowne's constant	

			// 41 - Pandigital prime	

			// 42 - Coded triangle numbers	

			// 43 - Sub-string divisibility	

			// 44 - Pentagon numbers	

			// 45 - Triangular, pentagonal, and hexagonal	

			// 46 - Goldbach's other conjecture	

			// 47 - Distinct primes factors	

			// 48 - Self powers	

			// 49 - Prime permutations	

			// 50 - Consecutive prime sum	



			return 0;
		}
	}
}

// ===================================
// Division, playing with
// ===================================
//float
//	dividend = 20,
//	divisor = 3,
//	quotient = 0,
//	remainder = 0,
//	qInc = 1f;

//int decimalPrecission = 2;

//do
//{
//	dividend -= divisor;
//	quotient += qInc;

//	if( dividend < divisor )
//	{
//		qInc /= 10f;
//		dividend *= 10f;
//		--decimalPrecission;

//		if( decimalPrecission < 0 )
//			break;
//	}
//	else if( dividend == 0 )
//	{
//		break;
//	}

//} while( dividend > 0 );

// Square root
//float zeNumber = 16;
