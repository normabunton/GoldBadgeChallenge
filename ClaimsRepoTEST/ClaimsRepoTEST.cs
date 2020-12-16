using ClaimsRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ClaimsRepoTEST
{
    [TestClass]
    public class ClaimsRepoTEST
    {
        private ClaimsRepo _claimsList;
        private Claims _claims;
        [TestInitialize]
        public void Arrange()
        {
            _claimsList = new ClaimsRepo();
            _claims = new Claims(3, ClaimType.Theft, "Stolen Pancakes", 4.00, new DateTime(2018, 06, 01), new DateTime (2018, 06, 20));
            _claimsList.AddClaimToList(_claims);
        }
        [TestMethod]
        public void GetClaimId_ShouldGetNotNull()
        {
            Claims claim = new Claims();
            claim.ClaimId = 1;
            ClaimsRepo repository = new ClaimsRepo();
            repository.AddClaimToList(claim);
            Claims contentFromDirectory = repository.GetClaimsByClaimId(1);
            Assert.IsNotNull(contentFromDirectory);
        }
        [TestMethod]
        public void AddClaimToListTest()
        {
            _claimsList.AddClaimToList(_claims);
            int expected = 1;
            int actual = _claimsList.GetClaims().Count;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        //[DataRow(1)]
        public void UpdateClaim_ShouldReturnTrue()
        {
            Claims newClaims = new Claims(3, ClaimType.Theft, "Stolen Pancakes", 4.00, new DateTime(2018, 06, 01), new DateTime(2018, 06, 20));
            bool updated = _claimsList.UpdateClaim(1, newClaims);
            
            //Queue<Claims> queue = _claimsList.GetClaims();

            // bool updateClaim = _claimsList.UpdateClaim("2", newClaims);
            Assert.IsTrue(updated);
        }
        [TestMethod]
        public void RemoveClaimFromQueue()
        {
            Claims Claim1 = new Claims(3, ClaimType.Theft, "Stolen Pancakes", 4.00, new DateTime(2018, 06, 01), new DateTime(2018, 06, 20));
            _claimsList.AddClaimToList(Claim1);
            Queue<Claims> queue = _claimsList.GetClaims();
            Assert.AreEqual(Claim1, queue.Dequeue());
        }

        [TestMethod]
        public void GetClaimFromTopOfQueue_IsNotNull()
        {
            Claims claims = _claimsList.ClaimFromTopOfQueue();
            Assert.IsNotNull(claims);
        }
        //[TestMethod]
        //public void ClaimFromTopOfQueue_ShouldGetNotNull()
        //{
        //    Claims claim = new Claims();
        //    Queue<Claims> queue = _claimsList.GetClaims();
        //    queue.ClaimFromTopOfQueue();
        //    Claims contentFromDirectory = repository.GetClaimsByClaimId("1");
        //    Assert.IsNotNull(contentFromDirectory);
        //}
    }
}
