#include<iostream>

using namespace std;

int sum(int value)
{
	int sum = 0;
	while(value != 0)
	{
		sum = sum + (value % 10);
		value = value / 10;
	}
	return sum;
}

int main()
{
	int const num = 100;
	int arr[num];
	int res = 0;
	for (int i = 0; i < num; ++i)
		arr[i] = i;
	for (int i = 0; i < num; ++i)
	{
		int temp = sum(arr[i]);
		if (temp > res)
			res = temp;
	}
	for (int i = 0; i < num; ++i)
	{
		int temp = sum(arr[i]);
		if (temp == res)
			cout << arr[i] << endl;
	}
	system("pause");
	return 0;
}