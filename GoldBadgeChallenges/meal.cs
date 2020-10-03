using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadgeChallenges
{//classes Pascal case
    public class meal
    {//properties, constructors and fields
        string MealNumber { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        string Ingredients { get; set; }
        double Price { get; set; }

        public meal() { }
        public meal(string mealnumber, string name, string description, string ingredients, double price)
            {
            MealNumber = mealnumber;
            Name = name;
            Description = description;
            Ingredients = ingredients;
            Price = price;
            }
   
        



    }


}




