using System;

namespace lab2.exc
{
    public class RomanNumberException : Exception
    {
        public short Value { get; }
        public RomanNumberException(string message) : base(message)
        {

        }
    }
}