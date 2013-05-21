using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP_N2
{
    public class BubbleSort<T>
    {
        /// <summary>
        /// This function using for sort array.
        /// </summary>
        /// <param name="array"></param>
        public static void Sort(ref T[] array)
        {
            for (int i = 0; i < array.Length - 1; ++i)
                for (int j = i + 1; j < array.Length; ++j)
                {
                    if (Compare(array[i], array[j]))
                    {
                        T temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
        }

        private static bool Compare(T item1, T item2)
        {
            int h1 = item1.GetHashCode();
            int h2 = item2.GetHashCode();
            return h1 > h2;
        }   
    }
}
