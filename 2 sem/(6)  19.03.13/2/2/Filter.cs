using System.Collections.Generic;

namespace _2
{
    public class Filter
    {
        public delegate bool FilterDelegate(int value);

        public static List<int> FilterList(List<int> list, FilterDelegate f)
        {
            List<int> temp = new List<int>();

            foreach (int i in list)
            {
                if (f(i))
                {
                    temp.Add(i);
                }
            }

            return temp;
        }
    }
}
