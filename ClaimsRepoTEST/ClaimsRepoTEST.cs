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
        private Claims _claims = new Claims();
        [TestInitialize]
        public void Arrange()
        {
            _claimsList = new ClaimsRepo();
        //    _claimsList = new Claims();
        }
        [TestMethod]
        public void GetClaimId_ShouldGetNotNull()
        {
            Claims claim = new Claims();
            claim.ClaimId = "1";
            ClaimsRepo repository = new ClaimsRepo();
            repository.AddClaimToList(claim);
            Claims contentFromDirectory = repository.GetClaimsByClaimId("1");
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
        [DataRow(1)]
        public void UpdateClaim_ShouldReturnTrue(string id)
        {
            Claims newClaims = new Claims("1", ClaimType.Car, "Car Accident on 465", 400.00, "4 / 25 / 18", "4 / 27 / 18", true);
            _claimsList.UpdateClaim(newClaims, id);
            //Queue<Claims> queue = _claimsList.GetClaims();

            // bool updateClaim = _claimsList.UpdateClaim("2", newClaims);
            // Assert.IsTrue(updateClaim);
        }
        [TestMethod]
        public void RemoveClaimFromQueue()
        {
            Claims Claim1 = new Claims("1", ClaimType.Car, "Car Accident on 465", 400.00, "4 / 25 / 18", "4 / 27 / 18", true);
            _claimsList.AddClaimToList(Claim1);
            Queue<Claims> queue = _claimsList.GetClaims();
            Assert.AreEqual(Claim1, queue.Dequeue());
        }
        [TestMethod]
        public void ClaimFromTopOfQueue_ShouldGetNotNull()
        {
            Claims claim = new Claims();
            Queue<Claims> queue = _claimsList.GetClaims();
            queue.ClaimFromTopOfQueue();
            Claims contentFromDirectory = repository.GetClaimsByClaimId("1");
            Assert.IsNotNull(contentFromDirectory);
        }
    }
}
