using System;
using Course_Intermediate_Exceptions.Entities.Exceptions;

namespace Course_Intermediate_Exceptions.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
