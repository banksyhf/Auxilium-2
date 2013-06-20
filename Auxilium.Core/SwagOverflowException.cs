using System;

namespace Auxilium.Core
{
    //I really do not remember making this. Whatever, it's staying.
    [Serializable]
    public class SwagOverflowException : Exception
    {
        public SwagOverflowException()
        {
        }

        public SwagOverflowException(string message)
            : base(message)
        {
        }

        public SwagOverflowException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected SwagOverflowException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}