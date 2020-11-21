using FriendZone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics.Contracts;

namespace FriendZone.DAO
{
    public class ContactRepository : IContactRepository
    {
        private List<Contact> _contact;

        public ContactRepository()
        {
            this._contact = new List<Contact>();
        }
        public Contact CreateContact(Contact contact)
        {
          
            this._contact.Add(this.CloneContact(contact));

            return this.CloneContact(contact);
        }

        public Contact DeleteContact(int contactId)
        {
            var contact =this._contact.Find(c => c.ContactId == contactId);
            this._contact.Remove(contact);
            return contact;
        }

        public Contact GetContactById(int contactId)
        {
            var contact = this._contact.Find(c => c.ContactId == contactId);
            return this.CloneContact(contact);
        }

        public IReadOnlyList<Contact> GetContacts(string firstName = null, string lastName = null, int? month = null, string bloodGroup = null)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<Contact> GetContactsWithBirthdaysInCurrentMonth()
        {
            return null;
        }

        public bool IsContactNoExists(string contactNo)
        {
            return this._contact.Where(c => c.ContactNo == contactNo).FirstOrDefault() == null ? false : true;
        }

        public Contact UpdateContact(Contact updatedContact)
        {
            var contact = this._contact.Find(c => c.ContactId == updatedContact.ContactId);

            contact.ContactId = updatedContact.ContactId;
            contact.FirstName = updatedContact.FirstName;
            contact.LastName = updatedContact.LastName;
            contact.ContactNo = updatedContact.ContactNo;
            contact.Email = updatedContact.Email;
            contact.BirthDate = updatedContact.BirthDate;
            contact.Address = updatedContact.Address;
            contact.City = updatedContact.City;
            contact.Pincode = updatedContact.Pincode;
            contact.BloodGroup = updatedContact.BloodGroup;
            contact.CreationDate = updatedContact.CreationDate;

            return CloneContact(contact);
        }

       
        private Contact CloneContact(Contact InputContact)
        {
            if(InputContact == null) {
                return null;
            }
            Contact repoContact = new Contact()
            {
                ContactId=InputContact.ContactId,
                FirstName = InputContact.FirstName,
                LastName = InputContact.LastName,
                ContactNo = InputContact.ContactNo,
                Email = InputContact.Email,
                BirthDate = InputContact.BirthDate,
                Address = InputContact.Address,
                City = InputContact.City,
                Pincode = InputContact.Pincode,
                BloodGroup = InputContact.BloodGroup,
                CreationDate = InputContact.CreationDate


            };

            return repoContact;
        }
    }
}
