#include<iostream>
#include<string>

using  namespace std;

bool letter(char c)
{
	return (((int)c > 63) && ((int)c < 91)) || (((int)c > 96) && ((int)c < 123));
}

bool digit(char c)
{
	return ((int)c > 47) && ((int)c < 58);
}

bool compare(char c)
{
	return (letter(c) || digit(c) || c == '_');
}

int const fail = -6;

int scan(int pos, int state, string s)
{
	if ((pos > 0) && !(compare(s[pos])))
		return fail;
	++pos;
	if (pos >= s.length())
		return state;
	switch (state)
	{
		case fail : {
						return fail;
						break;
					}
		case 0 : {
					if (letter(s[pos]))
					{
						return scan(pos, 1, s);
					}
					 else
						 return fail;
					break;
				 }
		case 1 : {
					if (compare(s[pos]))
					{					
						 return scan(pos, 1, s);
					}
					 else
					 {
						 return fail;
					 }
					break;
				 }
		default : return fail;
	}
}

int main()
{
	string s;
	cin >> s;
	int state = 0;
	if (scan(-1, state, s) != fail)
		cout << "Correct";
	else
		cout << "Incorrect";
	system("pause");
	return 0;
}