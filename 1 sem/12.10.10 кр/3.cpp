#include <iostream>

using namespace std;

int main()
{
	FILE * f = fopen("C:\\Users\\Александр\\Desktop\\example.txt", "r");
	while(!feof(f))
	{
		char chr;
		fscanf(f, "%c", &chr);
		if(chr == ';' )
		{
			while (chr != '\n' && !feof(f))
			{
				cout << chr;
				fscanf(f, "%c", &chr);
			}
			cout << endl;
		}
	}
	system("pause");
	return 0;
}