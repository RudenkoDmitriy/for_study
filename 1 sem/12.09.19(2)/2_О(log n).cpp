#include <iostream>
using namespace std;
int functionDegree(int a, int n)
{
	if (n == 0)
	{
		return 1;
	}
	if (n % 2 == 0)
	{
		int temp = functionDegree(a, n/2);
		return temp * temp;
	}
	else
	{
		int temp = functionDegree(a, n-1);
		return a * temp;
	}
}
int main()
{
	cout << "inter number" << endl;
	int number = 0;
	cin >> number;
	cout << "inter degree" << endl;
	int degree = 0;
	cin >> degree;
	int answer = 0;
	answer = functionDegree(number, degree);
	cout << "answer=" << answer;
	system("pause");
	return 0;
}






