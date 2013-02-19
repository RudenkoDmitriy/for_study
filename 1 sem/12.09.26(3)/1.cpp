#include <iostream>

using namespace std;

void myInsert (int* arr, int first, int last)
{
	for (int i = first; i < last + 1; i++) 
	{
        int temp = arr[i];
        for (int j = i - 1; j >= 0; j--)
		{
                if (arr[j] < temp)
				{
                        break;
                }
                arr[j + 1] = arr[j];
                arr[j]= temp;
        }
	}
 
}

void myQsort ( int* arr, int first, int last)
{
	int i = first;
	int j = last;
	int nCheck = arr[(i + j) / 2];
	do
	{
		while (arr[i]  < nCheck)
		{
			i++;
		}
		while (arr[j] > nCheck)
		{
			j--;
		}
		if (i <= j)
		{
			if (i < j)
			{
				int temp = arr[i];
				arr[i] = arr[j];
				arr[j] = temp;
			}
			++i;
			--j;
		}
	}
	while (i <=j);
	if (i < last)
	{
		if (last - i > 10)
		{
			myQsort(arr, i, last);
		}
		else
		{
			myInsert(arr, i, last);
		}
	}
    if (first < j)
	{
		if (j - first > 10)
		{
			myQsort(arr, first, j);
		}
		else
		{
			myInsert(arr, first, j);
		}
	}
}



int main()
{
	int n = 0;
	cout << "Enter the number of array elements (1-100)" << endl;
	cin >> n;
	int arr[100] = {0};
	for (int i = 0; i < n; ++i)
	{
		arr[i] = rand() & 20;
		cout << arr[i] << ",";
	}
	cout << endl << "*********" << endl;
	myQsort(arr, 0, n - 1);
	for (int i = 0; i < n; ++i)
	{
		cout << arr[i] << ",";
	}
	system("pause");
	return 0;
}
		