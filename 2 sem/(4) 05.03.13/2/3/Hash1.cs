
namespace _2
{
    public class Hash1 : IHash
    {
        public int Hash(int value)
        {
            return value % 101;
        }
    }
}
