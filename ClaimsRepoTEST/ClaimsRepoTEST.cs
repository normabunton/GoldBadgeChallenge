using ClaimsRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClaimsRepoTEST
{
    [TestClass]
    public class ClaimsRepoTEST
    {
        private ClaimsRepository _claimsList = new ClaimsRepository();
        private Claims _claimsList = new Claims();

        //[TestMethod]
        //public void GetClaimId_ShouldGetNotNull()
        //{
        //    Claims claim = new Claims();
        //    Claims.ClaimId = "1";
        //    ClaimsRepository repository = new ClaimsRepository();
        //    repository.AddClaimToList(claims);
        //    CLaim contentFromDirectory = repository.GetClaimByClaimId("1");
        //    Assert.IsNotNull(contentFromDirectory);
        //}
        [TestMethod]
        public void AddClaimToClaimListTest()
        {
            _claimsList.AddClaimToClaimList(_claimsList);
            int expected = 1;
            int actual = _claimsRepository.AddClaimToList().Count;
            Assert.AreEqual(expected, actual);
        }
    }
}
