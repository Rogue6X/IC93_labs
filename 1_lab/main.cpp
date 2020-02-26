#include <iostream>
#include <bitset>
using namespace std;

void Incr(int i);
void Compare(int j, int k, int c);


int main() {
	int i;
	cout << "Enter first number "; cin >> i;
	int j, k, c = 0;
	cout << "Enter second num: "; cin >> j;
	cout << "Enter third num:  "; cin >> k;
	Incr(i);
	Compare(j, k, c);

}

void Incr(int i) {
	bool neg = 0;
	if (i < 0) {
		i = -i;
		neg = 1;
	}
	bitset<16> num1(i);
	cout << "Binary first num : " << num1 << endl;

	if (neg == 1) {
		for (int i = 0; i < 16; i++) {
			if (num1.test(i) == 1) {
				num1.reset(i);
				break;
			}
			else {
				num1.set(i);
			}
		}
	}
	else {
		for (int i = 0; i < 16; i++) {
			if (num1.test(i) == 0) {
				num1.set(i);
				break;
			}
			else {
				num1.reset(i);
			}
		}
	}

	int res1 = bitset<16>(num1).to_ulong();

	if (neg == 1) {
		cout << "-" << res1;
	}
	else {
		cout << res1;
	}
	cout << endl;
}


void Compare(int j, int k, int c) {
	bitset<16> num2(j); bitset<16> num3(k);
	cout << "Binary second num : " << num2 << endl;
	cout << "Binary third num  : " << num3 << endl;

	for (int i = 15; i >= 0; i--) {
		if (num3.test(i) > num2.test(i)) {
			cout << "num2 < num3";
			break;
		}
		if (num3.test(i) < num2.test(i)) {

			cout << "num2 > num3";
			break;
		}
		if (num3.test(i) == num2.test(i)) {
			c++;
		}
	}
	if (c == 16) {
		cout << "num3 = num2";
	}
}