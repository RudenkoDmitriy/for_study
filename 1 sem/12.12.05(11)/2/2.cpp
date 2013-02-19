#include<iostream>
#include<fstream>

using namespace std;

int charToInt(char c)
{
	if (c == '/')
		return 0;
	if (c == '*')
		return 1;
	else
		return 2;
}

void scan(int state[4][3], FILE* f, int st)
{
	if (feof(f))
		return;
	char c;
	fscanf(f, "%c", &c);
	if (st == 1 && state[st][charToInt(c)] == 2)
		cout << "/*";
	if (st == 2 || st == 3)
		cout << c;
	if (st == 3)
		cout << endl;
	return scan(state, f, state[st][charToInt(c)]);
}

int main()
{
	int state[4][3];
	fstream f1("example1.txt");
	for (int i = 0; i < 4; ++i)
		for (int j = 0; j < 3; ++j)
			f1 >> state[i][j];
	FILE* f2 = fopen("example2.txt", "r");
	scan(state, f2, 0);
	system("pause");
	return 0;
}