#include <iostream>

using namespace std;

int summ(int n)
{
	int temp = n;
	int sum = 0;
	while (temp > 0)
	{
		sum = sum + temp % 10;
		temp = temp / 10;
	}
	return sum;
}

int main()
{
	int const n = 40;
	int arr[n] = {0};
	for (int i = 0; i < n; ++i)
	{
		arr[i] = rand() % 100;
	}
	int sum = 0;
	for (int i = 0; i < n; ++i)
	{
		int temp = summ (arr[i]);
		if (temp > sum)
		{
			sum = temp;
		}
	}
	for (int i = 0; i < n; ++i)
	{
		if (sum == summ(arr[i]))
		{
			cout << arr[i] << ",";
		}
	}
	system("pause");
	return 0;
}

		