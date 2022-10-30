using System;

namespace dining_room
{
    public class ProductException : Exception
    {
        public ProductException(string message) : base(message)
        { }
    }
}