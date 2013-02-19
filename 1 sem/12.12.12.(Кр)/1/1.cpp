#include"list.h"
#include<iostream>;
#include"mergeSort.h"
using namespace std;

int main()
{
	List<int>* l = new List<int>();
	int number = 8;
	while(number != 0)
	{
		cin >> number;
		if (number == 0)
			break;
		ListElement<int>* p = l->first();
		if (p != NULL)
		{
			while (p->next != NULL)
			{
				if (l->retrieve(p) > number) 
					p = next(p);
				else
					break;
			}
		}
		l->insert(number, p);
	}
	mergeSort(l);
	ListElement<int>* p = l->first();
	int check = 1;
	for (int i = 0; i < l->lengthList() - 1; ++i)
	{
		if (l->retrieve(p) == l->retrieve(p->next))
			++check;
		else
		{
			cout << l->retrieve(p) << ' ' << check << endl;
			check = 1;
		}
		p = p->next;
	}
	cout << l->retrieve(p) << ' ' << 1;
	system("pause");
}