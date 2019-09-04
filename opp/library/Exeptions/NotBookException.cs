using System;

namespace library.Exeptions
{
    class NotBookException : Exception
    {
        public NotBookException() : base("Book is not found") { }
    }
}
