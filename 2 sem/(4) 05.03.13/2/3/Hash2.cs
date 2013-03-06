
namespace _2
{
    public class Hash2 : IHash
    {
        public Hash2()
        {
            this.n = 100;
        }

        public int Hash(int value)
        {
            return (value * (n - 1)) % (n - 1);
        }

        private int n;
    }
}
