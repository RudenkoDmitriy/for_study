#include <iostream>
#include <locale.h>
#include "stack.h"

using namespace std;

bool comparison(char c1, char c2)
{
	return (((c1 == '(') && (c2 == ')')) ||
			((c1 == '[') && (c2 == ']')) ||
			((c1 == '{') && (c2 == '}')));
}

int main()
{
	Stack<char>* stack = createStack<char>();
	setlocale(LC_ALL, "Russian");
	cout << "Введите скобки, в конце ввода введите '.'" << endl;
	char c ;
	cin >> c;
	while (c != '.')
	{
		
		if (!empty(stack) && comparison(top(stack), c))
			pop<char>(stack);
		else
		{
			push<char>(c, stack);
		}
		cin >> c;
	}
	if(empty(stack))
		cout << "Верно" ;
	else
		cout << "Неверно";
	system("pause");
	return 0;
}