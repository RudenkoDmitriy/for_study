#pragma once
#include"list.h"
template <class T>
void read(List<T>* l, int result[100])
{
	int temp = l->lengthList();
	result[0] = temp;
	ListElement<T>* pos = l->first();
	for (int j = 1; j < temp + 1; ++j)
	{
		pos = pos->next;
		result[j] = pos->value;
	}
	return;
}

template <class T>
void removeList(List<T>* l)
{
	ListElement<T>* pos = l->first();
	while(pos->next != NULL)
	{
		ListElement<T>* temp = pos;
		pos = pos->next;
		delete temp;
	}
	delete pos;
	delete l;
}

template <class T>
int lengthList(List<T>* l)
{
	List<T> list;
	ListElement<T>* pos = l->first();
	int result = 0;
	while(pos->next != NULL)
	{
		++ result;
		pos = pos->next;
	}
	return result;
}

template <class T>
bool compareElem(char* value1, char* value2)
{
		int temp1 = int(value1[1]);
		int temp2 = int(value2[1]);
		return (temp1 > temp2);
}

bool compareElem (int value1, int value2)
{
		return (value1 > value2);
}

template <class T>
List<T>* merge(List<T>* l1, List<T>* l2)
{
	int arr1[100];
	int arr2[100];
	read(l1, arr1);
	read(l2, arr2);
	int i = arr1[0]; // � ������ �������� ������� ������� ��������� ��� ������
	int j = arr2[0];
	int* result = new int[i + j + 1];
	result[0] = i + j;
	i = 1; //������� ��� 1 �������
	j = 1;  //��� 2
	int k = 1; // ��� ����������
	while(i <= arr1[0] || j <= arr2[0])
	{
		if (i <= arr1[0] && j <= arr2[0])
		{
			if (compareElem(arr1[i], arr2[j]))
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
		if (i >= arr1[0] && j <= arr2[0] )
		{
			while ( j <= arr2[0])
			{
				result[k] = arr2[j];
				++k;
				++j;
			}
		}
		if (i <= arr1[0] && j >= arr2[0])
		{
			while ( i <= arr1[0])
			{
				result[k] = arr1[i];
				++k;
				++i;
			}
		}
	}
	List<T>* l = new List<T>();
	ListElement<T>* pos = l->first();
	for (int i = 1; i < result[0] + 1; ++i)
	{
		l->insert(result[i], pos);
		pos = pos->next;
	}
	delete result;
	removeList(l1);
	removeList(l2);
	return l;
}

template <class T>
List<T>* partition(List<T>* &l)
{
	int length = lengthList(l);
	length = length / 2;
	List<T>* lTemp = new List<T>();
	ListElement<T>* pos = l->first();
	for(int i = 0; i < length; ++i)
	{
		pos = pos->next;
	}
	lTemp->head->next = pos->next;
	pos->next = NULL;
	return lTemp;
}

template <class T>
List<T>* mergeSort(List<T>* &l)
{	
	if (l->lengthList() > 1)
	{
		List<T>* lTemp = new List<T>();
		lTemp = partition(l); 
		l = mergeSort(l);
		lTemp = mergeSort(lTemp);
		l =  merge(l, lTemp);
	}
	return l;
}
