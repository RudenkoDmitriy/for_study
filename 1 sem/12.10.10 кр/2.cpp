#include <iostream>

using namespace std;
void optionSort(int * arr, int n)
{
	for (int i = 0; i < n - 1; ++i)
	{
		int temp = i;
		for (int j = i + 1; j < n; ++j)
		{
			if (arr[temp] > arr[j])
				temp = j;
		}
		if (arr[i] > arr[temp])
		{
			int x = arr[i];
			arr[i] = arr[temp];
			arr[temp] = x;
		}
	}
}

int main()
{
	int const n = 10;
	int arr[n] = {0};
	for (int i = 0; i < n; ++i)
	{
		cout << "Enter " << i + 1 << " number = ";
		cin >> arr[i];
		cout << endl;
	}
	optionSort(arr, n);
	for (int i = 0; i < n; ++i)
	{
		cout << i + 1 << " number = " << arr[i] << endl;
	}
	system("pause");
	return 0;
}

		