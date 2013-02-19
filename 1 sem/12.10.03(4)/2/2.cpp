#include <iostream>
#include <sort.h>

using namespace std;

int main()
{
	FILE * f = fopen("example1.txt", "r");
	int const n = 40;
	int arr[n] = {0};
	for (int i = 0; i < n; ++i)
	{
		fscanf(f, "%d", &arr[i]);
		cout << arr[i] << ",";
	}
	fclose(f);
	cout << endl << "**********" << endl;
	Qsort(arr, 0, n - 1);
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
		