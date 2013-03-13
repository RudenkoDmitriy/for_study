using System;

namespace _2
{
    public class AddExistingNumberException : ApplicationException
    {
        public AddExistingNumberException()
        {
        }

        public AddExistingNumberException(string message)
            : base(message)
        {
        }
    }
}
