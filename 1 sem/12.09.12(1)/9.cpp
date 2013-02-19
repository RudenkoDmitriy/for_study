#include <iostream>
using namespace std;
int main()
{
	cout << "inter n" << endl;
	int n = 0;
	cin >> n;
	cout << "1,2";
	bool   hasDivisorsFlag = true;
	for (int i = 3; i < n + 1; ++i)
	{
		for (int j = i - 1; j > 1; --j)
		{
			if (i % j == 0) 
			{
				 hasDivisorsFlag = false;
			}
			
		}
		if (  hasDivisorsFlag )
		{
			cout << ",";
			cout << i;
		}

		 hasDivisorsFlag = true;
	}
	system("pause");
	return 0;
}