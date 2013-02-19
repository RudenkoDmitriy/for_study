
#include<fstream>
#include<iostream>

using namespace std;

int const infinity = 10000;


struct Land
{
	bool city[100];
};

bool war(bool* arr, int n)
{
	bool result = true;
	for (int i = 0; i < n; ++i)
		result = result && arr[i];
	return !result;
} 

void add(bool emptyCities[100], Land* &land, int n, int** arr, int numberOfLand)
{
	int temp = infinity;
	int tempJ = 0;
	for (int i = 0; i < n; ++i)
	{
		if (land[numberOfLand].city[i] == true)
			for (int j = 0; j < n; ++j)
				if ((emptyCities[j] == false) && arr[i][j] < temp)
				{
					temp = arr[i][j];
					tempJ = j;
				}
	}
	emptyCities[tempJ] = true;
	land[numberOfLand].city[tempJ] = true;
}

int main()
{
	fstream f("example.txt");
	int m = 0;
	int n = 0;
	f >> n;
	f >> m;
	int** arr = new int*[n];
	for (int k =0; k < n; ++k)
		arr[k] = new int[n];
	for (int k =0; k < n; ++k)
		for (int s =0; s < n; ++s)
			arr[k][s] = infinity;
	for (int k = 0; k < m; ++k)
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
	int k = 0;
	f >> k;
	Land* land;
	land = new Land[k];
	bool emptyCities[100];// = new bool[n];
	for(int i = 0; i < 100; ++i)
		emptyCities[i] = false;
	for(int i = 0; i < k; ++i)
	{
		//land[i].city = new bool[n];
		for(int j = 0; j < 100; ++j)
			land[i].city[j] = false;
		int temp = 0;
		f >> temp;
		land[i].city[temp] = true;
		emptyCities[temp] = true;
	}
	while (war(emptyCities, n))
	{	
		for (int i = 0; i < k; ++i)
		{
			if (!war(emptyCities, n))
				break;
			add(emptyCities, land, n, arr, i);
		}
	}
	for (int i = 0; i < k; ++i)
	{
		for (int j = 0; j < n; ++j)
			if (land[i].city[j] == true)
				cout << j << ' ';
		cout << endl;
	}
	f.close();
	system("pause");
	return 0;
}