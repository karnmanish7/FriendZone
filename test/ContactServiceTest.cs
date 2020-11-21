using FriendZone.DAO;
using FriendZone.Entities;
using FriendZone.Service;
using Microsoft.VisualBasic;
using NUnit.Framework;

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
