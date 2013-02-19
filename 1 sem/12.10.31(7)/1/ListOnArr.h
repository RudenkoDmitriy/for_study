#pragma once


template <class T>
class ListOnArr
{
	int lengthArr;
	public:
		T* arr;
		int lengthListValue;
		ListOnArr()
		{
			arr = new T[100];
			lengthListValue = 0;
			lengthArr = 100;
		}
		void insert(T value,int  pos)
		{
			if ( lengthListValue == lengthArr)
			{
				lengthArr = 2 * lengthArr;
				T* temp = new T[lengthArr];
				for (int i = 0; i <  lengthListValue; ++i)
					temp[i] = arr[i];
				arr = temp;
				delete[]  temp;
			}
			lengthListValue++;
			arr[pos] = value;
		}
		int first()
		{
			return 0;
		}
		int next(int pos)
		{
			return ++pos;
		}
		T retrieve(int pos)
		{
			return arr[pos];
		}
		void removeList()
		{
			delete [] arr;
		}
		int lengthList()
		{
			return  lengthListValue;
		}
};