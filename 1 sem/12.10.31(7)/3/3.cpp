#include <iostream>
#include "binTree.h"

using namespace std;

Node<char>* write(Node<char>* &pos, char c)
{
	pos->value = c;
	pos->left = new Node<char>;
	pos->right = new Node<char>;
	pos->left->parent = pos;
	pos->left->value = NULL;
	pos->right->value = NULL;
	pos->right->parent = pos;
	return pos;
}

bool sign(char c)
{
	return (c == '+' || c == '*' || c == '/' || c == '-');
}

void add(FILE* f,Node<char>* &pos)
{
	Node<char>* temp = pos;
	char c = ' ';
	while (!feof(f))
	{
		fscanf(f, "%c", &c);
		while ((c == ' ' || c == '(' || c == ')') && !feof(f))
		{
			fscanf(f, "%c", &c);	
		}
		if (c == ' ' || c == '(' || c == ')')
			return;
		if (sign(c))
		{
			pos = write(pos, c);
			add(f, pos->left);
			add(f, pos->right);
			return;
		}
		else
		{
			pos = write(pos, c);
			return;
		}
	}
	return;
}

void traverse(Node<char>* pos)
	{
		if (pos->value == NULL)
			return;
		if (sign(pos->value))
		{
			cout << '(';
			cout << pos->value << ' ';
			traverse(pos->left);
			cout << ' ';
			traverse(pos->right);
			cout << ')';
			return;
		}
		else
		{
			cout << pos->value;
			return;
		}
	}

int operation(int value1, int value2, char sign)
{
	if (sign == '+')
		return value1 + value2;
	if (sign == '-')
		return value1 - value2;

	if (sign == '*')
		return value1 * value2;

	if (sign == '/')
		return value1 / value2;
	return 0;
}

void action(Node<char>* pos)
{
	if (pos->left == NULL && pos->right == NULL && !sign(pos->value))
		return;
	if (sign(pos->left->value))
	{
		action(pos->left);
	}
	if (sign(pos->right->value))
	{
		action(pos->right);
	}
	pos->value = (char)(operation(pos->left->value - 48, pos->right->value - 48, pos->value) + 48);
	pos->right = NULL;
	pos->left = NULL;
}

int main()
{
	FILE* f = fopen("example.txt", "r");
	BinTree<char> tree = BinTree<char>();
	Node<char>* pos = tree.Root;
	char c = ' ';
	pos = new Node<char>;
	pos->parent = tree.Root;
	add(f, pos);
	tree.Root = pos;
	pos = tree.Root;
	traverse(tree.Root);
	action(tree.Root);
	cout << endl << "answer = " << tree.Root->value;
	fclose(f);
	system("pause");
	return 0;
}