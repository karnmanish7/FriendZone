using FriendZone.DAO;
using FriendZone.Entities;
using NUnit.Framework;

namespace test
{
    [TestFixture]
    public class ContactRepositoryTest
    {
        private IContactRepository _contractRepository = new ContactRepository();
        public void SetUp()
        {

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


        #endregion

    }
}
