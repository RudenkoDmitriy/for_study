
#include <iostream>
#include <locale.h>
#include "list.h"
#include "stack.h"
using namespace std;


int main()
{
	FILE* f = fopen("example.txt", "r");
	setlocale(LC_ALL, "Russian");
	List<int>* l1 = new List<int>();
	ListElement<int>* pos = l1->first();
	while (!feof(f))
	{
		int temp = 0;
		fscanf(f, "%d", &temp) ;
		cout << temp << ' ';
		l1->insert(temp, pos);
		pos = pos->next;
	}
	Stack<int>* st = new Stack<int>();
	pos = l1->first();
	cout <<  endl;
	for (int i = 0; i < l1->lengthList(); ++i)
	{
		pos = pos->next;
		push(pos->value, st);
	}
	pos = l1->first()->next;
	bool check = true;
	for (int i = 0; i < l1->lengthList(); ++i)
	{
		if (pos->value != top(st))
		{
			check = false;
			break;
		}
		else
		{
			pop(st);
			pos = pos->next;
		}
	}
	if (check)
		cout << "Right";
	else
		cout << "False";
	fclose(f);
	system("pause");
	return 0;
}