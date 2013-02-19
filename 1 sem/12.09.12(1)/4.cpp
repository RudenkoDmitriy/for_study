// ConsoleApplication6.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int _tmain(int argc, _TCHAR* argv[])// не работает для отрицательных чисел
{int x,y;
cout<<"vvedite delimoe"<<endl;
cin>>x;
cout<<"vvedite delitel'"<<endl;
cin>>y;
int t=0;
if (x*y<0)  t=1;
if (x<0)  x=-x ;
if (y<0)  y=-y ;
int k=0;
do
	{ k=k+1;
	y=k*y;}
	while(x>=y);
k=k-1;
if (t==11) {int k=-k};
cout<<k;
system("pause");
	return 0;
}

