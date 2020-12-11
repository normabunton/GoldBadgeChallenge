using CafeRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Cafe_UnitTestProject1
{
    [TestClass]
    public class CafeUnitTests
    {
        [TestMethod]
        public void SetNameOfMeal_ShoudlSetCorrectString()
        {
            Menu content = new Menu();

            content.NameOfMeal = "Sandwich";

            string expected = "Sandwich";
            string actual = content.NameOfMeal;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SetMealNumber_ShouldSetCorrectInt()
        {
            Menu content = new Menu();
            content.MealNumber = 1;
            int expected = 1;
            int actual = content.MealNumber;
            Assert.AreEqual(expected, actual);
        }
    }
}
