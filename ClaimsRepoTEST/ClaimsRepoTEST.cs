using ClaimsRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClaimsRepoTEST
{
    [TestClass]
    public class ClaimsRepoTEST
    {
        private ClaimsRepo _claimsList = new ClaimsRepo();
        private Claims _claims = new Claims();
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
        public void UpdateClaim_ShouldReturnTrue()
        {
            Claims newClaims = new Claims("1", ClaimType.Car, "Car Accident on 465", 400.00, "4 / 25 / 18", "4 / 27 / 18", true);
            bool updateClaim = _claimsList.UpdateClaim("2", newClaims);
            Assert.IsTrue(updateClaim);
        }
        [TestMethod]
        public void RemoveClaimFromQueue()
        {
            Claims Claim1 = new Claims("1", ClaimType.Car, "Car Accident on 465", 400.00, "4 / 25 / 18", "4 / 27 / 18", true);
            Queue<Claims> queue = _claimsList.GetClaims();
            queue.Add(Claim1);
            _claimsList.RemoveClaimFromQueue(Claim1.ClaimId);
            bool claimContainsItem = queue.Contains(Claim1);
            Assert.IsFalse(claimContainsItem);
        }
        [TestMethod]
        public void ClaimFromTopOfQueue_ShouldGetNotNull()
        {
            Claims claim = new Claims();
            claim.ClaimId = "1";
            ClaimsRepo repository = new ClaimsRepo();
            repository.ClaimFromTopOfQueue(_claims, claim);
            Claims contentFromDirectory = repository.GetClaimsByClaimId("1");
            Assert.IsNotNull(contentFromDirectory);
        }
    }
}
