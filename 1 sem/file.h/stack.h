#pragma once

#include <iostream>

using namespace std;

template <class T> 
struct StackElement
{
	T value;
	StackElement<T> *next;
};

template <class T> 
class Stack
{
	public:
	StackElement<T>* head;
};

template <class T> 
Stack<T>* createStack()
{
	Stack<T>* l = new Stack<T>;
	l->head = NULL;
	return l;
}

// заталкивает элемент в стэк

template <class T> 
void push(T value, Stack<T>* &stack)
{
	StackElement<T>* temp = new StackElement<T>;
	temp->value = value;
	temp->next = stack->head;
	stack->head = temp;
}

template <class T> 
bool empty(Stack<T>* stack)
{
	return (stack->head == NULL);
}

template <class T> 
T top(Stack<T>* stack)
{
	if (empty(stack))
	{
		cout << "stack empty!";
		return NULL;
	}
	return stack->head->value;
}

template <class T> 
T pop(Stack<T>* &stack)
{
	if (empty(stack))
	{
		cout << "stack empty!";
		return NULL;
	}
	int temp = stack->head->value;
	StackElement<T>* pos = stack->head;
	stack->head = stack->head->next;
	delete pos;
	return temp;
}


