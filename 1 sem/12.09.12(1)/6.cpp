// ConsoleApplication7.cpp: определяет точку входа для консольного приложения.
//
//№6
#include "stdafx.h"
#include<iostream>
using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{int a[28]={0};
for (int i=0; i<10;++i)
{for (int j=0; j<10;++j)
{for (int k=0; k<10;++k)
a[i+j+k]=a[i+j+k]+1;}}
int s=0;
for (int i=0; i<28;++i)
{s=s+a[i]*a[i];}
cout<<s;
system("PAUSE");
	return 0;
}

