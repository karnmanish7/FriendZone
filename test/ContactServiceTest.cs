using FriendZone.DAO;
using FriendZone.Entities;
using FriendZone.Service;
using Microsoft.VisualBasic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    public class ContactServiceTest
    {
        private IContactRepository _contractRepository;
        private IContactService _contractService;

        [SetUp]
        public void SetUp()
        {
            seedData();
        }
        [TearDown]
        public void TearDown()
        {
            _contractRepository = null;
            _contractService = null;
        }
        #region positive_test_cases

        #region test_get_methods
        [TestCase]
        public void DeleteContact()
        {
            var contactId = 2;
            var result = _contractService.DeleteContact(contactId);
           
            Assert.AreEqual(result.ContactId, contactId);
        
        }
        [TestCase]
        public void GetContactById()
        {

            var contactId = 2;
            var newContact = _contractService.GetContactById(contactId);
            Assert.AreEqual(newContact.ContactId, contactId);
        }
      
       
        [TestCase]
        public void GetContactsByBloodGroup()
        {
            
            string bloodGroup = "B+";
            var contactByBloodgroup = this._contractService.GetContactsByBloodGroup(bloodGroup: bloodGroup).ToList();
            Assert.AreEqual(contactByBloodgroup[0].BloodGroup, bloodGroup);
            
        }
        [TestCase]
        public void GetContactsByFirstName()
        {
            string firstName = "jackUpdated";
            var contactByFirstname = this._contractService.GetContactsByFirstName(FirstName: firstName).ToList();
            Assert.AreEqual(contactByFirstname[0].FirstName, firstName);
        }
       
        [TestCase]
        public void GetContactsByLastName()
        {
            string lastName = "mike";
            var contactByLastname = this._contractService.GetContactsByLastName(lastName: lastName).ToList();
            Assert.AreEqual(contactByLastname[0].LastName, lastName);
        }
        
        [TestCase]
        public void UpdateContact()
        {
            var contact = new Contact()
            {
                ContactId = 1,
                FirstName = "jackUpdated",
                LastName = "mike",
                ContactNo = "8107898901",
                Email = "jack@test.com",
                BirthDate = "11/01/1999",
                Address = "blr",
                City = "bangalore",
                Pincode = "54990",
                BloodGroup = "b+",
                CreationDate = DateAndTime.Now.ToString()
            };
            var result = _contractService.UpdateContact(contact.ContactId,contact);
            var newContact = _contractService.GetContactById(result.ContactId);
            Assert.AreEqual(result, newContact);
        }
        [TestCase]
        public void ValidateContact()
        {
            // check all the properties on contact exist not return false
            var contact = new Contact()
            {
                ContactId = 1,
                FirstName = "mkcheck",
                LastName = "karn",
                ContactNo = "8107898901",
                Email = "m.karn@test.com",
                BirthDate = "01/01/1995",
                Address = "blr",
                City = "bangalore",
                Pincode = "549900",
                BloodGroup = "B+",
                CreationDate = DateAndTime.Now.ToString()

            };
            var validcontact = _contractService.ValidateContact(contact);
            Assert.IsTrue(validcontact);
        }
        [TestCase]
        public void GivenValidContractToContractServiceReturnCreatedContract()
        {
            var contact = new Contact() {
                ContactId = 1,
                FirstName = "mkcheck",
                LastName = "karn",
                ContactNo = "8107898901",
                Email = "m.karn@test.com",
                BirthDate = "01/01/1995",
                Address = "blr",
                City = "bangalore",
                Pincode = "549900",
                BloodGroup = "B+",
                CreationDate = DateAndTime.Now.ToString()

            };

            var createdContract = _contractService.AddContact(contact);

            Assert.AreEqual(contact.Address, createdContract.Address);
        }
        #endregion

        #region test_manipulation_methods

      
        #endregion

        #endregion

        #region negative_test_cases


        #region test_get_methods

        #endregion


        #region test_manipulation_methods


        #endregion

        #endregion

        #region SeedData
        public void seedData()
        {
            _contractRepository = new ContactRepository();
            _contractRepository.CreateContact(new Contact()
            {
                ContactId = 1,
                FirstName = "jackUpdated",
                LastName = "mike",
                ContactNo = "8107898901",
                Email = "jackUpdated.mike@test.com",
                BirthDate = "11/02/1999",
                Address = "blr",
                City = "bangalore",
                Pincode = "549902",
                BloodGroup = "B+",
                CreationDate = DateAndTime.Now.ToString()
            });
            _contractRepository.CreateContact(new Contact()
            {
                ContactId = 2,
                FirstName = "mk",
                LastName = "karn",
                ContactNo = "8107898901",
                Email = "m.karn@test.com",
                BirthDate = "02/03/1999",
                Address = "blr",
                City = "bangalore",
                Pincode = "549901",
                BloodGroup = "A+",
                CreationDate = DateAndTime.Now.ToString()
            });
            _contractService = new ContactService(_contractRepository);

        }


        #endregion
    }
}
