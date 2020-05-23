#include <iostream>
#include <random>
using namespace std;


void Insert(int A[5][5]) {
	for (int n = 0; n < 5; n++) {
		for (int m = 0; m < 5; m++) {
			A[n][m] = rand() % 50 + 1;
			cout << A[n][m]<<'\t';
		}
		cout << endl;
	}
}

int Sum(int A[5][5]) {
	int sum = 0;
	for (int n = 0; n < 5; n++) {
		for (int m = 0; m < 5; m++) {
			sum += A[n][m];
		}
	}
	return sum;
}

int main() {
	int A[5][5];
	Insert(A);
	int (*ptr)(int A[5][5]) = Sum;
	cout << ptr(A);
}