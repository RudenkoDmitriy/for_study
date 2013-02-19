#include <iostream>
#include <stdlib.h>
#include <time.h>

using namespace std;

int main()
{
	srand(time(0));
	int const n = 10;
	int arr[n] = {0};
	for (int i = 0; i < n; i++)
	{
		arr[i] = rand() % 15;
		cout << arr[i] << ",";
	}
	int nCheck = arr[0];
	int j = n - 1;
	int i = 0;
	do
	{
		if (arr[i] >= nCheck) 
		{
			if (arr[j] <= nCheck)
			{
				int temp = 0;
				temp = arr[i];
				arr[i] = arr[j];
				arr[j] = temp;
				++i;
				--j;
			}
			else
			{
				--j;
				continue;
			}
		}
		else
		{
			++i;
		}
	}
	while (i < j);
	cout << endl;
	for (int i = 0; i < n; ++i)
	{
		cout << arr[i] << ",";
	}
	system("pause");
	return 0;
}
		