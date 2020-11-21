using FriendZone.DAO;
using FriendZone.Entities;
using FriendZone.Entities.Exceptions;
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
            if (contact == null)
                throw new InvalidInputException("Contract can not be null or empty");
           return this._contactRepository.CreateContact(contact);
        }

        public Contact DeleteContact(int contactId)
        {
            if (contactId <= 0)
                throw new InvalidInputException("Contact Id must be greater than 0");
            return this._contactRepository.DeleteContact(contactId);
        }

        public Contact GetContactById(int contactID)
        {

            if (contactID <= 0)
                throw new InvalidInputException("Contact Id must be greater than 0");
          
            var contact = this._contactRepository.GetContactById(contactID);

            if (contact == null)
                throw new ContactNotFoundException("Contact Not found");
            return contact;
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

        private bool ValidateContract(Contact contact)
        {
            // check all the properties on contact exist not return false
            return true;
        }
    }
}
