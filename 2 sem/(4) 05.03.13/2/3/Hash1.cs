
namespace _2
{
    public class Hash1 : IHash
    {
        public int Hash(int value, int n)
        {
            return value % (n - 1);
        }
    }
}
