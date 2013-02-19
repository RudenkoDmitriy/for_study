#include<iostream>
#include"list.h"
using namespace std;
int main()
{
	FILE* f = fopen("example1.txt", "r");
	List<int>* list = new List<int>();
	int value = 0;
	ListElement<int>* pos = list->first();
	while (!feof(f))
	{
		fscanf(f, "%d", &value);
		list->insert(value, pos);
		pos = pos->next;
	}
	cout << "Enter a" << endl;
	int a = 0;
	cin >> a;
	cout << endl << "Enter b" << endl;
	int b = 0;
	cin >> b;
	if (a > b)
	{
		cout << "Incorrect numbers!";
	}
	else
	{
			FILE* g = fopen("example2.txt", "a");
			pos = list->first();
			while (pos->next != NULL)
			{
				pos = pos->next;
				if (pos->value < a)
					fprintf(g, "%d", pos->value);
					fprintf(g, "%c", ' ');
			}
			pos = list->first();
			while (pos->next != NULL)
			{
				pos = pos->next;
				if (pos->value >= a && pos->value <= b)
				fprintf(g, "%d", pos->value);
				fprintf(g, "%c", ' ');
			}
			pos = list->first();
			while (pos->next != NULL)
			{
				pos = pos->next;
				if (pos->value > b)
				fprintf(g, "%d", pos->value);
				fprintf(g, "%c", ' ');
			}
	}
	fclose(f);
	fclose(g);
	system("pause");
	return 0;
}