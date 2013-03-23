using System;
using System.Collections.Generic;
using System.Linq;


namespace _1
{
    public class Map
    {
        public static List<int> MapFunc(List<int> list, Func<int, int> func)
        {
            List<int> temp = new List<int>();
            for (int i = 0; i < list.Count(); ++i)
            {
                temp.Add(func(list[i]));
            }
            return temp;
        }
    }
}
