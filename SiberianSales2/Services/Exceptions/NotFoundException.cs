using System;
using System.Runtime.Serialization;

namespace SiberianSales2.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException()
        {
        }


        public NotFoundException (string message) : base(message)
        {

        }
    }

}