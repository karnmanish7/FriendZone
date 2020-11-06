using System;

namespace FriendZone.Entities.Exceptions
{
    public class ContactNoExistsException : Exception
    {
        public ContactNoExistsException(string message): base(message)
        {

        }

    }
}
