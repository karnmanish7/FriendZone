using FriendZone.DAO;
using FriendZone.Entities;
using FriendZone.Service;
using Microsoft.VisualBasic;
using NUnit.Framework;
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
            var contactId = 1;
            var result = _contractService.DeleteContact(contactId);
            var newContact = _contractService.GetContactById(contactId);
            Assert.AreEqual(result.ContactId, contactId);
            Assert.AreEqual(null, newContact);
        }
        [TestCase]
        public void GetContactById()
        {

            var contactId = 2;
            var newContact = _contractService.GetContactById(contactId);
            Assert.AreEqual(newContact.ContactId, contactId);
        }
        [TestCase]
        public void GetContacts()
        {
            var contacts = new List<Contact>();

            var allContacts = _contractService.GetContacts().FirstOrDefault();

            Assert.AreEqual(contacts, allContacts);
        }
        [TestCase]
        public void GetContactsByBirthMonth()
        {
            int month = 11;
            var contactBybirthMonth =this._contractService.GetContactsByBirthMonth(month: month).ToList();
            Assert.AreEqual(contactBybirthMonth, month);
        }
        [TestCase]
        public void GetContactsByBloodGroup()
        {
            
            string bloodGroup = "b+";
            var contactByBloodgroup = this._contractService.GetContactsByBloodGroup(bloodGroup: bloodGroup).ToList();
            Assert.AreEqual(contactByBloodgroup, bloodGroup);
        }
        [TestCase]
        public void GetContactsByFirstName()
        {
            string firstName = "mannn";
            var contactByFirstname = this._contractService.GetContactsByFirstName(firstName: firstName).ToList();
            Assert.AreEqual(contactByFirstname, firstName);
        }
        [TestCase]
        public void GetContactsByFullName()
        {
            string firstName = "mannn";
            string lastName = "k";
           
            var contactByFullname = this._contractService.GetContactsByFullName(firstName: firstName,lastName:lastName).ToList();
            Assert.AreEqual(contactByFullname, firstName+lastName);
        }
        [TestCase]
        public void GetContactsByLastName()
        {
            string lastName = "K";
            var contactByLastname = this._contractService.GetContactsByLastName(lastName: lastName).ToList();
            Assert.AreEqual(contactByLastname, lastName);
        }
        [TestCase]
        public void GetContactsWithBirthdaysInCurrentMonth()
        {
            string currentMonth = "11";
            var contactByCurrentMonth = this._contractService.GetContactsWithBirthdaysInCurrentMonth();
            Assert.AreEqual(contactByCurrentMonth, currentMonth);
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
                BirthDate = "01/01/1999",
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
        private bool ValidateContact(Contact contact)
        {
            // check all the properties on contact exist not return false
            return true;
        }
        [TestCase]
        public void GivenValidContractToContractServiceReturnCreatedContract()
        {
            var contract = new Contact() {
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

            var createdContract = _contractService.AddContact(contract);

            Assert.AreEqual(contract.Address, createdContract.Address);
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
                FirstName = "mk",
                LastName = "karn",
                ContactNo = "8107898901",
                Email = "m.karn@test.com",
                BirthDate = "01/01/1999",
                Address = "blr",
                City = "bangalore",
                Pincode = "54990",
                BloodGroup = "b+",
                CreationDate = DateAndTime.Now.ToString()
            });
            _contractRepository.CreateContact(new Contact()
            {
                ContactId = 2,
                FirstName = "mk",
                LastName = "karn",
                ContactNo = "8107898901",
                Email = "m.karn@test.com",
                BirthDate = "01/01/1999",
                Address = "blr",
                City = "bangalore",
                Pincode = "54990",
                BloodGroup = "b+",
                CreationDate = DateAndTime.Now.ToString()
            });
            _contractService = new ContactService(_contractRepository);

        }


        #endregion
    }
}
