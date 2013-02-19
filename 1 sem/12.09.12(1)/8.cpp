#include <iostream>
using namespace std;
int main()
{
	string str1 = "word";
	string str2 = "ndsijnsdjvniwordjvsokmsdvswordmvsdovwordhgjghj";//this is string include 3 "word"
	int number = 0;
	for (int j = 0; j < str2.length() - str1.length() + 1; j++)
	{
		int check = 0;
		if (str2[j] == str1[0])
		{
			check = 1;
			for(int i = 1; i < str1.length() + 1; i++)
			{
				if (str1[i] == str2[i +j ])
				{
					check = ++check;
				}
			}
		}
			
		if (check == str1.length())
		{
			number = ++number;
		}
	}
	cout << "number=" << number << endl;
	scanf("%*s");
	return 0;
}