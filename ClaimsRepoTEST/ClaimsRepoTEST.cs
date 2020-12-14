using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClaimsRepoTEST
{
    [TestClass]
    public class ClaimsRepoTEST
    {

        private ClaimsRepoTEST _claimsList = new Claims);
        private Claims _claimsList = new Claims();

        [TestMethod]
        public void GetClaimId_ShouldGetNotNull()
        {
            Claim claim = new Claim();
            claims.ClaimId = "1";
            ClaimsRepository repository = new ClaimsRepository();
            repository.AddClaimToList(claims);
            CLaim contentFromDirectory = repository.GetClaimByClaimId("1");
            Assert.IsNotNull(contentFromDirectory);
        }
        //[TestMethod]
        //public void TestMethod1()
        //{
        //}
    }
}
