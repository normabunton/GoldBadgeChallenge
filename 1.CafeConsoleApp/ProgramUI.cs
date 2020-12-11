﻿using CafeRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.CafeConsoleApp
{
    class ProgramUI
    {
        private readonly MenuRepository _menuItems = new MenuRepository();
        public void Run()                              //Method that runs and starts the app
        {
            Menu();
        }
        //Menu
        public void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {                //Display options to the user
                Console.WriteLine("Select a menu option:\n" +
                                    "1. Create a new Menu Item\n" +
                                    "2. Remove a Menu Item\n" +
                                    "3. Diplay All Menu Items\n" +
                                    "4. Exit");
                //get the input
                string input = Console.ReadLine();
                //evaluate the input and act
                switch (input)
                {
                    case "1":
                        CreateNewMenuItem();
                        break;
                    case "2":
                        RemoveItemFromMenu();
                        break;
                    case "3":
                        DisplayAllMenuItems();
                        break;
                    case "4":
                        Console.WriteLine("Thank you, Goobye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.Thank you");
                        break;
                }
                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();

                //test
            }
        }
        public void CreateNewMenuItem()                                                    //create new MenuItem//////////////////////////
        {
            Console.Clear();
            Console.WriteLine("Enter the Meal Number you would like to use:");
            int mealNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Name of the Meal:");
            string mealName = Console.ReadLine();

            Console.WriteLine("Enter the Meal Description:");
            string mealDescription = Console.ReadLine();

            Console.WriteLine("Enter the Meal Ingredients");
            string mealIngredients = Console.ReadLine();

            Console.WriteLine("Enter the Price");
            double price = Convert.ToDouble(Console.ReadLine());

            Menu newItem = new Menu(mealNumber, mealName, mealDescription, mealIngredients, price);
            _menuItems.AddItemToMenu(newItem);
            Console.WriteLine("You successfully added a new Menu Item.");
            Console.ReadKey();
        }

        private void RemoveItemFromMenu()                                                    
        {
            Console.Clear();
            DisplayAllMenuItems();
            //Get the MEalNumber
            Console.WriteLine("Enter the Meal Number you would like to Remove:");
            int menuItem = Convert.ToInt32(Console.ReadLine());        
            //Call the delete method
            bool wasDeleted = _menuItems.RemoveItemFromMenu(menuItem);
            //If the item was deleted say so
            if (wasDeleted)
            {
                Console.WriteLine("The Menu Item was Successfully Removed.");
            }
            //otherwise  state it could not be deleted
            else
            {
                Console.WriteLine("The Menu Item was not Removed.");
            }
        }
        private void DisplayAllMenuItems()                                                  //Display/View All MenuItems/////////////////////////////
        {
            Console.Clear();
            List<Menu> listOfMenuItems = _menuItems.GetMenuItems();
            foreach (Menu menuItems in listOfMenuItems)
            {
                Console.WriteLine($"Meal Number: {menuItems.MealNumber}\n" +
                                    $"Name Of Meal: {menuItems.NameOfMeal}");
            }
        }
        private void SeeMenuItems()
        {
            Menu Item1 = new Menu(1, "Sandwich", "Chicken Sandwich", "chicken, mayo, lettuce", 5.99);
            Menu Item2 = new Menu(2, "Soup", "Vegetable Soup", "veggies, broth", 4.99);
            Menu Item3 = new Menu(3, "Salad", "House Salad", "Lettuce, Tomatoes, Cheese, Dressing", 3.99);

            _menuItems.AddItemToMenu(Item1);
            _menuItems.AddItemToMenu(Item2);
            _menuItems.AddItemToMenu(Item3);
            
        }
    }
}
