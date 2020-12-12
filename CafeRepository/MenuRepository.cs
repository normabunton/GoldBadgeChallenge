using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRepository
{
    public class MenuRepository
    {
        public List<Menu> _menuItems = new List<Menu>();       //create new menu items
        public void AddItemToMenu(Menu menuItem)
        {
            _menuItems.Add(menuItem);
        }
        public List<Menu> GetMenuItems()                        //read list of all items on the cafe menu
        {
            return _menuItems;
        }
        public bool RemoveItemFromMenu(string menuItem)        //delete menu items
        {
            int initialCount = _menuItems.Count;
            Menu deletedItem = GetMenuItemByMealNumber(menuItem);
            _menuItems.Remove(deletedItem);
            if (initialCount > _menuItems.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Menu GetMenuItemByMealNumber(string mealNumber) //HelperMethod
        {
            foreach (Menu menuItems in _menuItems)
            {
                if (menuItems.MealNumber == mealNumber)
                {
                    return menuItems;
                }
            }
            return null;
        }
    }
}
