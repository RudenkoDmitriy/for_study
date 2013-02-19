#include <iostream>
#include <locale.h>

using namespace std;

struct ListElement
{
	int value;
	ListElement *next;
};

typedef ListElement* position;

struct List
{
	ListElement* head;
};

List* createList()
{
	List* l = new List;
	l->head = new ListElement;
	l->head->value = 0;
	l->head->next = NULL;
	return l;
}

void insert(int number, position pos, List l)
{
	ListElement* temp = new ListElement();
	temp->value = number;
	temp->next = pos->next;
	pos->next = temp;
}

void remove(position pos, List l)
{
	position temp = l.head;
	while (temp->next != pos)
	{
		temp = temp->next;
	}

	temp->next = pos->next;
	delete pos;
}

int retrieve(position pos, List l)
{
	return pos->value;
}

position next(position pos, List l)
{
	return pos->next;
}

position first(List l)
{
	return l.head;
}

void printList(List l)
{
	cout << endl;
	position p = first(l)->next;
	while (p != NULL)
	{
		cout << retrieve(p, l) << ",";
		p = next(p, l);
	}
}

void one(List l, int &counter)
{
	int number = 0;
	cout << "¬ведите значение" << endl;
	cin >> number;
	cout << endl;
	position p = first(l);
	if (p != NULL)
	{
		while (p->next != NULL)
		{
			if (retrieve(p->next, l) > number) 
				p = next(p, l);
			else
				break;
		}
	}
		insert(number, p, l);
		++counter;
}

void two(List l, int &counter)
{
	if (counter == 0)
	{
		cout << "≈ще не одно число не введено!" << endl;
		return;
	}
	int number = 0;
	cout << "¬ведите номер элемента, который надо удалить" << endl;
	cin >> number;
	cout << endl;
	number = counter - number + 1;
	position p = first(l);
	for (int i = 0; i < number; ++i)
	{
		p = next(p, l);
	}
	remove(p, l);
	--counter;
}

void three(List l, int &counter)
{
	if (counter == 0)
	{
		cout << "≈ще не одно число не введено!" << endl;
		return;
	}
	printList(l);
}

void choice(List l, int command, int &counter)
{
	if (command == 1)
		one(l, counter);
	if (command == 2)
		two(l, counter);
	if (command == 3)
		three(l, counter);
}

int main()
{
	setlocale (LC_ALL,"Russian");
	List* l = createList();
	int command = 100;
	cout << "¬ведите команду" << endl;
	cin >> command;
	cout << endl;
	int counter = 0;
	while (command != 0)
	{		
		choice(*l, command, counter);
		cout << "¬ведите команду" << endl;
		cin >> command;
		cout << endl;
	}
	return 0;	
}
	








	