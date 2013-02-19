#pragma once;
template <class T>
struct Node
{
	T value;
	Node<T>* parent;
	Node<T>* right;
	Node<T>* left;
};
template <class T>
class BinTree
{
	public:
	Node<T>* Root;
	BinTree()
	{
		Root = new Node<T>;
		Root->left = NULL;
		Root->right = NULL;
		Root->parent = Root;
		Root->value = -14565658;
	}
	Node<T>* position(T value, Node<T>* temp )
	{
		if (value > temp->value)
		{
			if (temp->right == NULL)
				return temp;
			position(value, temp->right);
		}
		else
		{
			if (temp->left== NULL)
				return temp;
			position(value, temp->left);
		}
	}
	Node<T>* find(T value, Node<T>* pos)
	{

		if (pos != NULL)
		{
			if (pos->value == value)
				return pos;
			if (pos->value < value)
				return find(value,pos->right);
			else
				return find(value,pos->left);
		}
		return NULL;
	}
	void insert(T value)
	{
		Node<T>* temp = this->Root;
		temp = position(value, temp);
		Node<T>* node = new Node<T>;
		node->value = value;
		node->parent = temp;
		node->left = NULL;
		node->right = NULL;
		if (value > temp->value)
			temp->right = node;
		else
			temp->left = node;
			
	}
	void remove(T value, Node<T>* pos)
	{
		if (value > pos->value)
			remove(value, pos->right);
		if (value < pos->value)
			remove(value, pos->left);
		if (value == pos->value)
		{
			if (pos->right == NULL && pos->left == NULL)
			{
				if (pos->parent->left == pos)
					pos->parent->left = NULL;
				else
					pos->parent->right = NULL;
				delete pos;
				return;
			}
			if (pos->right != NULL && pos->left != NULL)
			{
				Node<T>* temp = pos->right;
				while(temp->left != NULL)
					temp = temp->left;
				pos->value = temp->value;
				if(temp->parent->left == temp)
					temp->parent->left = NULL;
				else
					temp->parent->right = NULL;
				delete temp;
			}
			else
			{
				if (pos->right != NULL)
					pos->parent->right = pos->right;
				else
					pos->parent->left = pos->left;
				delete pos;
			}
		}
	}
	void traverseInfix(Node<T>* pos)
	{
		if (pos->left != NULL)
			traverseInfix(pos->left);
		if (pos != this->Root)
		{
			printf("%d", pos->value);
			printf("%c", ',');
		}
		if (pos->right != NULL)
			traverseInfix(pos->right);
	}
	void traversePrefix(Node<T>* pos)
	{
		if (pos != this->Root)
		{
			printf("%d", pos->value);
			printf("%c", ',');
		}
		if (pos->left != NULL)
			traversePrefix(pos->left);
		if (pos->right != NULL)
			traversePrefix(pos->right);
	}
	void traversePostfix(Node<T>* pos)
	{
		if (pos->left != NULL)
			traversePostfix(pos->left);
		if (pos->right != NULL)
			traversePostfix(pos->right);
		if (pos != this->Root)
		{
			printf("%d", pos->value);
			printf("%c", ',');
		}
	}
};