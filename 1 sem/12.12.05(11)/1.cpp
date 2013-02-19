
#include <iostream>

using namespace std;

bool digit(char value)
{
	return (((int)value) > 47 && ((int)value) < 58);
}

int const fail = -1;

int scan(char &c, int pos)
{
	if (c == '*')
	{
		return pos;
	}
	cin >> c;
	if (digit(c))
		c = '1';
	switch (pos)
	{
		case 0 : switch (c)
				{
					case '-' : 
						scan(c, 1);
						break;
					case '1' : 
						scan (c, 2);
						break;				
					break;
				 }
		case 1 : switch (c)
				 {
					case '1' : 
						scan(c,2);
						break;
					case '*' :
						return 5;
						break;				
					break;
				 }
				 break;
		case 2 : switch (c)
				 {
					case '.' : 
						scan(c, 6);
						break;
					case '*' : 
						return 5;	
					case 'E' : 
						scan(c, 4);
						break;
				 }
				 break;
		case 6 : switch (c)
				 {
					case '1' :
						scan(c,3);
						break;				 
					break;
				 }
				 break;
		case 3 : switch (c)
				 {
					case '1' : 
						scan(c, 3);
						break;
					case 'E' : 
						scan(c, 4);
						break;
					case '*' :
						return 5;
						break;
					break;
				 }
				 break;
		case 4 : switch (c)
				 {
					 case '1' :
						scan(c, 5);
						break;
					case '-' : 
						scan(c, 8);
						break;				
					case '+' :
						scan(c, 8);
						break;
					break;
				 }
				 break;
		case 8 : switch (c)
				 {
					 case '1' :
						scan(c, 5);
						break;
					break;
				 }
				 break;
		case 5 : switch (c)
				 {
					case '1' :
						scan(c, 5);
						break;
					case '*' :
						return 5;
						break;
					break;
				 }
				 break;
		default : return fail;
	}
}

int main()
{
	char c = '-';
	cout << "Enter string, in the end enter '*'" << endl;
	if (scan(c, 0) == 5)
		cout << "Good.";
	else
		cout << "Fail.";
	system("pause");
	return 0;
}
/*
efew*
12.12312-12*
fewafewagewegwgear
x
21.-123
.323E4
32.1+123EE

1E12421
23.E123
123 
12.12434323E-2131324212*
12.34

*/