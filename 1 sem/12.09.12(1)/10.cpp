// ConsoleApplication5.cpp: ���������� ����� ����� ��� ����������� ����������.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{ int a[10];//���� ���c��� �� �����, �� ���� ������� ��������� ������ ��������
int k=0;
for(int i=0; i<10; i++)
{if(a[i]==0) 
k=k+1;}
cout<<k;
system("pause");
	return 0;
}

