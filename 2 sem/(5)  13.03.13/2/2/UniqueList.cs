
namespace _2
{
    public class UniqueList : List
    {
        public void Insert(int value, ListElement pos)
        {
            if (this.Find(value))
            {
                    throw new AddExistingNumberException();
            }
            base.Insert(value, pos);
        }

        public void Remove(int value)
        {
            if (!this.Find(value))
            {
                    throw new RemoveNotExistingNumberException();
            }
            base.Remove(value);
        }
    }
}
