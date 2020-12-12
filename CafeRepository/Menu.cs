using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRepository
{
    public class Menu         //POCO
    {
        public string MealNumber { get; set; }
        public string NameOfMeal { get; set; }
        public string MealDescription { get; set; }
        public string Ingredients { get; set; }
        public double Price { get; set; }
        public Menu() { }                                                                                         
        public Menu(string mealNumber, string nameOfMeal, string mealDescription, string ingredients, double price) 
        {
            MealNumber = mealNumber;
            NameOfMeal = nameOfMeal;
            MealDescription = mealDescription;
            Ingredients = ingredients;
            Price = price;
        }
    }
}
