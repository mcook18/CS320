#include <iostream>
using namespace std;

int main() {
	int A, B, C;
	bool c1, c2, c3, IsTri;
	do {
		cout << "Please give me three positive numbers for the sides of a triangle: " << endl;
		cin >> A >> B >> C;
		c1 = (1 <= A) && (A <= 300);
		c2 = (1 <= B) && (B <= 300);
		c3 = (1 <= C) && (C <= 300);
		if (!c1)
		{
			cout << "Value of A is not in the range of permitted values" << endl;
		}
		else if (!c2) {
			cout << "Value if B is not in the range of permitted values" << endl;
		}
		else if (!c3) {
			cout << "value of C is not in the range of permited values" << endl;
		}
	} while (!(c1 && c2 && c3));

	cout << "Side A is " << A << endl;
	cout << "Side B is " << B << endl;
	cout << "Side C is " << C << endl;
	if ((A < B + C) && (B < A + C) && (C < A + B))
		IsTri = true;
	else
		IsTri = false;
	if (IsTri)
	{
		if (A == B && B == C) {
			cout << "It's an equilateral!" << endl;
		}
		else if (A != B && A != C && B != C)
			cout << "It's scalene!" << endl;
		else
			cout << "It's Isosceles!" << endl;
		if ((A ^ 2) == ((B ^ 2) + (C ^ 2)))
			cout << "It's a right triangle!" << endl;
		else if ((B ^ 2) == ((A ^ 2) + (C ^ 2)))
			cout << "It's a right triangle!" << endl;
		else if ((C ^ 2) == ((A ^ 2) + (B ^ 2)))
			cout << "It's a right triangle!" << endl;
		else
			cout << "It's not a right triangle." << endl;
	}
	if (IsTri == false)
		cout << "It's not a Triangle." << endl;
}