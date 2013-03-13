
namespace _2
{
    public class UniqueList : List
    {
        public void Insert(int value, ListElement pos)
        {
            if (this.Find(value))
            {
                try
                {
                    throw new AddExistingNumberException();
                }
                catch (AddExistingNumberException e)
                {
                    return;
                }
            }
            base.Insert(value, pos);
        }

        public void Remove(int value)
        {
            if (!this.Find(value))
            {
                try
                {
                    throw new RemoveNotExistingNumberException();
                }
                catch (RemoveNotExistingNumberException e)
                {
                    return;
                }
            }
            base.Remove(value);
        }
    }
}
