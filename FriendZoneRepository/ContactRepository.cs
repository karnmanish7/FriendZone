using FriendZone.Entities;
using System;
using System.Collections.Generic;

namespace FriendZone.DAO
{
    public class ContactRepository : IContactRepository
    {
        public Contact CreateContact(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Contact DeleteContact(int contactId)
        {
            throw new NotImplementedException();
        }

        public Contact GetContactById(int contactId)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<Contact> GetContacts(string firstName = null, string lastName = null, int? month = null, string bloodGroup = null)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<Contact> GetContactsWithBirthdaysInCurrentMonth()
        {
            throw new NotImplementedException();
        }

        public bool IsContactNoExists(string contactNo)
        {
            throw new NotImplementedException();
        }

        public Contact UpdateContact(Contact updatedContact)
        {
            throw new NotImplementedException();
        }
    }
}
