using System.Runtime.Serialization;

namespace FilmSerwisWPF
{
    [Serializable]
    internal class NotSelectedException : Exception
    {
        public NotSelectedException()
        {
        }

        public NotSelectedException(string? message) : base(message)
        {
            message = "Nie zaznaczono filmu.";
        }

        public NotSelectedException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NotSelectedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}