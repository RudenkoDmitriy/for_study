using System;

namespace _2
{
    class RemoveNotExistingNumberException : ApplicationException
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
