#include <iostream>

using namespace std;

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
		myQsort(arr, i, last);
	}
    if (first < j)
	{
        myQsort(arr, first, j);
	}
}

void myInsert (int* arr, int n)
{
	for (int i = 1; i < n; i++) 
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

int main()
{
	int const n = 40;
	int arr[n] = {0};
	for (int i = 0; i < n; ++i)
	{
		arr[i] = rand() & 27;
		cout << arr[i] << ",";
	}
	cout << endl << "**********" << endl;
	if (n > 10)
	{
		myQsort(arr, 0, n - 1);
	}
	else
	{
		myInsert(arr, n);
	}
	for (int i = 0; i < n; ++i)
	{
		cout << arr[i] << ",";
	}
	cout << endl <<"**********" << endl;
	int check1 = 0;
	int check2 = 0;
	int number1 = arr[0];
	int number2 = -1;
	bool bool1 = true;
	bool bool2 = true;
	for (int i = 0; i < n; ++i)
	{
		if (arr[i] == number1)
		{
			check1++;
		}
		else
		{
			if (arr[i] == number2)
			{
				check2++;
			}
			else
			{
				if (check1 == 0)
				{
					bool1 = true;
				}
				else
				{
					bool1 = false;
				}
				if (check2 == 0)
				{
					bool2 = true;
				}
				else
				{
					bool2 = false;
				}
				if (bool1 || bool2 )
				{
					if (check2 == 0)
					{
						number2 = arr[i];
						check2++;
					}
					if (check1 == 0)
					{
						number1 = arr[i];
						check1++;
					}
				}
				else
				{
					if (check1 < check2)
					{
						number1 = arr[i];
						check1 = 1;
					}
					else
					{
						number2 = arr[i];
						check2 = 1;
					}
				}
			}
		}
	}
	if (check1 > check2)
	{
		cout << "this is number = " << number1;
	}
	else
	{
		cout << "this is number = " << number2;
	}
	system("pause");
	return 0;
}
		