// ProjectEuler.cpp : Defines the entry point for the console application.
//
#include "stdafx.h"
#include <cstdint>
#include <iostream>
#include "ProjectEuler.h"


int _tmain(int argc, _TCHAR* argv[])
{
	// ===================================
	int zeSolutionInt = 0;
	long zeSolutionLong = 0;
	int64_t zeSolutionLong2 = 0;
	int_fast64_t zeSolutionLong3 = 0;
	// ===================================

	//int cc = argc-1;
	//while (cc >=0 )
	//{
	//	printf("arg %i - |%s|\n", cc, argv[cc]);
	//	cc--;
	//}
	bool bb = false;

	float x2;
	x2 = (float)9 / 2;
	std::cout << x2;

	//	(16 6);
	//	(false && true);
	//	bool(x) = (bool)10;
	//	float y = 12.67;


	char *ptr;
	ptr = "hello";
	std::cout << ptr;


	int a = -3, b = 2, c = 0, d;
	d = ++a && ++b || ++c;
	printf("a = %d, b = %d, c = %d, d = %d", a, b, c, d);
	printf("bla" "blo");

	

	// Automatic
	//Problem1 problem1(); // Or without parentheses if 0 params

	// Using pointers & new
	//Problem1 *problem1;			// declare pointer
	//problem1 = new Problem1();	// create class instance (object)
	//zeSolutionInt = (*problem1).Solve();

	// 1 - Multiples of 3 and 5
	Problem1 problem1;
	zeSolutionInt = problem1.Solve();
	std::cout << "Solution 1: " << zeSolutionInt << "\n";

	// 2 - Even Fibonacci numbers
	Problem2 problem2;
	zeSolutionInt = problem2.Solve();
	std::cout << "Solution 2: " << zeSolutionInt << "\n";

	// 3 - Largest prime factor
	Problem3 problem3;
	zeSolutionLong = problem3.Solve();
	std::cout << "Solution 3: " << zeSolutionLong << "\n";

	// 4 - Largest palindrome product

	// 5 - Smallest multiple

	// 6 - Sum square difference

	// 7 - 10001st prime

	// 8 - Largest product in a series

	// 9 - Special Pythagorean triplet


	return 0;
}
