#include <iostream>
#include <locale.h>
#include "HashTub.h"
#include <fstream>
#include <string.h>

using namespace std;

struct numOfWord
{
	char* value;
	int number;
};

int main()
{
	setlocale (LC_ALL,"Russian");
	fstream filestr ("example.txt", fstream::in | fstream::out);
	HashTub<char*> ht;
	numOfWord ar[n];
	for(int j = 0; j < n; ++j)
	{
		ar[j].number = 0;
		ar[j].value ;
	}
	char* ch = "       ";
	int i = 0;
	ht.filling();
	while (!filestr.eof())
	{
		char temp[50];
		filestr.getline(temp, 50);
		ch = new  char[50];
		strcpy(ch, temp);
		if (ht.find(ch))
		{
			for (int k = 0; k < i + 1; ++k)
			{
				if (compare(ar[k].value, temp))
				{
					++ar[k].number;					
					break;
				}
			}
		}
		else
		{				
			ht.add(ch);
			ar[i].value = ch;
			++ar[i].number;
			++i;
		}
	}
	for (int j = 0; j < i; ++j)
	{
		cout << ar[j].value << ' ' << ar[j].number << endl;
	}
	filestr.close();
	system("pause");
	return 0;
}