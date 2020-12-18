using BadgeRepoTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BadgeRepoTest
{
    [TestClass]
    public class badgestest
    {
        private int badgeid;
        private object badgesTest;

        [TestMethod]
        public void getbadgebyid_shouldgetnotnull()
        {
            badgestest badge = new badgestest();
            badge.badgeid = 123;
            Dictionary<int, string> Badges = new Dictionary<int, string>();
            Assert.IsNotNull(Badges);
        }
        [TestMethod]
        public void AddBadgeToList()
        {
           
        }
        [TestMethod]
        public void ListBadges()
        {

        }

    }
}