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
        }
    }
}
