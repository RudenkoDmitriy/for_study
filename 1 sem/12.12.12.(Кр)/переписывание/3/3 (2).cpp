#include<iostream>
#include<string.h>

using namespace std;

int charToInt(char c)
{
	return int(c) - '0';
}

int binToDec(string s)
{
	int result = 0;
	bool check = false;
	int k = 0;
	if (s[s.length() - 1] == '0')
	{
		k = 1;
		result = 1;
		check = true;
	}
	for (int i = s.length() - 1 - k; i > -1; --i)
	{
		int temp = charToInt(s[i]);
		result = result * 2 + charToInt(s[i]);
	}
	if (check)
	{
		result = result--;
	}
	return result;
}

int main()
{
	string s;
	char* temp = new char[100];
	cin >> temp;
	s = temp;
	int res = binToDec(s);
	cout << endl << res;
	delete[] temp;
	system("pause");
	return 0;
}