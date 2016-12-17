#include "stdafx.h"

#include "Problem1.h"


Problem1::Problem1(){}
//Problem1::Problem1(Problem1 b){}
//Problem1::Problem1(Problem1 &b){}
//Problem1::Problem1(char * authro, char* title){}



Problem1::~Problem1()
{
}

int Problem1::Solve()
{
	int sum = 0;
	int seed = 1000;

	for (int i = seed; --seed >= 0;)
	{
		if (((seed % 3) == 0) || ((seed % 5) == 0))
		{
			sum += seed;
		}

		bool stopHere = false;
	}

	return sum;
}
//
//template <class T>
//T Problem1::sum(const T data[], int size, T s = 0)
//{
//	for (int i = 0; i < size; ++i)
//	{
//		s += data[i];
//	}
//
//	return s;
//}
