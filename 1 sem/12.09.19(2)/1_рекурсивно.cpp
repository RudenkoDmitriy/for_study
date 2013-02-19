#include <iostream>
using namespace std;

int functionFibonacci(int n)
	{
		if(n == 0 || n == 1)
		{
			return 1;
		}
		else
		{
			return functionFibonacci(n - 2) + functionFibonacci(n - 1);
		}
	}
int main()
{	
	cout << "fibonacci number=";
	int fibonacciNumber = 0;
	cin >> fibonacciNumber;
	int answer = 0;
	answer = functionFibonacci(fibonacciNumber);
	cout << "answer" << answer;
	system("pause");
	return 0;
}







	