using BadgesRepository;
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
            //var Badges = new Dictionary<int, string>();
            //Badges.Add(123);
            //int expected = 1;
            //int count = Dictionary<int, string>.Count;
            //int actual = count;
            //Assert.AreEqual(expected, actual);
        }
        ////Add
        ////ListBadges
        ////UpdateBadge

        //    }
    }
}