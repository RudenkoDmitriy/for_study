#pragma once
#include<string>
#include<iostream>
struct Tel
{
	int number;
	char* name;
};
template <class T> 
struct ListElement
{
	T value;
	ListElement *next;
};
template <class T> 
class List
{
	public:
	ListElement<T>* head;

	List()
	{
		head = new ListElement<T>;
		this->head->value.name = NULL;
		this->head->value.number = NULL;
		head->next = NULL;
	}
	void insert(T value, ListElement<T>* pos)
	{
		ListElement<T>* temp = new ListElement<T>;
		temp->value = value;
		temp->next = pos->next;
		pos->next = temp;
	}


	ListElement<T>* remove(ListElement<T>* pos)
	{
		ListElement<T>* temp = this->head;
		if (temp->next == NULL)
			return pos;
		while (temp->next == NULL && temp->next != pos)
		{
			temp = temp->next;
		}

		temp->next = pos->next;
		ListElement<T>* result = pos->next;
		delete pos;
		return temp->next;
	}
	template <class T>
	int lengthList(List<T>* l)
	{
	List<T> list;
	ListElement<T>* pos = l->first();
	int result = 0;
	while (pos->next != NULL)
	{
		++ result;
		pos = pos->next;
	}
	return result;
	}
	T retrieve(ListElement<T>* pos)
	{
		return pos->value;
	}

	ListElement<Tel>* next(ListElement<Tel>* pos)
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
			cout << retrieve(pos->next);
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
	void removeList()
	{
		ListElement<Tel>* pos = this->first();
		while (pos->next != NULL)
		{
			ListElement<Tel>* temp = pos;
			pos = pos->next;
			delete temp;
		}
		delete pos;
		delete this;
	}
};
