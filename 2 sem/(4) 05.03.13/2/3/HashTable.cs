
namespace _2
{
    public class HashTable
    {
        private const int  n = 100;
        private List[] list;

        public HashTable(IHash hash)
        {
            list = new List[n];
            for (int i = 0; i < n; ++i)
            {
                list[i] = new List();
            }
            this.hash = hash;
        }

        private IHash hash;

        public bool Find(int value)
        {
            int h = hash.Hash(value);
            return list[h].Find(value);
        }

        public void Remove(int value)
        {
            if (!this.Find(value))
                return;
            int h = hash.Hash(value);
            ListElement pos = list[h].First();
            while ((pos.next != null) || (list[h].Retrieve(pos) != value))
            {
                int temp = list[h].Retrieve(pos);
                pos = list[h].Next(pos);
            }
            if (list[h].Retrieve(pos) == value)
            {
                list[h].Remove(pos);
            }
        }

        public void Add(int value)
        {
            if (!Find(value))
            {
                int h = hash.Hash(value);
                ListElement pos = list[h].First();
                list[h].Insert(value, pos);
            }
        }
    }
}
