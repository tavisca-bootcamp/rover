using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    [Serializable]
    public class OutOfLimitsException : Exception
    {
        public OutOfLimitsException() : base() { }
        public OutOfLimitsException(string message) : base(message) { }
        public OutOfLimitsException(string message, Exception inner) : base(message, inner) { }

        protected OutOfLimitsException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
