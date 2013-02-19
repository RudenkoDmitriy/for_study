#include <iostream>
#include <locale.h>

using namespace std;

struct ListElement
{
	int value;
	ListElement *next;
};

typedef ListElement* Position;

struct List
{
	ListElement* head;
};

List* createList()
{
	List* l = new List;
	l->head = new ListElement;
	l->head->value = 0;
	l->head->next = l->head;
	return l;
}

void insert(int number, Position pos, List* l)
{
	ListElement* temp = new ListElement();
	temp->value = number;
	temp->next = l->head;
	pos->next = temp;
}

Position remove(Position pos, List* l)
{
	if (pos == l->head)
		pos = l->head->next;
	Position temp = l->head;
	while (temp->next != pos)
	{
		temp = temp->next;
	}
	Position newpos = pos->next;
	temp->next = pos->next;
	delete pos;
	return newpos;
}

int retrieve(Position pos, List l)
{
	return pos->value;
}

Position next(Position pos, List* l)
{
	return pos->next;
}

Position first(List l)
{
	return l.head;
}

void printList(List* l, int counter)
{
	cout << endl;
	Position p = first(*l)->next;
	for ( int i = 0; i < counter; ++i)
	{
		cout << retrieve(p, *l) << ",";
		p = next(p, l);
	}
	cout << endl;
}

int main()
{
	setlocale (LC_ALL,"Russian");
	List* l = createList();
	cout << "¬ведите n" << endl;
	int n = 0;
	cin >> n;
	cout << endl << "¬ведите m" << endl;
	int m = 0;
	cin >> m;
	int counter = 0;
	Position p = first(*l);
	for (int i = 1; i < n + 1; ++i)
	{
		insert(i, p, l);
		p = next(p, l);
		counter++;
	}
	printList(l, counter);
	int temp = 0;
	p = first(*l);
	while(counter > 1)
	{
		for (int i = 1; i < counter +1; ++i)
		{
			if (retrieve(p, *l) == 0)
				p = p->next;
			++temp;
			if (temp % m == 0)
			{
				temp = 0;
				p = remove(p, l);
				counter--;
				printList(l, counter);
			}
			else
				p = next(p, l);
		}
	}
	printList(l, counter);
	system("pause");
	return 0;	
}
	








	