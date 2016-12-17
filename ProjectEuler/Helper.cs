using System;
using System.Collections;
using System.Collections.Generic;

namespace ProjectEuler
{
	class Helper
	{
		//#define MAX 10000

		//int i, j, sieve[MAX], primecount=0, prime[MAX];

		//for(i=0; i<MAX; i++){	sieve[i]=1;		}
		//sieve[0]=sieve[1]=0;
		//for(i=2; i<MAX; i++)
		//{
		//	while(sieve[i]==0 && i<MAX){i++;}
		//	prime[primecount]=i;

		//	for(j=i*i; j<MAX; j+=i)
		//	{
		//		sieve[j]=0;
		//	}
		//	primecount++;
		//}


		// L1_DCACHE_SIZE in kbytes (L1_DCACHE_SIZE = 32)


		/// <summary>
		/// 
		/// </summary>
		/// <param name="max"></param>
		/// <returns></returns>
		public static int[] GetPrimes( int max )
		{
			List<int> al = new List<int>();
			//int primeCount = 0;

			int sieveLen = max;
			int[] sieve = new int[ sieveLen ];

			sieve[ 0 ] = sieve[ 1 ] = 0;
			for( int i = 2; i < sieveLen; i++ )
			{
				sieve[ i ] = 1;
			}

			for( int i = 2; i < max; i++ )
			{
				while( ( i < max ) && ( sieve[ i ] == 0 ) )
				{
					i++;
				}

				al.Add( i );	// prime[ primeCount ] = i;

				for( int j = i * i; j < max; j += i )
				{
					sieve[ j ] = 0;
				}
				//primeCount++;
			}

			int[] intArray = al.ToArray();

			return intArray;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="max"></param>
		/// <returns></returns>
		public static long[] GetPrimes( long max )
		{
			List<long> al = new List<long>();
			//long primeCount = 0;

			long sieveLen = max;
			int[] sieve = new int[ sieveLen ];

			for( long i = sieveLen; --i >= 0; )
			{
				sieve[ i ] = 1;
			}

			sieve[ 0 ] = sieve[ 1 ] = 0;


			for( long i = 2; i < max; i++ )
			{
				while( ( i < max ) && ( sieve[ i ] == 0 ) )
				{
					i++;
				}

				al.Add( i );	// prime[ primeCount ] = i;

				for( long j = i * i; j < max; j += i )
				{
					sieve[ j ] = 0;
				}
				//primeCount++;
			}

			long[] longArray = al.ToArray();

			return longArray;
		}

		/// <summary>
		/// Get the pNth prime
		/// 
		/// Method: Sieve of Eratosthenes
		/// </summary>
		/// <param name="pNth"></param>
		/// <returns></returns>
		public static int GetPrime( int pNth )
		{
			int cPrime = 1;
			int primeCount = 0;
			bool primeFound = false;

			long sieveChunkLen = pNth * 2;
			long sieveLen = sieveChunkLen;
			BitArray sieve2;
			bool[] sieve;

			while( !primeFound )
			{
				sieve = new bool[ sieveLen ];
				//sieve2 = new BitArray( sieveLen, true );

				for( long i = sieveLen; --i >= 0; )
				{
					sieve[ i ] = true;
				}

				sieve[ 0 ] = sieve[ 1 ] = false;

				for( int i = 2; i < sieveLen; i++ )
				{
					while( ( i < sieveLen ) && ( !sieve[ i ] ) )
					{
						i++;
					}

					cPrime = i;	// prime[ primeCount ] = i;
					++primeCount;

					if( primeCount == pNth )
					{
						primeFound = true;
						break;
					}


					for( long j = ( (long)i * i ); j < sieveLen; j += i )
					{
						sieve[ j ] = false;
					}
				}

				//
				sieveLen += sieveChunkLen;
				primeCount = 0;
			}

			return cPrime;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns></returns>
		int[] GetPrimes( int min, int max )
		{
			List<int> al = new List<int>();
			int primecount = 0;

			if( ( ( min & 1 ) != 0 ) )
			{
				min++;
			}

			int sieveLen = max - min + 1;
			int[] sieve = new int[ sieveLen ];
			for( int i = 0; i < sieveLen; i++ )
			{
				sieve[ i ] = 1;
			}

			for( int i = min; i <= max; i += 2 )
			{
			}

			//int[] intArray;

			if( primecount > 0 )
				return null;// intArray;
			else
				return null;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="number"></param>
		/// <returns></returns>
		bool IsComposite( int number )
		{
			if( number < 4 )
			{
				return false;
			}
			else if( ( number & 1 ) == 0 )
			{
				// Is pot
				return true;
			}
			else
			{
				if( GetPrimes( number, number ).Length == 0 )
					return true;
				else
					return false;
			}
		}

		public struct SumAndList<T>
		{
			public T sum;
			public List<T> valList;
		}

		/// <summary>
		/// Enumerates the given number list of factors and returns also the sum of them
		/// </summary>
		/// <param name="number"></param>
		/// <returns></returns>
		public static SumAndList<int> GetFactors( int number)
		{
			int sum = 1;
			List<int> factorsList = new List<int>();
			factorsList.Add( 1 );
			factorsList.Add( number );

			int maxD = (int)Math.Ceiling( Math.Sqrt( number ) );

			for( int i = 2; i <= maxD; i++ )
			{
				int d = number / i;

				if( ( d * i ) == number )
				{
					sum += i;
					factorsList.Add( i );

					if( d != i )
					{
						sum += d;
						factorsList.Add( d );
					}
				}
			}

			factorsList.Sort();

			//
			SumAndList<int> ret = new SumAndList<int>();
			ret.sum = sum;
			ret.valList = factorsList;

			return ret;
		}


#region HumanFriendlyInteger

		static string[] ones = new string[] { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
		static string[] teens = new string[] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
		static string[] tens = new string[] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
		static string[] thousandsGroups = { "", " Thousand", " Million", " Billion" };

		private static string FriendlyInteger( int n, string leftDigits, int thousands )
		{
			if( n == 0 )
			{
				return leftDigits;
			}

			string friendlyInt = leftDigits;

			if( friendlyInt.Length > 0 )
			{
				friendlyInt += " ";
			}

			if( n < 10 )
			{
				friendlyInt += ones[ n ];
			}
			else if( n < 20 )
			{
				friendlyInt += teens[ n - 10 ];
			}
			else if( n < 100 )
			{
				friendlyInt += FriendlyInteger( n % 10, tens[ n / 10 - 2 ], 0 );
			}
			else if( n < 1000 )
			{
				friendlyInt += FriendlyInteger( n % 100, ( ones[ n / 100 ] + " Hundred" ), 0 );
			}
			else
			{
				friendlyInt += FriendlyInteger( n % 1000, FriendlyInteger( n / 1000, "", thousands + 1 ), 0 );
				if( n % 1000 == 0 )
				{
					return friendlyInt;
				}
			}

			return friendlyInt + thousandsGroups[ thousands ];
		}

		public static string IntegerToWritten( int n )
		{
			if( n == 0 )
			{
				return "Zero";
			}
			else if( n < 0 )
			{
				return "Negative " + IntegerToWritten( -n );
			}

			return FriendlyInteger( n, "", 0 );
		}

#endregion
	}
}
