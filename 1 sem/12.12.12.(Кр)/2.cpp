#include <iostream>

using namespace std;

int main()
{
	int const n = 10;
	int arr[n][n];
	for (int i = 0; i < n; ++i)
	{
		for (int j = 0; j < n; ++j)
		{
			arr[i][j] = i - j;
			cout << arr[i][j] << ' ';
		}
		cout << endl;
	}
	for (int i = 0; i < n; ++i)
	{
		int temp1 = arr[i][0];
		int temp2 = arr[0][i];
		int tempI = 0;
		int tempJ = 0;
		for (int j = 0; j < n; ++j)
		{
			if(temp1 > arr[i][j])
			{
				temp1 = arr[i][j];
				tempJ = j;
			}
		}
		for (int k = 0; k < n; ++k)
		{
			if(temp2 < arr[k][i])
			{
				temp2 = arr[k][i];
				tempI = k;
			}
		}
		if (temp1 == temp2)
			cout << endl << "I= " << tempI << " J= "<< tempJ << endl;
	}
	system("pause");
	return 0;
}