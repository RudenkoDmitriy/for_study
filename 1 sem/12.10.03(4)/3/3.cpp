#include <iostream>

using namespace std;

int main()
{
	FILE * f = fopen("C:\\Users\\Александр\\Desktop\\програмирование\\12.10.03\\3\\example2.txt", "r");
	bool temp = false;
	int numberOfString = 0;
	while(!feof(f))
	{
		char chr;
		fscanf(f, "%c", &chr);
		cout << chr;
		if(chr != '\n' && chr != '\t' && chr != ' ')
		{
			temp = true;
		}
		if(chr == '\n')
		{
			if(temp)
			{
				++numberOfString;
			}
			temp = false;
		}
	}
	fclose(f);
	cout << endl;
	cout << "Number of not empty string = " << numberOfString << endl;
	system("pause");
	return 0;
}
