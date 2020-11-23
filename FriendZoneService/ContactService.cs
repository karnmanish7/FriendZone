using FriendZone.DAO;
using FriendZone.Entities;
using FriendZone.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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
            if (contact.FirstName == null || contact.ContactNo == null || contact.CreationDate == null)
                throw new InvalidInputException("invalid inputs");
            if (contact.FirstName.Length < 3)
                throw new InvalidInputException("Name length should not be less than 3 characters");
            bool isValidName = IsAlphabets(contact.FirstName) && IsAlphabets(contact.LastName);
            if (!isValidName)
                throw new InvalidInputException("Name should contains only alphabest");
            var isValidBloodGroupType = IsValidBloodGroup(contact.BloodGroup);
            if (!isValidBloodGroupType)
                throw new InvalidInputException("BloodGroup should accept only the values : A+, A-, B+, B-, AB+, AB-, O+, O-");
            var isValidPin = IsValidPincode(contact.Pincode);
            if (!isValidPin)
                throw new InvalidInputException("Pincode should be 6 digits only");
            if (contact.ContactNo.Length!=10)
                throw new InvalidInputException("ContactNO should be 10 digits only");
            DateTime dileverydate = Convert.ToDateTime(contact.BirthDate);
            var todaysDate = DateTime.Today;
            int result = DateTime.Compare(dileverydate, todaysDate);
            // Calculate the age.
            var age = todaysDate.Year - dileverydate.Year;
            if (result > 0 || age<15)
                throw new InvalidInputException("birthDate should not be greater than current date and age should be atleast 15 years");
            return this._contactRepository.CreateContact(contact);
        }
        public bool IsAlphabets(string inputString)
        {
            Regex r = new Regex("^[a-zA-Z ]+$");
            if (r.IsMatch(inputString))
                return true;
            else
                return false;
        }
        public bool IsValidBloodGroup(string inputString)
        {
            Regex r = new Regex("(A|B|AB|O)[+-]");
            if (r.IsMatch(inputString))
                return true;
            else
                return false;
        }
        public bool IsValidPincode(string inputString)
        {
            //Regex r = new Regex("^[1-9] [0-9]{6}$");
            Regex r = new Regex("^[1-9]{1}[0-9]{2}\\s{0,1}[0-9]{3}$");
            
            if (r.IsMatch(inputString))
                return true;
            else
                return false;
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

        public bool ValidateContact(Contact contact)
        {
            // check all the properties on contact exist not return false
            if (contact.FirstName != null || contact.ContactNo != null || contact.CreationDate != null)
            {
                return true;
            }
            else
            {
                return false;
            }
               
        }
    }
}
