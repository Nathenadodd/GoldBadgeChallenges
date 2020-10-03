using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealSpace
{
    //classes Pascal case
    public class Meal
    {//properties, constructors and fields
        public string MealNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public double Price { get; set; }

        public Meal() { }
        public Meal(string mealnumber, string name, string description, string ingredients, double price)
        {
            MealNumber = mealnumber;
            Name = name;
            Description = description;
            Ingredients = ingredients;
            Price = price;
        }

    }

}