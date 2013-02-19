#pragma once
void insertSort (int* arr, int first, int last)
{
	for (int i = first; i < last + 1; i++) 
	{
        int temp = arr[i];
        for (int j = i - 1; j >= 0; j--)
		{
                if (arr[j] < temp)
				{
                        break;
                }
                arr[j + 1] = arr[j];
                arr[j]= temp;
        }
	}
 
}

void Qsort ( int* arr, int first, int last)
{
	int i = first;
	int j = last;
	int nCheck = arr[(i + j) / 2];
	do
	{
		while (arr[i]  < nCheck)
		{
			i++;
		}
		while (arr[j] > nCheck)
		{
			j--;
		}
		if (i <= j)
		{
			if (i < j)
			{
				int temp = arr[i];
				arr[i] = arr[j];
				arr[j] = temp;
			}
			++i;
			--j;
		}
	}
	while (i <=j);
	if (i < last)
	{
		if (last - i > 10)
		{
			Qsort (arr, i, last);
		}
		else
		{
			insertSort (arr, i, last);
		}
	}
    if (first < j)
	{
		if (j - first > 10)
		{
			Qsort (arr, first, j);
		}
		else
		{
			insertSort (arr, first, j);
		}
	}
}