using FriendZone.Entities;
using System.Collections.Generic;

namespace FriendZone.Service
{
    public interface IContactService
    {
        Contact AddContact(Contact contact);
        Contact DeleteContact(int contactId);
        Contact GetContactById(int contactID);
        List<Contact> GetContacts();
        List<Contact> GetContactsByBirthMonth(int month);
        List<Contact> GetContactsByBloodGroup(string bloodGroup);
        List<Contact> GetContactsByFirstName(string FirstName);
        List<Contact> GetContactsByFullName(string firstName, string lastName);
        List<Contact> GetContactsByLastName(string lastName);
        List<Contact> GetContactsWithBirthdaysInCurrentMonth();
        Contact UpdateContact(int contactId, Contact updatedContact);
        bool ValidateContact(Contact contact);
    }
}