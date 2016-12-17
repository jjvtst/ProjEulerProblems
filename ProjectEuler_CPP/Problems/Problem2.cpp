#include "stdafx.h"
#include "Problem2.h"

Problem2::Problem2(){}
Problem2::~Problem2(){}

int Problem2::Solve()
{
	int bla = Problem2::SEQ_MAX_VALUE;
	int bla2 = SEQ_MAX_VALUE;

	// ===============================	Simple way
	int sum = 0,
		prevA = 0,
		prevB = 1,
		fibVal = 0;

	while (fibVal < SEQ_MAX_VALUE)
	{
		// add the previous values
		fibVal = prevA + prevB;

		// Check if it's even...
		if ((fibVal & 1) == 0)
		{
			sum += fibVal;
		}

		prevA = prevB;
		prevB = fibVal;
	}

	// ===============================	Using recursive fn
	int fibVal2 = 0,
		fibValIndx = 0,
		sum2 = 0;

	while (fibVal2 < SEQ_MAX_VALUE)
	{
		fibVal2 = fibo(fibValIndx++);
		if ((fibVal2 & 1) == 0)
		{
			sum2 += fibVal2;
		}
	}

	return sum;
}

int Problem2::fibo(int n)
{
	if (n < 2)
		return 1;
	else
		return fibo(n - 2) + fibo(n - 1);
}
