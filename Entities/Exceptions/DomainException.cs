using System;

namespace ExceptionsBankAccount.Entities.Exceptions
{
    class DomainException : Exception
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
