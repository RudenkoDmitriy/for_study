#include <iostream>
#include <locale.h>
using namespace std;

int const n = 20;

struct Table
{
	int start;
	int finish;
	char nameStation[n];
	int length;
	Table()
	{
		for (int i = 0; i < n; ++i)
			nameStation[i] = ' ';
		start = NULL;
		finish = NULL;
		length = 0;
	}
};

int read(FILE* f)
{
	int temp1 = 0;
	int temp2 = 0;
	fscanf(f, "%d", &temp1);
	char c = ' ';
	fscanf(f, "%c", &c);
	fscanf(f, "%d", &temp2);
	return temp1 * 60 + temp2;
}

void travel(int start, int finish, Table timeTable[n])
{
	cout << endl;
	int result =  timeTable[finish].start - timeTable[start].finish;
	cout << result << endl;
	if ((result < 1) || (start == finish))
	{
		cout << "“акое путешествие невозможно" << endl;
		return;
	}
	else
		cout << "ќт станции " << timeTable[start].nameStation << " до станции " << timeTable[finish].nameStation << ' ' << result / 60 << ':' << result % 60 << endl;
}

int main()
{
	FILE* f = fopen("example.txt", "r");
	Table timeTable[n];
	setlocale(LC_ALL, "Russian");
	for (int i = 0; i < n; ++i)
		timeTable[i] = Table();
	int i = 0;
	while(!feof(f))
	{
		int j = 0;
		char c = '&';
		int temp = 0;
		while (!(c == '\n' || c ==' ' || c == '\t'))
		{
			fscanf(f, "%c", &c);
			if (!(c == '\n' || c ==' ' || c == '\t'))
			{
				timeTable[i].nameStation[j] = c;
				++j;
				timeTable[i].length = j;
			}
		}
		timeTable[i].start = read(f);
		i = i;
		if (!feof(f) && (i != 0))
		{
			timeTable[i].finish = read(f);	
		}
		++i;
		if (!feof(f))
			fscanf(f, "%c", &c);
	}
	--i;
	timeTable[i].finish = timeTable[i].start;
	timeTable[0].finish = timeTable[0].start;
	cout << "¬ведите номера станций(сначало начальную, потом конечную)" << endl;
	int st1 = 0;
	int st2 = 0;
	cin >> st1;
	cin >> st2;
	travel(st1 - 1, st2 - 1, timeTable);
	system("pause");
	return 0;
}