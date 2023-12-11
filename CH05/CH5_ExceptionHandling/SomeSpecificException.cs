using System.Runtime.Serialization;

namespace CH5_ExceptionHandling
{
    [Serializable]
    internal class SomeSpecificException : Exception
    {
        public SomeSpecificException()
        {
        }

        public SomeSpecificException(string? message) : base(message)
        {
        }

        public SomeSpecificException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected SomeSpecificException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}