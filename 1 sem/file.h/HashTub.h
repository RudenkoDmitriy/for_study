#pragma once
#include "list.h"
#include<string.h>

int const n = 100;
template<class T>
class HashTub
{
	List<T> list;
	public:
	List<T>* l[n];
	int hash(char* value)
	{
		int length = strlen(value);
		int c = 5;
		int key = 0;
		while((c > 0) && (length > 0))
		{
			key =key +  (int)value[length];
			length --;
			c--;
		}
		key = key % n;
		return key;
	}
	int hash(int value)
	{
		return value % 100;
	}
	bool find(T value)
	{
		int h = hash(value);
		List<char*>* list = l[h];
		if (l[h]->lengthList() == 0)
			return false;
		return list->find(value, l[h]);
	}
	void remove(T value)
	{
		int h = hash(value);
		ListElement<char*>* pos = l[h]->first();
		while((pos->next != NULL) && (pos->value != value))
		{
			pos = pos->next;
		}
		if ( pos->value == value)
			l[h]->remove(pos); 
	}
	void add (T value)
	{
		if (!find(value))
		{
			int h = hash(value);
			ListElement<T>* pos = l[h]->first();
			list.insert(value, pos);
		}
	}
	void filling()
	{
		for(int i = 0; i < n; ++i)
		l[i] = new List<T>();
	}

};