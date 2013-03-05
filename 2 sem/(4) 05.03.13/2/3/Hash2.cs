
namespace _2
{
    public class Hash2 : IHash
    {
        public int Hash(int value)
        {
            return value / 151;
        }
    }
}
