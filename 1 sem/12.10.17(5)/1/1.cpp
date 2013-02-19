#include <iostream>
#include<locale.h>

using namespace std;

struct Telephone
{
	char name[20];
	int number;
};

bool compare(char name1[20], char name2[20])
{
	if (strlen(name1) != strlen(name2))
	{
		return false;
	}
	for (int i = 0; i < strlen(name1); ++i)
	{
		if (name1[i] != name2[i])
			return false;
	}
	return true;
}

void findNumber(Telephone* telephone, int &counter)
{
	char name0[20];
	cout << "������� ��� ��� ������" << endl;
	scanf("%s", &name0);
	for (int i = 0; i < counter ; ++i)
	{
		if ( compare(telephone[i].name, name0))
		{
			cout << endl << telephone[i].number << endl;
			return;
		}
	}
	cout << endl << "������ ����� � ���� ���!" << endl;
	return ;
}

void findName(Telephone* telephone, int &counter)
{
	int number0 = -1;
	cout << "������� ����� ��� ������" << endl;
	cin >> number0;
	/*if (number0 == -1) 
		return;*/
	for (int i = 0; i < counter; ++i)
	{
		if ( telephone[i].number == number0)
		{
			cout << endl;
			printf("%s",&(telephone[i].name));
			return;
		}
	}
	cout << endl << "������ ������ � ���� ���!" << endl;
	return;
}

void add(Telephone* telephone, int &counter)
{
	cout << "������� �����" << endl;
	cin >> telephone[counter].number;
	cout << endl << "������� ���" << endl;
	scanf("%s",&(telephone[counter].name));
	++counter;
}

void readFile(Telephone* telephone, int &counter, FILE * f, int &counter0)
{
	while(!feof)
	{
		fscanf(f, "%d", &(telephone[counter].number));
		char temp = '=';
		fscanf(f, "%s", &(telephone[counter].name));
		++counter;
	}
	counter0 = counter;
}

void recordFile(Telephone* telephone, int &counter, FILE * f, int counter0)
{
		for (int i = counter0; i < counter; ++i)
		{
			fprintf(f, "%d", (telephone[i].number));
			fprintf(f, "%c", ' ');
			fprintf(f, "%s", &(telephone[i].name));
			fprintf(f, "%c", '\n');
		}
}

void choice(int command, Telephone* telephone, int &counter, FILE * f, int counter0)
{
	switch(command)
	{
		case 1:
			add(telephone, counter);
			break;
		case 2 :
			findNumber(telephone, counter);
			break;
		case 3 :
			findName(telephone, counter);
			break;
		case 4:
			recordFile(telephone, counter, f, counter0);
			break;
	}
}
		
int main()
{
	setlocale (LC_ALL,"Russian");
	FILE * f = fopen("C:\\Users\\���������\\Desktop\\���������������\\12.10.19\\1\\example.txt", "a+");
	int counter = 0;
	int const n = 100;
	Telephone tel[n];
	int counter0 = 0;
	readFile(tel, counter, f, counter0);
	cout << "������� �������" << endl;
	cout <<"1 - �������� � ����������" << endl ;
	cout << "2 - ����� �� �����" << endl;
	cout << "3 - ����� �� ������" << endl ;
	cout << "4 - ������ ����������� � ����" << endl;
	cout << "0 - �����" << endl;
	int command = 0;
	cin >> command;
	cout << endl;	
	while (command != 0)
	{		
		choice(command, tel, counter, f, counter0);
		cout << endl << "������� �������" << endl ;
		cin >> command;
		cout << endl;
	}
	fclose(f);
	return 0;
}
