#include <iostream>

using namespace std;

int main()
{	
	cout<<"n=10"<<endl;
	int a[10];
	for (int i = 0; i < 10; ++i)
	{
		a[i] = rand() % 100;
		cout << a[i] << ",";
	}	
	int m;
	cout << "vvedite m" << endl;
	cin >> m;

	for (int j = 0; j < m; j++)
	{
		for (int i = 0; i < 9; i++)
		{
			int k = 0;
			k = a[i];
			a[i] = a[i + 1];
			a[i + 1] = k;
		}
	}

	for (int i = 0; i < 10; ++i)
	{
		cout << a[i] << ",";
	}
	cout << endl;
	system("PAUSE");
	return 0;
}
