#ifndef PROBLEM3_H_
#define PROBLEM3_H_

/// Largest prime factor
/// 
/// The prime factors of 13195 are 5, 7, 13 and 29.
///
///	What is the largest prime factor of the number 600851475143 ?
///
class Problem3
{
public:
	Problem3();
	~Problem3();

	const int SEQ_MAX_VALUE = 4000000;
	int Solve();
private:
	int fibo(int n);
};
#endif  // PROBLEM3_H_
