using System;
using System.Runtime.Serialization;

namespace Login2
{
    [Serializable]
    internal class Excepion : Exception
    {
        public Excepion()
        {
        }

        public Excepion(string message) : base(message)
        {
        }

        public Excepion(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected Excepion(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}