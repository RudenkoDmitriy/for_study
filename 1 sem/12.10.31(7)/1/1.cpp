#include"mergeSort.h"
#include<iostream>
#include<fstream>
#include<locale.h>


using namespace std;

void  printList(TempList* l)
{
	Position pos = l->first();
	int temp = l->lengthList();
	if (l->retrieve(l->first()).number != NULL)
		--pos;
	for (int i = 0; i < temp; ++i)
	{
		Tel value = l->retrieve(l->next(pos));;
		cout << value.name << ' ' << value.number << endl;
		cout << ' ';
		pos = l->next(pos);
	}
}


int main()
{
	fstream f ("example.txt");
	TempList* l = new TempList();
	Position pos = l->first();
	setlocale(LC_ALL, "Russian");
	while(!f.eof())
	{
		Tel temp;
		temp.name = new char[15];
		f >> temp.number;
		f >> temp.name;
		l->insert(temp, pos);
		pos = l->next(pos);
	}
	cout << "Если вы хотите отсортировать по именам введите 1, если по номерам - введите любой другой символ." << endl;
	int temp = 5;
	cin >> temp;
	
	if (temp == 1)
		l = mergeSort<Tel>(l, false);
	else
		l = mergeSort<Tel>(l, true);
	printList(l);
	system("pause");
}