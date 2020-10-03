
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRepository2
{
    public class CafeRepository
    {
        private List<Meal> _listofMeal = new List<Meal>();

        //Create
        public void AddMealToList(Meal content)
        {
            _listofMeal.Add(content);
        }

        //Read
        public List<Meal> GetMealList()
        {
            return _listofMeal;
        }

        //Update(not needed right now)

        //Delete
        public bool RemoveMealFromList(string MealNumber)
        {
            Meal content = GetMealByNumber(MealNumber);
            if (content != null)
            {
                _listofMeal.Remove(content);
                return true;
            }
            else
            {
                return false;
            }
        }

        //Helper method
        public Meal GetMealByNumber(string mealnumber)
        {
            foreach (Meal content in _listofMeal)
            {
                if (content.MealNumber == mealnumber)
                {
                    return content;
                }
               
            }
            return null;
        }  
    }
}