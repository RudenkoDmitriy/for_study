#include <iostream>
#include "stack.h"
#include <locale.h>
using namespace std;
bool sign(char ch)
{
	if ((ch == '+') || (ch == '-') || (ch == '*') || (ch == '/'))
		return true;
	return false;
}
int action(int num1, int num2, char ch)
{
	if (ch == '+')
		return num1 + num2;
	if (ch == '-')
		return num1 - num2;
	if (ch == '*')
		return num1 * num2;
	if (ch == '/')
		return num1 / num2;
	else
		return 0;
}
int charToInt(char ch)
{
	return int(ch) - 48;
}
int main()
{
	setlocale (LC_ALL, "Russian");
	char ch = ' ';
	Stack<char>* st = createStack<char>();
	cout << "¬ведите  выражение, после ввода введите '.'" << endl;
	cin >> ch;
	while(ch != '.')
	{
		if (ch != ' ')
		{
			if (!sign(ch))
				push(ch, st);
			else
			{
				int num1 =charToInt(pop(st));
				int num2 = charToInt(pop(st));
				push(char(action(num1, num2, ch) + 48), st);
			}
			
		}
		cin >> ch;
	}
	cout << charToInt(top(st));
	system("pause");
	return 0;
}