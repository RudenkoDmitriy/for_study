#include <iostream>
using namespace std;
int main()
{
	int arr[10] = {2, 3, 4, 1, 5, 4, 3, 6, 7, 0};
	int counting[11] = {0};//для подсчета чисел от 0 до 10
	for (int i = 0; i < 10; ++i)
	{
		int temp = 0;
		temp = arr[i];
		counting[temp]++;
	}
	for (int i = 0; i < 11; ++i)
	{
		if (counting[i] != 0)
		{
			cout<<i<<",";
			counting[i]--;
			continue;
		}
		else
		{
			break;
		}
	}
	system("pause");
	return 0;
}