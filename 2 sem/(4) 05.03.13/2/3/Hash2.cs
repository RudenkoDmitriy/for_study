
namespace _2
{
    public class Hash2 : IHash
    {
        public int Hash(int value, int n)
        {
            return value.GetHashCode() % (n - 1);
        }
    }
}
