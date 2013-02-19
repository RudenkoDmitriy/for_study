#include <iostream>

using namespace std;

int const size = 100;

int charToInt (char c)
{
	if ((int)c < 97)
		return (int)c -65;
	else
		return (int)c - 97;
}

int search(int lengthString, char string[size], int lengthWord, char searchWord[size])
{
	int alphabet[27];
	for (int i = 0; i < 27; ++i)
		alphabet[i] = lengthWord;
	for (int i = lengthWord - 2; i > -1; --i)
	{
		if (alphabet[charToInt(searchWord[i])] == lengthWord)
			alphabet[charToInt(searchWord[i])] = lengthWord - i - 1;
	}
	int pos = lengthWord - 1;
	while (pos < lengthString)
	{
		if (string[pos] == searchWord[lengthWord - 1])
		{
			int tempRes = 0;
			for (int i = lengthWord - 2; i > - 1; --i)
			{
				tempRes = i;
				if (searchWord[i] != string[pos - lengthWord + 1 + i])
				{
					tempRes = -1;
					break;
				}
			}
			if (tempRes == 0) 
				return pos - lengthWord + 2;
			else
			{
				if (pos >= lengthString - 1)
				return -1;
				pos = pos + alphabet[charToInt(string[pos])];
			}
		}
		else
		{
			if (pos >= lengthString - 1)
				return -1;
			pos = pos + alphabet[charToInt(string[pos])];
		}
	}
	return -1;
}

int main()
{
	FILE* f = fopen("example.txt", "r");
	char* string;
	string = new char[size]; 
	int i = 0;
	while(!feof(f))
	{
		fscanf(f, "%c", &string[i]);
		++i;
	}
	int lengthString = i;
	char* searchWord;
	searchWord = new char[size];
	i = 0;
	char tempChar = ' ';
	cout << "Enter word, in the end enter '.'" << endl;
	while (tempChar != '.')
	{
		cin >> tempChar;
		if (tempChar != '.')
		{
			searchWord[i] = tempChar;
			++i;
		}
	}
	int lengthWord = i;
	int result = search(lengthString, string, lengthWord, searchWord);
	if (result == -1)
		cout << "the word is not in string" << endl;
	else
		cout << "Position = " << result << endl;
	system("pause");
	return 0;
}

/*positive:
example
xam
l

negative:
max
ee
asd
*/