using System.Collections.Generic;

namespace _3
{
    public class Fold
    {
        public delegate int FoldDel(int acc, int elem);

        public static int FoldFunc(List<int> list, int acc, FoldDel f)
        {
            int result = acc;
            foreach (int i in list)
            {
                result = f(result, i);
            }
            return result;
        }
    }
}
