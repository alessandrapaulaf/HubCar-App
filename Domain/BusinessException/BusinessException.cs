using System;
using System.Runtime.Serialization;
using System.Text;

namespace Hubcar.Domain.BusinessException
{
    public class BusinessException : Exception
    {
        public BusinessException(string message) : base(message) { }

        protected BusinessException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
