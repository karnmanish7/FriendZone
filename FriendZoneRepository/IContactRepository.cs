using FriendZone.Entities;
using System.Collections.Generic;

namespace FriendZone.DAO
{
    public interface IContactRepository
    {
        Contact CreateContact(Contact contact);
        Contact DeleteContact(int contactId);
        Contact GetContactById(int contactId);
        IReadOnlyList<Contact> GetContacts(string firstName = null, string lastName = null, int? month = null, string bloodGroup = null);

        bool IsContactNoExists(string contactNo);
        IReadOnlyList<Contact> GetContactsWithBirthdaysInCurrentMonth();
        Contact UpdateContact(Contact updatedContact);
    }
}