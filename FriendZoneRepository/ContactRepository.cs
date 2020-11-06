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
          
            this._contact.Add(this.CloneContract(contact));

            return this.CloneContract(contact);
        }

        public Contact DeleteContact(int contactId)
        {
            var contract =this._contact.Find(c => c.ContactId == contactId);
            this._contact.Remove(contract);
            return contract;
        }

        public Contact GetContactById(int contactId)
        {
            var contract = this._contact.Find(c => c.ContactId == contactId);
            return this.CloneContract(contract);
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
            var contract = this._contact.Find(c => c.ContactId == updatedContact.ContactId);

            contract.ContactId = updatedContact.ContactId;
            contract.FirstName = updatedContact.FirstName;
            contract.LastName = updatedContact.LastName;
            contract.ContactNo = updatedContact.ContactNo;
            contract.Email = updatedContact.Email;
            contract.BirthDate = updatedContact.BirthDate;
            contract.Address = updatedContact.Address;
            contract.City = updatedContact.City;
            contract.Pincode = updatedContact.Pincode;
            contract.BloodGroup = updatedContact.BloodGroup;
            contract.CreationDate = updatedContact.CreationDate;

            return CloneContract(contract);
        }

       
        private Contact CloneContract(Contact InputContact)
        {
            Contact repoContract = new Contact()
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

            return repoContract;
        }
    }
}
