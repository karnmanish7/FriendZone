using FriendZone.DAO;
using FriendZone.Entities;
using Microsoft.VisualBasic;
using NUnit.Framework;

namespace test
{
    [TestFixture]
    public class ContactRepositoryTest
    {
        private IContactRepository _contractRepository;
        [SetUp]
        public void SetUp()
        {
            seedData();
        }
        [TearDown]
        public void TearDown()
        {
            _contractRepository = null;
        }
        #region positive_test_cases

        #region test_get_methods



        #endregion
        [TestCase]
        public void GivenValidContractToContractRepositoryReturnCreatedContract()
        {
            var contract = new Contact() { Address = "abc" };

            var createdContract = _contractRepository.CreateContact(contract);

            Assert.AreEqual(contract.Address, createdContract.Address);
        }

        public void GivenWhenPassedValidContractIdToDeleteContractReturnsDeletedContract()
        {

        }

        public void ReturnValidContractWhenAskedContractById()
        {

        }

        public void CheckContractExistOrNot()
        {

        }   

        #region test_manipulation_methods



        #endregion

        public void WhenUpdatingValidContractReturnsThenUpdatedContract()
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
           
        }

        #endregion

    }
}
