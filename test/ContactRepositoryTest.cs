using FriendZone.DAO;
using FriendZone.Entities;
using Microsoft.VisualBasic;
using NUnit.Framework;

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
        public void GivenValidContractToContractRepositoryReturnCreatedContact()
        {
            var contract = new Contact() { Address = "abc" };

            var createdContract = _contactRepository.CreateContact(contract);

            Assert.AreEqual(contract.Address, createdContract.Address);
        }
        [TestCase]
        public void GivenWhenPassedValidContractIdToDeleteContractReturnsDeletedContact()
        {
            var contactId = 1;
            var result = _contactRepository.DeleteContact(contactId);
            var newContact = _contactRepository.GetContactById(contactId);
            Assert.AreEqual(result.ContactId, contactId);
            Assert.AreEqual(null, newContact);
        }
        [TestCase]
        public void ReturnValidContractWhenAskedContactById()
        {
            var contactId = 3;
            var newContact = _contactRepository.GetContactById(contactId);
            Assert.AreEqual(newContact.ContactId, contactId);
        }

        public void CheckContactExistOrNot()
        {

        }
        #endregion
        #region test_manipulation_methods



        #endregion

        public void WhenUpdatingValidContractReturnsThenUpdatedContact()
        {

        }

        #endregion

        #region negative_test_cases

        #region test_get_methods

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
