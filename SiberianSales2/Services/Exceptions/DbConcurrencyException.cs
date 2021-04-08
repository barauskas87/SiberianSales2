using System;
using System.Runtime.Serialization;

namespace SiberianSales2.Services.Exceptions
{
    [Serializable]
    internal class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException()
        {
        }

        public DbConcurrencyException(string message) : base(message)
        {
        }

        public DbConcurrencyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DbConcurrencyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}