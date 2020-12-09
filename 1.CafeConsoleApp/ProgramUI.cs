using CafeRepository;
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
                                    "2. Delete a Menu Item\n" +
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
                        DeleteMenuItems();
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

            //Menu newMenu = new Menu();

            //Console.WriteLine("Enter the New Meal Number you would like to use:");
            //string mealNumberAsString = Console.ReadLine();
            //newMenu.mealNumberAsString = double.Parse(mealNumberAsString);

            //Console.WriteLine("Enter the Name of the Meal:");
            //newMenu.NameOfMeal = Console.ReadLine();

            //Console.WriteLine("Enter the Meal Desciption:");
            //newMenu.MealDescription = Console.ReadLine();

            //Console.WriteLine("Enter the Ingredients for this meal");
            //newMenu.Ingredients = Console.ReadLine();

            //Console.WriteLine("Enter the Price for this Meal(4.99, 5.99, 6.99, 7.99 etc):"); 
            //string priceAsString = Console.ReadLine();
            //newMenu.priceAsString = double.Parse(priceAsString);
        }

        private void DeleteMenuItems()                                                       //Delete MenuItems//////////////////////////
        {

        }
        private void DisplayAllMenuItems()                                                  //Display/View All MenuItems/////////////////////////////
        {

        }
    }
}
