#include <iostream>
#include "stack.h"
#include <locale.h>

using namespace std;

bool sign(char ch)
{
	return (ch == '+') || (ch == '-') || (ch == '*') || (ch == '/') || (ch == '(') || (ch == ')');
}

int priority(char c)
{
	if(c == '*' || c == '/')
		return 3;
	if(c == '+' || c == '-')
		return 2;
	if(c == '(' || c == ')')
		return 1;
	return 0;
}

int main()
{
	setlocale (LC_ALL, "Russian");
	char c = ' ';
	Stack<char>* stack = createStack<char>();
	int check = -1;
	cout << "¬ведите пример, после записи введите '.'" << endl;
	cin >> c;
	while (c != '.')
	{
		if (!(sign(c)))
		{
			cout << c << ' ';
		}
		if (sign(c))
		{
			if ((empty(stack) || (priority(top(stack)) < priority(c))) && (priority(c) != 1))
				push(c, stack);
			else
				if (c == '(')
				{
						push(c, stack);
				}
				else
				{
					cout <<' ' << pop(stack);
					if(c != ')')
						push(c, stack);
				}
				if (c == ')')
				{
					while (top(stack) != '(')
							cout << pop(stack);
					pop(stack);
				}
		}
		cin >> c;
	}
	while (!empty(stack))
		cout << pop(stack);
	system("pause");
	return 0;
}