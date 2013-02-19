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

void BinSearch(int * arr, int n, int number)
{
    int first = 0;
    int last = n; 
    int mid;
    while (last - first > 1) 
    {
        mid = (first + last) / 2;  
        if (number > arr[mid]) 
		{
			first = mid;
		}
        if (number < arr[mid]) 
		{
			last = mid;
		}
        if (number == arr[mid])
		{
			cout << "this number include in array = " << number << endl;
			return;
		}
    }
	cout << "this number not include in array = " << number << endl;
    return;
} 
 

int main()
{
	int const n0 = 5000;
	int const k0 = 200000;//при 300000 вылетает, сделал при 200000
	int n = 0;
	cout << " enter n = ";
	cin >> n;
	int k = 0;
	cout << "enter k = ";
	cin >> k;
	int arr1[n0] = {0};
	int arr2[k0] = {0};
	for (int i = 0; i < n ; ++i)
	{
		arr1[i] = rand() % 1000000000;
	}
	for (int i = 0; i < k ; ++i)
	{
		arr2[i] = rand() % 1000000000;
	}
	myQsort(arr1, 0, n - 1);
	myQsort(arr2, 0, k - 1);
	/*for (int i = 0; i < n ; ++i)
	{
		cout << arr1[i] << ",";
	}
	cout << endl << endl;
	for (int i = 0; i < k ; ++i)
	{
		cout << arr2[i] << ",";
	}
	cout << endl;*/ // использовал для проверки
	BinSearch(arr1, n - 1, arr2[0]);
	int temp = 1;
	while (temp < k)
	{
		if (arr2[temp] != arr2[temp - 1])//чтобы не проверять одинаковые числа
		{
			BinSearch(arr1, n - 1, arr2[temp]);
		}
		++temp;
	}
	system("pause");
	return 0;
}
