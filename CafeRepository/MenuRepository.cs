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
        public bool RemoveItemFromMenu(int mealNumber)        //delete menu items
        {
            Menu menuItem = GetMenuItemByMealNumber(mealNumber);
            if (menuItem == null)
            {
                return false;
            }
            int initialCount = _menuItems.Count;
            _menuItems.Remove(menuItem);
            if (initialCount > _menuItems.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private Menu GetMenuItemByMealNumber(int mealNumber) //HelperMethod
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
