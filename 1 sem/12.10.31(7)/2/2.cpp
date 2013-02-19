#include <iostream>
#include "binTree.h"

using namespace std;

void add (FILE* f, Node<char>* pos, bool check)
{
	char c = 'a';
	while (c != 'e')
	{
		//fprintf(f, "%c", &c);
		cin >>c;
		cout << "ololo";
		if (c != '(' && c != ')' && c != ' ')
		{
			Node<char>* temp  = new Node<char>;
			temp->value = c;
			temp->parent = pos;
			temp->left = NULL;
			temp->right = NULL;
			if (check)
			{
				pos->left = temp;
				pos->right = NULL;
			}
			else
			{
				pos->left = NULL;
				pos->right = temp;
			}
			add(f, pos->left, true);
			add(f, pos->right, false);
		}
		if (c == '(')
		{
			add(f, pos, true);
		}

	}
}

int main()
{
	FILE* f = fopen("example.txt", "r");
	BinTree<char> tree;// = BinTree<char>();
	Node<char>* pos = tree.Root;
	
	add(f, pos, true);
	tree.traverseInfix(tree.Root);
	system("pause");
	return 0;
}