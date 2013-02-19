// ConsoleApplication4.cpp: определяет точку входа для консольного приложения.
//
#include "stdafx.h"
#include<iostream>


using namespace std;


int _tmain(int argc, _TCHAR* argv[])
{ int x,y;
cout<<"vvedite x";
cin>>x;
y=x*x;
y=(y+1)*(y+x);
cout<<y;
system("pause");
	return 0;
}

