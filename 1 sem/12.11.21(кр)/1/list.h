#pragma once
template <class T> 
struct ListElement
{
	T value;
	ListElement *next;
};
template <typename T> 
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
	template <class T> 
	void insert(T value, ListElement<T>* pos)
	{
		ListElement<T>* temp = new ListElement<T>;
		temp->value = value;
		temp->next = pos->next;
		pos->next = temp;
	}
	template <class T> 
	void remove(ListElement<T>* pos)
	{
		ListElement<T>* temp = this->head;
		if (temp->next == NULL)
			return;
		while (temp->next != pos)
		{
			temp = temp->next;
		}

		temp->next = pos->next;
		delete pos;
	}
	template <class T> 
	int retrieve(ListElement<T>* pos)
	{
		return pos->value;
	}
	template <class T> 
	ListElement<T>* next(ListElement<T>* pos)
	{
		return pos->next;
	}
	
	ListElement<T>* first()
	{
		return this->head;
	}
	template <class T> 
	bool find(T value, List<T>* l)
	{
		ListElement<T>* pos = l->first();
		while(pos != NULL)
		{
			if (pos->value == value)
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
};
