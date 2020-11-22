using FriendZone.DAO;
using FriendZone.Entities;
using Microsoft.VisualBasic;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    [TestFixture]
    public class ContactRepositoryTest
    {
        private IContactRepository _contactRepository;
        [SetUp]
        public void SetUp()
        {
            seedData();
        }
        [TearDown]
        public void TearDown()
        {
            _contactRepository = null;
        }
        #region positive_test_cases

        #region test_get_methods

        [TestCase]
        public void ReturnValidContactWhenAskedGetAllContacts()
        {
            var contacts = new List<Contact>();

            var allContacts = _contactRepository.GetContacts().ToList();

            Assert.AreEqual(contacts, allContacts);
        }

        [TestCase]
        public void GivenValidContactToContractRepositoryReturnCreatedContact()
        {
            var contract = new Contact() { Address = "abc" };

            var createdContract = _contactRepository.CreateContact(contract);

            Assert.AreEqual(contract.Address, createdContract.Address);
        }
       
        [TestCase]
        public void ReturnValidContactWhenAskedContactById()
        {
            var contactId = 2;
            var newContact = _contactRepository.GetContactById(contactId);
            Assert.AreEqual(newContact.ContactId, contactId);
        }

        public void CheckContactExistOrNot()
        {
            var contactId = 1;
            bool isContactExist = _contactRepository.IsContactExists(contactId);
            Assert.IsTrue(isContactExist);
        }
        #endregion
        #region test_manipulation_methods

        [TestCase]
        public void GivenWhenPassedValidContactIdToDeleteContractReturnsDeletedContact()
        {
            var contactId = 1;
            var result = _contactRepository.DeleteContact(contactId);
            var newContact = _contactRepository.GetContactById(contactId);
            Assert.AreEqual(result.ContactId, contactId);
            Assert.AreEqual(null, newContact);
        }
        [TestCase]
        public void WhenUpdatingValidContactReturnsThenUpdatedContact()
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
            var result = _contactRepository.UpdateContact(contact);
            var newContact = _contactRepository.GetContactById(result.ContactId);
            Assert.AreEqual(result, newContact);
        }

        #endregion

        #endregion

        #region negative_test_cases

        #region test_get_methods
        [TestCase]
        public void ReturnValidContactWhenAskedGetAllContacts()
        {
            var contacts = new List<Contact>();

            var allContacts = _contactRepository.GetContacts().ToList();

            Assert.AreEqual(contacts, allContacts);
        }
        [TestCase]
        public void WhenUpdatingInValidContactReturnsThenUpdatedContact()
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
            var result = _contactRepository.UpdateContact(contact);
            var newContact = _contactRepository.GetContactById(2);
            Assert.AreNotEqual(result, newContact);
        }
        [TestCase]
        public void GivenWhenPassedInValidContactIdToDeleteContractReturnsDeletedContact()
        {
            var contactId = 2;
            var result = _contactRepository.DeleteContact(contactId);
            var newContact = _contactRepository.GetContactById(1);
            Assert.AreNotEqual(result.ContactId, 1);
            Assert.AreNotEqual(null, newContact);
        }
        [TestCase]
        public void ReturnInValidContactWhenAskedContactById()
        {
            var contactId = 2;
            var newContact = _contactRepository.GetContactById(contactId);
            Assert.AreNotEqual(newContact.ContactId, 3);
        }
        #endregion


        #endregion


        #region SeedData
        public void seedData()
        {
            _contactRepository = new ContactRepository();
            _contactRepository.CreateContact(new Contact()
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
            _contactRepository.CreateContact(new Contact()
            {
                ContactId = 2,
                FirstName = "mann",
                LastName = "k",
                ContactNo = "8107898902",
                Email = "test.karn@test.com",
                BirthDate = "01/01/1990",
                Address = "blr",
                City = "chennai",
                Pincode = "641035",
                BloodGroup = "b+",
                CreationDate = DateAndTime.Now.ToString()
            });
           
        }

        #endregion

    }
}
