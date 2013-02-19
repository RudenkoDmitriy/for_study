#pragma once
#include"list.h"
#include"ListOnArr.h"

//typedef ListOnArr<Tel> TempList;
//typedef int  Position;
typedef ListElement<Tel>*  Position;
typedef List<Tel> TempList;

template <class T>
void read(TempList* l, T result[100])
{
	int temp = l->lengthList();
	result[0].number = temp;
	Position pos = l->first();
	if (l->retrieve(l->first()).number != NULL)
		--pos;
	for (int j = 1; j < temp + 1; ++j)
	{
		pos = l->next(pos);
		result[j] = l->retrieve(pos);
	}
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

bool compareElem (Tel value1, Tel value2, char ch)
{
	if (ch)
		return value1.number > value2.number;
	else
	{
		return (strcmp(value1.name, value2.name) > 0);
	}
}

template <class T>
TempList* merge(TempList* l1, TempList* l2, char ch)
{
	Tel arr1[100];
	Tel arr2[100];
	read(l1, arr1);
	read(l2, arr2);
	int i = arr1[0].number; // в первом элементе каждого массива храниться его размер
	int j = arr2[0].number;
	Tel* result = new Tel[i + j + 1];
	result[0].number = i + j;
	i = 1; //счетчик для 1 массива
	j = 1;  //для 2
	int k = 1; // для результата
	while (i <= arr1[0].number || j <= arr2[0].number)
	{
		if (i <= arr1[0].number && j <= arr2[0].number)
		{
			if (compareElem(arr1[i], arr2[j], ch))
			{
				result[k] = arr2[j];
				++j;
				++k;
			}
			else
			{
				result[k] = arr1[i];
				++i;
				++k;
			}
			continue;
		}
		if (i >= arr1[0].number && j <= arr2[0].number )
		{
			while ( j <= arr2[0].number)
			{
				result[k] = arr2[j];
				++k;
				++j;
			}
		}
		if (i <= arr1[0].number && j >= arr2[0].number)
		{
			while ( i <= arr1[0].number)
			{
				result[k] = arr1[i];
				++k;
				++i;
			}
		}
	}
	TempList* l = new TempList();
	Position pos = l->first();
	for (int i = 1; i < result[0].number + 1; ++i)
	{
		l->insert(result[i], pos);
		pos = l->next(pos);
	}
	delete [] result;
	l1->removeList();
	l2->removeList();
	return l;
}

template <class T>
TempList* partition(TempList* &l)
{
	TempList* lTemp = new TempList;
	int temp2 = l->lengthList();
	int temp1 = l->lengthList() / 2;
	Position pos = l->first();
	pos = l->next(pos);
	if (l->retrieve(l->first()).number != NULL)
		--pos;
	TempList* l2 = new TempList();
	Position pos2 = l2->first();
	for (int i = 0; i < temp2 - temp1; ++i)
	{
		l2->insert(l->retrieve(pos), pos2);
		pos = l->next(pos);
		pos2 = l2->next(pos2);
	}
	pos2 = lTemp->first();
	for (int i = temp2 - temp1; i < temp2; ++i)
	{
		lTemp->insert(l->retrieve(pos), pos2);
		pos2 = lTemp->next(pos2);
		
		pos = l->next(pos);
	}
	l = l2;
	return lTemp;
}

template <class T>
TempList* mergeSort(TempList* &l, bool ch)
{	
	if (l->lengthList() > 1)
	{
		TempList* lTemp = new TempList();
		lTemp = partition<Tel>(l); 
		l = mergeSort<Tel>(l, ch);
		lTemp = mergeSort<Tel>(lTemp, ch);
		l =  merge<Tel>(l, lTemp, ch);
	}
	return l;
}
