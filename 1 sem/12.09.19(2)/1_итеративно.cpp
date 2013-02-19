#include <iostream>
using namespace std;
int main()
{
	cout << "inter fibonacci number=";
	int fibNumber = 0;
	cin >> fibNumber;
	cout << "1,2";
	int number1 = 1;
	int number2 = 2;
	for (int i = 0; i < fibNumber - 2; i++)
	{
		int temp = 0;
		temp = number2;
		number2 = number1 + number2;
		number1 = temp;
		cout << "," << number2;
	}
	system("pause");
	return 0;
}


