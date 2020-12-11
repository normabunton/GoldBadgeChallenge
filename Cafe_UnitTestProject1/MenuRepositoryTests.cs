using CafeRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Cafe_UnitTestProject1
{
    [TestClass]
    public class MenuRepositoryTests
    {
            [TestMethod] ///ADD
            public void AddToList_ShouldGetNotNull()
            {
            Menu content = new Menu();
            content.NameOfMeal = "Sandwich";
            MenuRepository repository = new MenuRepository();

            repository.AddItemToMenu(content);
            Menu contentFromDirectory = repository.AddItemToMenu("Sandwich");

            Assert.IsNotNull(contentFromDirectory);
            }
    }
}
