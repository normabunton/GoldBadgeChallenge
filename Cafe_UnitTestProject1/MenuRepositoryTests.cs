using CafeRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Cafe_UnitTestProject1
{
    [TestClass]
    public class MenuRepositoryTests
    {
        private MenuRepository _menuRepository = new MenuRepository();
        private Menu _menu = new Menu();
        [TestMethod]
            public void GetMealNumber_ShouldGetNotNull()
            {
            Menu content = new Menu();
            content.MealNumber = "1";
            MenuRepository repository = new MenuRepository();
            repository.AddItemToMenu(content);
            Menu contentFromDirectory = repository.GetMenuItemByMealNumber("1");
            Assert.IsNotNull(contentFromDirectory);
            }
        [TestMethod]
        public void RemoveItemFromMenu()
        {
            Menu Item1 = new Menu("1", "Sandwich", "Chicken Sandwich", "chicken, mayo, lettuce", 5.99);
            List<Menu> menu = _menuRepository.GetMenuItems();
            menu.Add(Item1);
            _menuRepository.RemoveItemFromMenu(Item1.MealNumber);
            bool menuContainsItem = menu.Contains(Item1);
            Assert.IsFalse(menuContainsItem);
        }
        [TestMethod]
        public void AddItemToMenuTest()
        {
            _menuRepository.AddItemToMenu(_menu);
            int expected = 1;
            int actual = _menuRepository.GetMenuItems().Count;

            Assert.AreEqual(expected, actual);
        }
    }
}
