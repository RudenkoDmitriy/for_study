#include<iostream>
#include<fstream>
#include<locale.h>

using namespace std;

void scan(int** state, int st, int n, int k)
{
	int c = 0;
	cin >> c;
	cout << endl;
	if ( c == -5)
	{
		return;
	}
	if ((st > n - 1) || (st < 0) || (c < 0) || (c > k - 1))
	{
		cout << "Fail";
		return;
	}	
	else
		cout <<"State = " << state[c][st] << ' ' << endl;
	return scan(state, state[c][st], n, k);
}

int main()
{
	setlocale(LC_ALL,"Russian");
	int** state;
	fstream f1("example1.txt");
	int n = 0;
	int k = 0;
	f1 >> n;
	f1 >> k;
	state = new int*[n];
	for (int j = 0; j < n; ++j)
		state[j] = new int[k];
	for (int i = 0; i < n; ++i)
		for (int j = 0; j < k; ++j)
			f1 >> state[j][i];
	f1.close(); 
	cout << "¬ведите состо€ни€ через пробел, в конце введите '-5'" << endl;
	scan(state, 0, n, k);
	/*for (int i = 0; i < n; ++i)  // не понимаю, почему вылетает
		delete [] state[i];*/
	//delete [] state;
	system("pause");
	return 0;
}