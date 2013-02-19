// ConsoleApplication2.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include<iostream>
using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{char a[10];
cout<<"zapolnite stroku, dlina 10 simvolov"<<endl;
for(int i=0;i<10;i++)
{cin>>a[i];}
int x=0;
for(int i=0;i<10;i++)
{if (a[i]=='(')
    x=x-1;
else
	x=x+1;}
if (a[1]==')') 
{x=-1;}
if (a[9]=='(')
{x=-1;}
if (x!=0) 
{cout<<"ne sootvetstvuet"<<endl;}
else
{cout<<"sootvetstvuet"<<endl;}
system("pause");
	return 0;
}

