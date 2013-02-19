#include <iostream>
#include <stdlib.h>
using namespace std;
int main()
{
	int arr[10] ={ 0};
	for (int i = 0; i < 10; i++)
	{
		arr[i] = rand() % 10;
		cout << arr[i] <<",";
	}
	for (int i = 0; i < 9; ++i)
	{
		for (int j = i + 1; j < 10; ++j)
		{
			if (arr[i] > arr[j])
			{
				arr[i] = arr[i] + arr[j];
				arr[j] = arr[i] - arr[j];
				arr[i] = arr[i] - arr[j];
			}
		}
	}
	for (int i = 0; i < 10; ++i)
	{
		cout << arr[i] << ",";
	}
	system("pause");
	return 0;
}
