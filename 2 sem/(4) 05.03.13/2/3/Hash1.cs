
namespace _2
{
    public class Hash1 : IHash
    {
        public Hash1()
        {
            this.n = 100;
        }

        public int Hash(int value)
        {
            return value % (n - 1);
        }

        private int n;
    }
}
