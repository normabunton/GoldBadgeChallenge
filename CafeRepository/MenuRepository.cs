using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRepository
{
    public class MenuRepository
    {
        public List<Menu> _menuItems = new List<Menu>();       
        public void AddItemToMenu(Menu menuItem)
        {
            _menuItems.Add(menuItem);
        }
        public List<Menu> GetMenuItems()
        {
            return _menuItems;
        }
        public bool RemoveItemFromMenu(string menuItem)        
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
        public Menu GetMenuItemByMealNumber(string mealNumber) 
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
