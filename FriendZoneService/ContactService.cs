using FriendZone.DAO;
using FriendZone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FriendZone.Service
{
    public class ContactService : IContactService
    {
        private IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            this._contactRepository = contactRepository;
        }
        public Contact AddContact(Contact contact)
        {
           return this._contactRepository.CreateContact(contact);
        }

        public Contact DeleteContact(int contactId)
        {
            return this._contactRepository.DeleteContact(contactId);
        }

        public Contact GetContactById(int contactID)
        {
            return this._contactRepository.GetContactById(contactID);
        }

        public List<Contact> GetContacts()
        {
            return this._contactRepository.GetContacts().ToList();
        }

        public List<Contact> GetContactsByBirthMonth(int month)
        {
            return this._contactRepository.GetContacts(month: month).ToList();
        }

        public List<Contact> GetContactsByBloodGroup(string bloodGroup)
        {
            return this._contactRepository.GetContacts(bloodGroup: bloodGroup).ToList();
        }

        public List<Contact> GetContactsByFirstName(string firstName)
        {
            return this._contactRepository.GetContacts(firstName: firstName).ToList();
        }

        public List<Contact> GetContactsByFullName(string firstName, string lastName)
        {
            return this._contactRepository.GetContacts(firstName: firstName, lastName: lastName).ToList();
        }

        public List<Contact> GetContactsByLastName(string lastName)
        {
            return this._contactRepository.GetContacts(lastName: lastName).ToList();
        }

        public List<Contact> GetContactsWithBirthdaysInCurrentMonth()
        {
            return this._contactRepository.GetContacts(month: 1).ToList();
        }

        public Contact UpdateContact(int contactId, Contact updatedContact)
        {
            // before updatating contract check if contract exist or not if not throw apporpriate exception 
            return this._contactRepository.UpdateContact(updatedContact);
        }
    }
}
