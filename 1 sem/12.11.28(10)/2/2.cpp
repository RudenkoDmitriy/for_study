#include<iostream>
#include<fstream>
#include<locale.h>

using namespace std;

int const infinity = 1000;

void print(int** arr, int n, bool** result)
{
	for (int i = 0; i < n; ++i)
	{
		for (int j = 0; j < n; ++j)
		{
			if (!result[i][j])
				cout << infinity << ' ';
			else
				cout << arr[i][j] << ' ';
		}
		cout << endl;
	}
	cout << endl;
}

void add(int** arr, bool** &result,int n, bool* &check)
{
	int length = infinity;
	int tempI = 0;
	int tempJ = 0;
	for (int i = 0; i < n; ++i)
		for (int j = 0; j < n; ++j)
		if ((arr[i][j] < length) && (check[i]) && (!check[j]))
		{
			tempI = i;
			tempJ = j;
			length = arr[tempI][tempJ];
		}
	if (length != infinity)
	{
		int tempI2 = tempI;
		result[tempJ][tempI] = true;
		result[tempI][tempJ] = true;
		check[tempJ] = true;
		return add(arr, result,n, check);
	}
}
int main()
{
	fstream f("example.txt");
	int n;
	f >> n;
	int** arr = new int*[n];
	for (int i = 0; i < n; ++i)
		arr[i] = new int[n];
	for (int i = 0; i < n; ++i)
		for (int j = 0; j < n; ++j)
			arr[i][j] = infinity;
	while (!f.eof())
	{
		int i = 0;
		int j = 0;
		int length = 0;
		f >> i;
		f >> j;
		f >> length;
		arr[i][j] = length;
		arr[j][i] = length;
	}
	bool** result = new bool*[n];
	for (int i = 0; i < n; ++i)
		result[i] = new bool[n];
	for (int i = 0; i < n; ++i)
		for (int j = 0; j < n; ++j)
			result[i][j] = true;
	cout << "Before : " << endl;
	print(arr, n, result);	
	for (int i = 0; i < n; ++i)
		for (int j = 0; j < n; ++j)
			result[i][j] = false;
	bool* check = new bool[n];
	for (int i = 0; i < n; ++i)
		check[i] = false;
	check[0] = true;
	add(arr, result, n, check);
	cout << "After : " << endl;
	print(arr, n, result);
	system("pause");
	return 0;
}