using System;

namespace FriendZone.Entities.Exceptions
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException(string message):base(message)
        {

        }
    }
}
