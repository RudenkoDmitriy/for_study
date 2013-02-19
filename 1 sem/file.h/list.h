#pragma once
#include<string>
template <class T> 
struct ListElement
{
	T value;
	ListElement *next;
};
bool compare(int value1, int value2)
{
	return value1 == value2;
}
bool compare(char value1[50], char value2[50])
{
	const char* temp1 = new char[50];
	temp1 = value1;
	const char* temp2 = new char[50];
	temp2 = value2;
	return (strcmp(temp1, temp2) == 0);
}
template <class T> 
class List
{
	public:
	ListElement<T>* head;

	List()
	{
		head = new ListElement<T>;
		head->value = 0;
		head->next = NULL;
	}
	void insert(T value, ListElement<T>* pos)
	{
		ListElement<T>* temp = new ListElement<T>;
		temp->value = value;
		temp->next = pos->next;
		pos->next = temp;
	}

	void remove(ListElement<T>* pos)
	{
		ListElement<T>* temp = this->head;
		if (temp->next == NULL)
			return;
		while (temp->next == NULL && temp->next != pos)
		{
			temp = temp->next;
		}

		temp->next = pos->next;
		delete pos;
	}
 
	int retrieve(ListElement<T>* pos)
	{
		return pos->value;
	}

	ListElement<T>* next(ListElement<T>* pos)
	{
		return pos->next;
	}
	
	ListElement<T>* first()
	{
		return this->head;
	}

	bool find(T value, List<T>* l)
	{
		ListElement<T>* pos = l->first();
		while(pos->next != NULL)
		{
			if (compare(pos->next->value, value))
				return true;
			pos = pos->next;
		}
		return false;
	}
	void  printList(List<T>* l)
	{
		ListElement<T>* pos = l->first();
		while (pos->next != NULL)
		{
			printf("%d",retrieve(pos->next));
			printf("%c",' ');
			pos = pos->next;
		}
	}
	int lengthList()
	{
		int result = 0;
		ListElement<T>* pos = this->first();
		while(pos != NULL)
		{
			pos = pos->next;
			++result;
		}
		return result - 1;
	}
};
