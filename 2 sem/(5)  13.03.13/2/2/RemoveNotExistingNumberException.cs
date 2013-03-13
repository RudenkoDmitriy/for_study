using System;

namespace _2
{
    public class RemoveNotExistingNumberException : ApplicationException
    {
        public RemoveNotExistingNumberException()
        {
        }

        public RemoveNotExistingNumberException(string message)
            : base(message)
        {
        }
    }
}
