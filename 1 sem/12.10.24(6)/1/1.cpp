#include"mergeSort.h"
#include<iostream>
#include<fstream>
#include<locale.h>

using namespace std;

void  printList(List<Tel>* l)
{
	ListElement<Tel>* pos = l->first();
	int temp = l->lengthList();
	for (int i = 0; i < temp; ++i)
	{
		Tel value = l->retrieve(pos->next);;
		cout << value.name << ' ' << value.number << endl;
		printf("%c",' ');
		pos = pos->next;
	}
}

int main()
{
	fstream f ("example.txt");
	List<Tel>* l = new List<Tel>();
	ListElement<Tel>* pos = l->first();
	setlocale(LC_ALL, "Russian");
	while(!f.eof())
	{
		Tel temp;
		temp.name = new char[15];
		f >> temp.number;
		f >> temp.name;
		l->insert(temp, pos);
		pos = pos->next;
	}
	cout << "Если вы хотите отсортировать по именам введите 1, если по номерам - введите любой другой символ." << endl;
	int temp = 5;
	cin >> temp;
	if (temp == 1)
		mergeSort(l, false);
	else
		mergeSort(l, true);
	printList(l);
	system("pause");
}