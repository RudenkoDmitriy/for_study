
namespace ZeroArray
{
    public class ZeroArray
    {
        public static int NumberOfZeroItems(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
