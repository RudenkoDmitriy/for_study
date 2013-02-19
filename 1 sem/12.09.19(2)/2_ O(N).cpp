#include <iostream>
using namespace std;
int main()
{
	cout << "inter number" << endl;
	int number = 0;
	cin >> number;
	cout << "inter degree" << endl;
	int degree = 0;
	cin >> degree;
	int answer=1;
	for (int i = 1; i < degree +1; ++i)
	{
		answer = number * answer;
	}
	cout << "answer=" << answer;
	system("pause");
	return 0;
}
